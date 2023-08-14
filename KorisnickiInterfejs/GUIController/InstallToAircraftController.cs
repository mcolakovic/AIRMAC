using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Net.Sockets;
using System.Windows.Forms;
using Common;
using Domain;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.Forms;
using KorisnickiInterfejs.Function;
using KorisnickiInterfejs.ServerCommunication;

namespace KorisnickiInterfejs.GUIController
{
    public class InstallToAircraftController
    {
        FrmInstallToAircraft frmInstallToAircraft;
        Decimal id_RotablePartsLog;
        Decimal id_RotableParts;
        bool IsInit = true;

        internal void InitData(FrmInstallToAircraft frmInstallToAircraft)
        {
            try
            {
                this.frmInstallToAircraft = frmInstallToAircraft;
                InitializeComponent();
                frmInstallToAircraft.CbAircraft.SelectedIndex = -1;
                frmInstallToAircraft.DpLastUpdate.CustomFormat = " ";
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
                frmInstallToAircraft.Dispose();
                frmInstallToAircraft = null;
            }           
        }

        internal void AircraftChanged()
        {
            AircraftRefresh();
        }

        private void AircraftRefresh()
        {
            try
            {
                if ((Aircraft)frmInstallToAircraft.CbAircraft.SelectedItem != null)
                {
                    Aircraft aircraft = UcitajAvion(((Aircraft)frmInstallToAircraft.CbAircraft.SelectedItem).RegistrationNumber);
                    frmInstallToAircraft.TxtLastACHours.Text = aircraft.LastACHours.ToString();
                    frmInstallToAircraft.TxtLastACCycles.Text = aircraft.LastACCycles.ToString();
                    frmInstallToAircraft.DpLastUpdate.CustomFormat = "dd/MM/yyyy HH:mm";
                    frmInstallToAircraft.DpLastUpdate.Value = aircraft.LastUpdate;
                    frmInstallToAircraft.CbAirport.SelectedItem = aircraft.Airport;
                    if (!IsInit) MessageBox.Show("Sistem je spreman za instaliranje avio dijela na avion", "System Operation is successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
                else
                {
                    frmInstallToAircraft.TxtLastACHours.Text = string.Empty;
                    frmInstallToAircraft.TxtLastACCycles.Text = string.Empty;
                    frmInstallToAircraft.DpLastUpdate.CustomFormat = " ";
                    frmInstallToAircraft.CbAirport.SelectedIndex = -1;
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
                frmInstallToAircraft.Dispose();
                frmInstallToAircraft = null;
            }
        }

        internal void InstallRotablePartOnAircraft()
        {
            try
            {
                if (!Validation())
                {
                    MessageBox.Show("Unos podataka nije validan!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    return;
                }

                RotablePartsLog rotablePartsLog = new RotablePartsLog
                {
                    RotableParts = new RotableParts
                    { 
                        ID_RotableParts = id_RotableParts,
                    },
                    SubClass = (int)SubClass.Aircraft,
                    TableNameIndex = 1,
                    RotablePartsSubClass = new RotablePartsAircraft
                    {
                        RotablePartsLog = new RotablePartsLog(),
                        RotableParts = new RotableParts
                        {
                            ID_RotableParts = id_RotableParts
                        },
                        Aircraft = (Aircraft)frmInstallToAircraft.CbAircraft.SelectedItem,

                        HoursOperationalLimit = String.IsNullOrEmpty(frmInstallToAircraft.TxtHoursOperationalLimit.Text) ? (decimal?)null : decimal.Parse(frmInstallToAircraft.TxtHoursOperationalLimit.Text),
                        CyclesOperationalLimit = String.IsNullOrEmpty(frmInstallToAircraft.TxtCyclesOperationalLimit.Text) ? (decimal?)null : decimal.Parse(frmInstallToAircraft.TxtCyclesOperationalLimit.Text),
                        DaysOperationalLimit = String.IsNullOrEmpty(frmInstallToAircraft.TxtDaysOperationalLimit.Text) ? (decimal?)null : decimal.Parse(frmInstallToAircraft.TxtDaysOperationalLimit.Text),
                        StorageLimit = String.IsNullOrEmpty(frmInstallToAircraft.TxtStorageLimit.Text) ? (decimal?)null : decimal.Parse(frmInstallToAircraft.TxtStorageLimit.Text),
                        TimeSinceNew = String.IsNullOrEmpty(frmInstallToAircraft.TxtTimeSinceNew.Text) ? (decimal?)null : decimal.Parse(frmInstallToAircraft.TxtTimeSinceNew.Text),
                        CyclesSinceNew = String.IsNullOrEmpty(frmInstallToAircraft.TxtCyclesSinceNew.Text) ? (decimal?)null : decimal.Parse(frmInstallToAircraft.TxtCyclesSinceNew.Text),
                        DaysSinceNew = String.IsNullOrEmpty(frmInstallToAircraft.TxtDaysSinceNew.Text) ? (decimal?)null : decimal.Parse(frmInstallToAircraft.TxtDaysSinceNew.Text),
                        TimeSinceOverhaul = String.IsNullOrEmpty(frmInstallToAircraft.TxtTimeSinceOverhaul.Text) ? (decimal?)null : decimal.Parse(frmInstallToAircraft.TxtTimeSinceOverhaul.Text),
                        CyclesSinceOverhaul = String.IsNullOrEmpty(frmInstallToAircraft.TxtCyclesSinceOverhaul.Text) ? (decimal?)null : decimal.Parse(frmInstallToAircraft.TxtCyclesSinceOverhaul.Text),
                        DaysSinceOverhaul = String.IsNullOrEmpty(frmInstallToAircraft.TxtDaysSinceOverhaul.Text) ? (decimal?)null : decimal.Parse(frmInstallToAircraft.TxtDaysSinceOverhaul.Text),
                        ExpireOnHours = String.IsNullOrEmpty(frmInstallToAircraft.TxtHoursOperationalLimit.Text) ? (decimal?)null : Functions.hours_add(((Aircraft)frmInstallToAircraft.CbAircraft.SelectedItem).LastACHours, Functions.hours_sub(decimal.Parse(frmInstallToAircraft.TxtHoursOperationalLimit.Text), decimal.Parse(frmInstallToAircraft.TxtTimeSinceOverhaul.Text))),
                        ExpireOnCycles = String.IsNullOrEmpty(frmInstallToAircraft.TxtCyclesOperationalLimit.Text) ? (decimal?)null : ((Aircraft)frmInstallToAircraft.CbAircraft.SelectedItem).LastACCycles + decimal.Parse(frmInstallToAircraft.TxtCyclesOperationalLimit.Text) - decimal.Parse(frmInstallToAircraft.TxtCyclesSinceOverhaul.Text),
                        ExpireAtDate = String.IsNullOrEmpty(frmInstallToAircraft.TxtDaysOperationalLimit.Text) ? (DateTime?)null : ((Aircraft)frmInstallToAircraft.CbAircraft.SelectedItem).LastUpdate.AddDays(int.Parse(frmInstallToAircraft.TxtDaysOperationalLimit.Text) - int.Parse(frmInstallToAircraft.TxtDaysSinceOverhaul.Text)),

                        //HoursOperationalLimit = frmInstallToAircraft.TxtHoursOperationalLimit.Text == "" ? decimal.Parse(frmInstallToAircraft.TxtHoursOperationalLimit.Text) : (decimal?)null,
                        //CyclesOperationalLimit = decimal.Parse(frmInstallToAircraft.TxtCyclesOperationalLimit.Text),
                        //DaysOperationalLimit = decimal.Parse(frmInstallToAircraft.TxtDaysOperationalLimit.Text),
                        //StorageLimit = decimal.Parse(frmInstallToAircraft.TxtStorageLimit.Text),
                        //TimeSinceNew = decimal.Parse(frmInstallToAircraft.TxtTimeSinceNew.Text),
                        //CyclesSinceNew = decimal.Parse(frmInstallToAircraft.TxtCyclesSinceNew.Text),
                        //DaysSinceNew = decimal.Parse(frmInstallToAircraft.TxtDaysSinceNew.Text),
                        //TimeSinceOverhaul = decimal.Parse(frmInstallToAircraft.TxtTimeSinceOverhaul.Text),
                        //CyclesSinceOverhaul = decimal.Parse(frmInstallToAircraft.TxtCyclesSinceOverhaul.Text),
                        //DaysSinceOverhaul = decimal.Parse(frmInstallToAircraft.TxtDaysSinceOverhaul.Text),
                        //ExpireOnHours = Functions.hours_add(((Aircraft)frmInstallToAircraft.CbAircraft.SelectedItem).LastACHours, Functions.hours_sub(decimal.Parse(frmInstallToAircraft.TxtHoursOperationalLimit.Text), decimal.Parse(frmInstallToAircraft.TxtTimeSinceOverhaul.Text))),
                        //ExpireOnCycles = ((Aircraft)frmInstallToAircraft.CbAircraft.SelectedItem).LastACCycles + decimal.Parse(frmInstallToAircraft.TxtCyclesOperationalLimit.Text) - decimal.Parse(frmInstallToAircraft.TxtCyclesSinceOverhaul.Text),
                        //ExpireAtDate = ((Aircraft)frmInstallToAircraft.CbAircraft.SelectedItem).LastUpdate.AddDays(int.Parse(frmInstallToAircraft.TxtDaysOperationalLimit.Text) - int.Parse(frmInstallToAircraft.TxtDaysSinceOverhaul.Text)),
                        
                        TableNameIndex = 1
                    }
                };
                rotablePartsLog = DodajDioNaAvion(rotablePartsLog);
                MessageBox.Show("Sistem je instalirao avio dio na avionu!", "System Operation is successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                ClearComponent();
            }

            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem nije u mogućnosti da završi instalaciju avionskog dijela na avionu!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                frmInstallToAircraft.Dispose();
                frmInstallToAircraft = null;
            }
        }

        internal void ClearComponent()
        {
            frmInstallToAircraft.TxtPartNumber.Text = string.Empty;
            frmInstallToAircraft.TxtSerialNumber.Text = string.Empty;
            frmInstallToAircraft.RtbDescription.Text = string.Empty;
            frmInstallToAircraft.TxtHoursOperationalLimit.Text = string.Empty;
            frmInstallToAircraft.TxtCyclesOperationalLimit.Text = string.Empty;
            frmInstallToAircraft.TxtDaysOperationalLimit.Text = string.Empty;
            frmInstallToAircraft.TxtStorageLimit.Text = string.Empty;
            frmInstallToAircraft.TxtTimeSinceNew.Text = string.Empty;
            frmInstallToAircraft.TxtCyclesSinceNew.Text = string.Empty;
            frmInstallToAircraft.TxtDaysSinceNew.Text = string.Empty;
            frmInstallToAircraft.TxtTimeSinceOverhaul.Text = string.Empty;
            frmInstallToAircraft.TxtCyclesSinceOverhaul.Text = string.Empty;
            frmInstallToAircraft.TxtDaysSinceOverhaul.Text = string.Empty;
            frmInstallToAircraft.BtnInstallRotablePartsOnAircraft.Enabled = false;
            frmInstallToAircraft.BtnSearchForItem.Enabled = true;
            frmInstallToAircraft.BtnCancel.Enabled = false;
            frmInstallToAircraft.CbAircraft.SelectedIndex = -1;
            frmInstallToAircraft.DpLastUpdate.CustomFormat = " ";
        }

        internal void GetCard()
        {
            if (!SearchValidation())
            {
                MessageBox.Show("Unos podataka nije validan!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }
            try
            {
                RotablePartsLog rotablePartsLog = new RotablePartsLog
                {
                    RotableParts = new RotableParts
                    {
                        PartNumber = frmInstallToAircraft.TxtPartNumber.Text,
                        SerialNumber = frmInstallToAircraft.TxtSerialNumber.Text
                    },

                RotablePartsSubClass = new RotablePartsStock
                    {
                        RotablePartsLog = new RotablePartsLog(),
                        RotableParts = new RotableParts(),
                        TableNameIndex = 0,
                        SelectFieldsIndex = 0,
                        ConditionIndex = 0
                    }
                };

                RotablePartsLog rpl = NadjiDioMagacin(rotablePartsLog);
                if (rpl != null)
                {
                    frmInstallToAircraft.RtbDescription.Text = rpl.RotableParts.Description;
                    id_RotableParts = rpl.RotableParts.ID_RotableParts;
                    frmInstallToAircraft.TxtHoursOperationalLimit.Text = ((RotablePartsStock)rpl.RotablePartsSubClass).HoursOperationalLimit.ToString();
                    frmInstallToAircraft.TxtCyclesOperationalLimit.Text = ((RotablePartsStock)rpl.RotablePartsSubClass).CyclesOperationalLimit.ToString();
                    frmInstallToAircraft.TxtDaysOperationalLimit.Text = ((RotablePartsStock)rpl.RotablePartsSubClass).DaysOperationalLimit.ToString();
                    frmInstallToAircraft.TxtStorageLimit.Text = ((RotablePartsStock)rpl.RotablePartsSubClass).StorageLimit.ToString();
                    frmInstallToAircraft.TxtTimeSinceNew.Text = ((RotablePartsStock)rpl.RotablePartsSubClass).TimeSinceNew.ToString();
                    frmInstallToAircraft.TxtCyclesSinceNew.Text = ((RotablePartsStock)rpl.RotablePartsSubClass).CyclesSinceNew.ToString();
                    frmInstallToAircraft.TxtDaysSinceNew.Text = ((RotablePartsStock)rpl.RotablePartsSubClass).DaysSinceNew.ToString();
                    frmInstallToAircraft.TxtTimeSinceOverhaul.Text = ((RotablePartsStock)rpl.RotablePartsSubClass).TimeSinceOverhaul.ToString();
                    frmInstallToAircraft.TxtCyclesSinceOverhaul.Text = ((RotablePartsStock)rpl.RotablePartsSubClass).CyclesSinceOverhaul.ToString();
                    frmInstallToAircraft.TxtDaysSinceOverhaul.Text = ((RotablePartsStock)rpl.RotablePartsSubClass).DaysSinceOverhaul.ToString();
                    MessageBox.Show("Sistem je našao avionski dio u magacinu avionskih dijelova!", "System Operation is successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    frmInstallToAircraft.BtnInstallRotablePartsOnAircraft.Enabled = true;
                    frmInstallToAircraft.BtnSearchForItem.Enabled = false;
                    frmInstallToAircraft.BtnCancel.Enabled = true;
                }
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da pronađe avionski dio u magacinu avionskih dijelova", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                frmInstallToAircraft.Dispose();
                frmInstallToAircraft = null;
            }
        }

        private bool Validation()
        {
            if (frmInstallToAircraft.CbAircraft.SelectedItem == null) return false;
            return true;
        }

        private void InitializeComponent()
        {
                List<Airport> listAirport = UcitajListuAerodroma();
                frmInstallToAircraft.CbAirport.DataSource = listAirport.ToList();
                frmInstallToAircraft.CbAircraft.DataSource = UcitajListuAviona();
       }

        private bool SearchValidation()
        {
            if (frmInstallToAircraft.TxtPartNumber.Text == string.Empty) return false;
            if (frmInstallToAircraft.TxtSerialNumber.Text == string.Empty) return false;

            return true;
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

        private RotablePartsLog NadjiDioMagacin(RotablePartsLog rotablePartsLog)
        {
            return Communication.Instance.SendRequest<RotablePartsLog>(Operation.SearchRotablePartsStock, rotablePartsLog);
        }

        private RotablePartsLog DodajDioNaAvion(RotablePartsLog rotablePartsLog)
        {
            return Communication.Instance.SendRequest<RotablePartsLog>(Operation.InstallToAircraft, rotablePartsLog);
        }
    }
}
