using KorisnickiInterfejs.ServerCommunication;
using System;
using System.Collections.Generic;
using System.Linq;
using Common;
using Domain;
using System.Windows.Forms;
using KorisnickiInterfejs.GUISession;
using KorisnickiInterfejs.Forms;
using KorisnickiInterfejs.Exceptions;

namespace KorisnickiInterfejs.GUIController
{
    public class LogBookController
    {
        FrmLogBook logBook;
        bool IsInit = true;
        internal void InitData(FrmLogBook logBook)
        {
            try
            {
            this.logBook = logBook;
            InitializeComponent();
            logBook.CbAircraft.SelectedIndex = -1;
            logBook.DpLastUpdate.CustomFormat = " ";
            logBook.DpFlightTimeStart.CustomFormat = "dd/MM/yyyy HH:mm";
            logBook.DpFlightTimeStop.CustomFormat = "dd/MM/yyyy HH:mm";
            IsInit = false;
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da pronađe podatke o avionu i aerodromima!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                logBook.Dispose();
                logBook = null;
            }
        }

        private void InitializeComponent()
        {
                List<Airport> listAirport = UcitajListuAerodroma();
                logBook.CbAirport.DataSource = listAirport.ToList();
                logBook.CbAirportFrom.DataSource = listAirport.ToList();
                logBook.CbAirportTo.DataSource = listAirport.ToList();
                logBook.CbAircraft.DataSource = UcitajListuAviona();              
                logBook.CbAirportFrom.SelectedIndex = logBook.CbAirport.SelectedIndex;
                logBook.CbAirportTo.SelectedIndex = -1;

                if (Session.Instance.LogBookCurrentDate != DateTime.MinValue)
                {
                    logBook.DpFlightTimeStart.Value = Session.Instance.LogBookCurrentDate.Date;
                    logBook.DpFlightTimeStop.Value = Session.Instance.LogBookCurrentDate.Date;
                }
                else
                {
                    logBook.DpFlightTimeStart.Value = DateTime.Now;
                    logBook.DpFlightTimeStop.Value = DateTime.Now;
                }

                if (Session.Instance.LogBookCurrentAircraft != null)
                    logBook.CbAircraft.SelectedItem = Session.Instance.LogBookCurrentAircraft;
        }

        internal void NewFlight()
        {
            logBook.CbAircraft.SelectedItem = null;
            logBook.TxtIDLogBook.Text = string.Empty;
            logBook.TxtDuration.Text = string.Empty;
            logBook.TxtFlightNumber.Text = string.Empty;
            logBook.CbAirportTo.SelectedIndex = -1;
            logBook.BtnAddFlight.Enabled = true;
            logBook.BtnNewFlight.Enabled = false;
            IsInit = true;
            AircraftRefresh();
        }

        internal void FlightChanged()
        {
            try
            {
                TimeSpan ts = DateTime.Parse(logBook.DpFlightTimeStop.Text) - DateTime.Parse(logBook.DpFlightTimeStart.Text);
                double differenceInMinuts = ts.TotalMinutes;
                if (differenceInMinuts > 0) 
                    logBook.TxtDuration.Text = differenceInMinuts.ToString();
                else
                    logBook.TxtDuration.Text = string.Empty;
            }
            catch (Exception)
            {
                logBook.TxtDuration.Text = string.Empty;
            }
        }

        internal void AddFlight()
        {
            try
            {
                if (!Validation())
                {
                    MessageBox.Show("Unos podataka nije validan!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    return;
                }
                LogBook lb = ZapamtiLet();   
                logBook.TxtIDLogBook.Text = lb.ID_LogBook.ToString();
                MessageBox.Show("Sistem je dodao let u evidenciju realizovanih letoval!", "Sistem Operation is succesful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                Session.Instance.LogBookCurrentAircraft = (Aircraft)logBook.CbAircraft.SelectedItem;
                Session.Instance.LogBookCurrentDate = DateTime.Parse(DateTime.Parse(logBook.DpFlightTimeStop.Text).ToString("dd/MM/yyyy"));
                logBook.BtnAddFlight.Enabled = false;
                logBook.BtnNewFlight.Enabled = true;
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da sačuva podatke o realizovanom letu!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                logBook.Dispose();
                logBook = null;
            }
        }

        private decimal hours_add (decimal h1, decimal h2)
        {
            int z1;
            int z2;
            z1 = (int)(h1 * 100 / 100) * 60 + (int)(h1 * 100) % 100;
            z2 = (int)(h2 * 100 / 100) * 60 + (int)(h2 * 100) % 100;
            return (int)((z1 + z2) / 60) + (decimal)((z1 + z2) % 60) / 100;
        }

        private bool Validation()
        {
            DateTime flightStart;
            DateTime flightStop;
            int duration;
            if (!DateTime.TryParse(logBook.DpFlightTimeStart.Text, out flightStart)) return false;
            if (!DateTime.TryParse(logBook.DpFlightTimeStop.Text, out flightStop)) return false;
            if (!int.TryParse(logBook.TxtDuration.Text, out duration)) return false;
            if (logBook.CbAirportTo.SelectedItem == null) return false;
            if (logBook.CbAirportFrom.SelectedItem == logBook.CbAirportTo.SelectedItem) return false;
            if (logBook.DpLastUpdate.Value > logBook.DpFlightTimeStart.Value) return false;
            if (logBook.DpFlightTimeStart.Value > logBook.DpFlightTimeStop.Value) return false;
            if (logBook.TxtFlightNumber.Text == string.Empty) return false;
            return true;
        }

        internal void AircraftChanged()
        {
            AircraftRefresh();
        }

        private void AircraftRefresh()
        {
            try
            {
                if ((Aircraft)logBook.CbAircraft.SelectedItem != null)
                {
                    Aircraft aircraft = UcitajAvion(((Aircraft)logBook.CbAircraft.SelectedItem).RegistrationNumber);
                    logBook.TxtLastACHours.Text = aircraft.LastACHours.ToString();
                    logBook.TxtLastACCycles.Text = aircraft.LastACCycles.ToString();
                    logBook.DpLastUpdate.CustomFormat = "dd/MM/yyyy HH:mm";
                    logBook.DpLastUpdate.Value = aircraft.LastUpdate;
                    logBook.CbAirport.SelectedItem = aircraft.Airport;
                    logBook.CbAirportFrom.SelectedItem = aircraft.Airport;
                    if (Session.Instance.LogBookCurrentDate != DateTime.MinValue)
                    {
                        logBook.DpFlightTimeStart.Value = Session.Instance.LogBookCurrentDate.Date;
                        logBook.DpFlightTimeStop.Value = Session.Instance.LogBookCurrentDate.Date;
                    }
                    else
                    {
                        logBook.DpFlightTimeStart.Value = DateTime.Now;
                        logBook.DpFlightTimeStop.Value = DateTime.Now;
                    }
                    if (!IsInit) MessageBox.Show("Sistem je spreman za unos novih letova!", "System Operation is successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
                else
                {
                    logBook.TxtLastACHours.Text = string.Empty;
                    logBook.TxtLastACCycles.Text = string.Empty;
                    logBook.DpLastUpdate.CustomFormat = " ";
                    logBook.CbAirport.SelectedIndex = -1;
                    logBook.CbAirportFrom.SelectedIndex = -1;
                }
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da pronađe podatke o avionu!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                logBook.Dispose();
                logBook = null;
            }
        }

        private List<Aircraft> UcitajListuAviona()
        {
            return Communication.Instance.SendRequest<List<Aircraft>>(Operation.GetAircrafts, new Aircraft { TableNameIndex = 1, SelectFieldsIndex = 0, ConditionIndex = 0 });
        }

        private Aircraft UcitajAvion(string RegistrationNumber)
        {
            return Communication.Instance.SendRequest<Aircraft>(Operation.GetAircraft, new Aircraft { RegistrationNumber = RegistrationNumber, TableNameIndex = 1, SelectFieldsIndex = 0, ConditionIndex = 1 });
        }

        private List<Airport> UcitajListuAerodroma()
        {
            return Communication.Instance.SendRequest<List<Airport>>(Operation.GetAirports, new Airport { TableNameIndex = 0, SelectFieldsIndex = 0, ConditionIndex = 0 });
        }

        private LogBook ZapamtiLet()
        {
            TimeSpan ts = DateTime.Parse(logBook.DpFlightTimeStop.Text) - DateTime.Parse(logBook.DpFlightTimeStart.Text);
            decimal difference = (int)(ts.TotalMinutes / 60) + (decimal)(ts.TotalMinutes % 60) / 100;

            LogBook lb = new LogBook
            {
                FlightDate = DateTime.Parse(DateTime.Parse(logBook.DpFlightTimeStart.Text).ToString("dd/MM/yyyy")),
                FlightNumber = logBook.TxtFlightNumber.Text,
                Airport_FROM = ((Airport)logBook.CbAirportFrom.SelectedItem),
                Airport_TO = ((Airport)logBook.CbAirportTo.SelectedItem),
                Aircraft = ((Aircraft)logBook.CbAircraft.SelectedItem),
                FlightTimeStart = DateTime.Parse(logBook.DpFlightTimeStart.Text),
                FlightTimeStop = DateTime.Parse(logBook.DpFlightTimeStop.Text),
                PreviousACHours = decimal.Parse(logBook.TxtLastACHours.Text),
                PreviousACCycles = decimal.Parse(logBook.TxtLastACCycles.Text),
                NextACHours = (decimal)hours_add(decimal.Parse(logBook.TxtLastACHours.Text), difference),
                NextACCycles = (decimal)(double.Parse(logBook.TxtLastACCycles.Text) + 1),
                ConditionIndex = 0
            };
            return Communication.Instance.SendRequest<LogBook>(Operation.AddLogBook, lb);
        }
    }
}
