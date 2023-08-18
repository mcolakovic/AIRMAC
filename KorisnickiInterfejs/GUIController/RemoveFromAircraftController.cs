using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Common;
using Domain;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.Forms;
using KorisnickiInterfejs.Function;
using KorisnickiInterfejs.GUISession;
using KorisnickiInterfejs.ServerCommunication;

namespace KorisnickiInterfejs.GUIController
{
    public class RemoveFromAircraftController
    {
        FrmRemoveFromAircraft frmRemoveFromAircraft;
        Decimal id_RotableParts;

        internal void InitData(FrmRemoveFromAircraft frmRemoveFromAircraft)
        {
            try
            {
                this.frmRemoveFromAircraft = frmRemoveFromAircraft;
                InitializeComponent();
                frmRemoveFromAircraft.DpLastUpdate.CustomFormat = " ";
                frmRemoveFromAircraft.DpInstalationDate.CustomFormat = " ";
                frmRemoveFromAircraft.CbAircraft.SelectedIndex = -1;
            }

            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da pronađe podatke o avionu i aerodromima!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                frmRemoveFromAircraft.Dispose();
                frmRemoveFromAircraft = null;
            }
        }

        private void InitializeComponent()
        {
                List<Airport> listAirport = UcitajListuAerodroma();
                frmRemoveFromAircraft.CbAirport.DataSource = listAirport.ToList();
                frmRemoveFromAircraft.CbAircraft.DataSource = UcitajListuAviona();
        }

        internal void GetCard()
        {
            try
            {
                frmRemoveFromAircraft.TxtPartNumber.Text = Session.Instance.CurrentServiceablePartNumber;
                frmRemoveFromAircraft.TxtSerialNumber.Text = Session.Instance.CurrentServiceableSerialNumber;

                RotablePartsLog rotablePartsLog = new RotablePartsLog
                {
                    RotableParts = new RotableParts
                    {
                        PartNumber = frmRemoveFromAircraft.TxtPartNumber.Text,
                        SerialNumber = frmRemoveFromAircraft.TxtSerialNumber.Text
                    },

                    RotablePartsSubClass = new RotablePartsAircraft
                    {
                        RotablePartsLog = new RotablePartsLog(),
                        RotableParts = new RotableParts(),
                        TableNameIndex = 0,
                        SelectFieldsIndex = 0,
                        ConditionIndex = 0
                    }
                };

                RotablePartsLog rpl = NadjiDioAvion(rotablePartsLog);
                if (rpl != null)
                {
                    frmRemoveFromAircraft.RtbDescription.Text = rpl.RotableParts.Description;
                    id_RotableParts = rpl.RotableParts.ID_RotableParts;
                    frmRemoveFromAircraft.CbAircraft.SelectedItem = ((RotablePartsAircraft)rpl.RotablePartsSubClass).Aircraft;
                        frmRemoveFromAircraft.TxtHoursOperationalLimit.Text = ((RotablePartsAircraft)rpl.RotablePartsSubClass).HoursOperationalLimit.ToString();
                        frmRemoveFromAircraft.TxtCyclesOperationalLimit.Text = ((RotablePartsAircraft)rpl.RotablePartsSubClass).CyclesOperationalLimit.ToString();
                        frmRemoveFromAircraft.TxtDaysOperationalLimit.Text = ((RotablePartsAircraft)rpl.RotablePartsSubClass).DaysOperationalLimit.ToString();
                        frmRemoveFromAircraft.TxtStorageLimit.Text = ((RotablePartsAircraft)rpl.RotablePartsSubClass).StorageLimit.ToString();
                        frmRemoveFromAircraft.TxtTimeSinceNew.Text = ((RotablePartsAircraft)rpl.RotablePartsSubClass).TimeSinceNew.ToString();
                        frmRemoveFromAircraft.TxtCyclesSinceNew.Text = ((RotablePartsAircraft)rpl.RotablePartsSubClass).CyclesSinceNew.ToString();
                        frmRemoveFromAircraft.TxtDaysSinceNew.Text = ((RotablePartsAircraft)rpl.RotablePartsSubClass).DaysSinceNew.ToString();
                        frmRemoveFromAircraft.TxtTimeSinceOverhaul.Text = ((RotablePartsAircraft)rpl.RotablePartsSubClass).TimeSinceOverhaul.ToString();
                        frmRemoveFromAircraft.TxtCyclesSinceOverhaul.Text = ((RotablePartsAircraft)rpl.RotablePartsSubClass).CyclesSinceOverhaul.ToString();
                        frmRemoveFromAircraft.TxtDaysSinceOverhaul.Text = ((RotablePartsAircraft)rpl.RotablePartsSubClass).DaysSinceOverhaul.ToString();
                        frmRemoveFromAircraft.TxtACHoursOnInstall.Text = ((RotablePartsAircraft)rpl.RotablePartsSubClass).AircraftHours.ToString();
                        frmRemoveFromAircraft.TxtACCyclesOnInstall.Text = ((RotablePartsAircraft)rpl.RotablePartsSubClass).AircraftCycles.ToString();
                        frmRemoveFromAircraft.DpInstalationDate.CustomFormat = "dd/MM/yyyy";
                        frmRemoveFromAircraft.DpInstalationDate.Text = ((RotablePartsAircraft)rpl.RotablePartsSubClass).InstalationDate.ToString();
                        MessageBox.Show("Sistem je spreman za prebacanje dijela sa aviona u magacin!", "System Operation is successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                        frmRemoveFromAircraft.BtnRemoveFromAircraft.Enabled = true;
                        frmRemoveFromAircraft.BtnSearchForItem.Enabled = false;
                        frmRemoveFromAircraft.BtnCancel.Enabled = true;
                }
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da pronađe podatke o instaliranom dijelu!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                frmRemoveFromAircraft.Dispose();
                frmRemoveFromAircraft = null;
            }
        }

        internal void SendItemToStock()
        {
            try
            {
                RotablePartsLog rotablePartsLog = new RotablePartsLog
                {
                    RotableParts = new RotableParts
                    {
                        ID_RotableParts = id_RotableParts,
                    },
                    SubClass = (int)SubClass.Stock,
                    TableNameIndex = 1,
                    RotablePartsSubClass = new RotablePartsStock
                    {
                        RotablePartsLog = new RotablePartsLog(),
                        RotableParts = new RotableParts { ID_RotableParts = id_RotableParts  },
                        Aircraft = new Aircraft 
                        { 
                             RegistrationNumber = ((Aircraft)frmRemoveFromAircraft.CbAircraft.SelectedItem).RegistrationNumber,                     
                        },
                        AircraftHours = decimal.Parse(frmRemoveFromAircraft.TxtLastACHours.Text),
                        AircraftCycles = decimal.Parse(frmRemoveFromAircraft.TxtLastACCycles.Text),
                        DateOfEntry = DateTime.Parse(frmRemoveFromAircraft.DpLastUpdate.Text),


                        HoursOperationalLimit = String.IsNullOrEmpty(frmRemoveFromAircraft.TxtHoursOperationalLimit.Text) ? (decimal?)null : decimal.Parse(frmRemoveFromAircraft.TxtHoursOperationalLimit.Text),
                        CyclesOperationalLimit = String.IsNullOrEmpty(frmRemoveFromAircraft.TxtCyclesOperationalLimit.Text) ? (decimal?)null : decimal.Parse(frmRemoveFromAircraft.TxtCyclesOperationalLimit.Text),
                        DaysOperationalLimit = String.IsNullOrEmpty(frmRemoveFromAircraft.TxtDaysOperationalLimit.Text) ? (decimal?)null : decimal.Parse(frmRemoveFromAircraft.TxtDaysOperationalLimit.Text),
                        StorageLimit = String.IsNullOrEmpty(frmRemoveFromAircraft.TxtStorageLimit.Text) ? (decimal?)null : decimal.Parse(frmRemoveFromAircraft.TxtStorageLimit.Text),
                        TimeSinceNew = String.IsNullOrEmpty(frmRemoveFromAircraft.TxtTimeSinceNew.Text) ? (decimal?)null : decimal.Parse(frmRemoveFromAircraft.TxtTimeSinceNew.Text),
                        CyclesSinceNew = String.IsNullOrEmpty(frmRemoveFromAircraft.TxtCyclesSinceNew.Text) ? (decimal?)null : decimal.Parse(frmRemoveFromAircraft.TxtCyclesSinceNew.Text),
                        DaysSinceNew = String.IsNullOrEmpty(frmRemoveFromAircraft.TxtDaysSinceNew.Text) ? (decimal?)null : decimal.Parse(frmRemoveFromAircraft.TxtDaysSinceNew.Text),
                        TimeSinceOverhaul = String.IsNullOrEmpty(frmRemoveFromAircraft.TxtTimeSinceOverhaul.Text) ? (decimal?)null : decimal.Parse(frmRemoveFromAircraft.TxtTimeSinceOverhaul.Text),
                        CyclesSinceOverhaul = String.IsNullOrEmpty(frmRemoveFromAircraft.TxtCyclesSinceOverhaul.Text) ? (decimal?)null : decimal.Parse(frmRemoveFromAircraft.TxtCyclesSinceOverhaul.Text),
                        DaysSinceOverhaul = String.IsNullOrEmpty(frmRemoveFromAircraft.TxtDaysSinceOverhaul.Text) ? (decimal?)null : decimal.Parse(frmRemoveFromAircraft.TxtDaysSinceOverhaul.Text),
                        ExpireAtDate = String.IsNullOrEmpty(frmRemoveFromAircraft.TxtStorageLimit.Text) ? (DateTime?)null : DateTime.Parse(frmRemoveFromAircraft.DpLastUpdate.Text).AddDays(double.Parse(frmRemoveFromAircraft.TxtStorageLimit.Text)),
                        IsInitial = false,
                        TableNameIndex = 1,                
                    }

                };
                rotablePartsLog = PrebaciDioSaAvionaUMagacin(rotablePartsLog);
                MessageBox.Show("Sistem je izvršio prebacanje dijela sa aviona u magacin!", "System Operation is successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                ClearComponent();
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da izvrši prebacivanje dijela sa aviona u magacin!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                frmRemoveFromAircraft.Dispose();
                frmRemoveFromAircraft = null;
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
                if ((Aircraft)frmRemoveFromAircraft.CbAircraft.SelectedItem != null)
                {
                    Aircraft aircraft = (Aircraft)frmRemoveFromAircraft.CbAircraft.SelectedItem;
                    frmRemoveFromAircraft.TxtLastACHours.Text = aircraft.LastACHours.ToString();
                    frmRemoveFromAircraft.TxtLastACCycles.Text = aircraft.LastACCycles.ToString();
                    frmRemoveFromAircraft.DpLastUpdate.CustomFormat = "dd/MM/yyyy HH:mm";
                    frmRemoveFromAircraft.DpLastUpdate.Value = aircraft.LastUpdate;
                    frmRemoveFromAircraft.CbAirport.SelectedItem = aircraft.Airport;
                }
                else
                {
                    frmRemoveFromAircraft.TxtLastACHours.Text = string.Empty;
                    frmRemoveFromAircraft.TxtLastACCycles.Text = string.Empty;
                    frmRemoveFromAircraft.DpLastUpdate.CustomFormat = " ";
                    frmRemoveFromAircraft.CbAirport.SelectedIndex = -1;
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
                frmRemoveFromAircraft.Dispose();
                frmRemoveFromAircraft = null;
            }
        }

        internal void ClearComponent()
        {
            frmRemoveFromAircraft.TxtPartNumber.Text = string.Empty;
            frmRemoveFromAircraft.TxtSerialNumber.Text = string.Empty;
            frmRemoveFromAircraft.RtbDescription.Text = string.Empty;
            frmRemoveFromAircraft.TxtHoursOperationalLimit.Text = string.Empty;
            frmRemoveFromAircraft.TxtCyclesOperationalLimit.Text = string.Empty;
            frmRemoveFromAircraft.TxtDaysOperationalLimit.Text = string.Empty;
            frmRemoveFromAircraft.TxtStorageLimit.Text = string.Empty;
            frmRemoveFromAircraft.TxtTimeSinceNew.Text = string.Empty;
            frmRemoveFromAircraft.TxtCyclesSinceNew.Text = string.Empty;
            frmRemoveFromAircraft.TxtDaysSinceNew.Text = string.Empty;
            frmRemoveFromAircraft.TxtTimeSinceOverhaul.Text = string.Empty;
            frmRemoveFromAircraft.TxtCyclesSinceOverhaul.Text = string.Empty;
            frmRemoveFromAircraft.TxtDaysSinceOverhaul.Text = string.Empty;
            frmRemoveFromAircraft.BtnRemoveFromAircraft.Enabled = false;
            frmRemoveFromAircraft.BtnSearchForItem.Enabled = true;
            frmRemoveFromAircraft.BtnCancel.Enabled = false;
            frmRemoveFromAircraft.CbAircraft.SelectedIndex = -1;
            frmRemoveFromAircraft.DpLastUpdate.CustomFormat = " ";
            frmRemoveFromAircraft.DpInstalationDate.CustomFormat = " ";
            frmRemoveFromAircraft.TxtACHoursOnInstall.Text = string.Empty;
            frmRemoveFromAircraft.TxtACCyclesOnInstall.Text = string.Empty;
        }

        private void AircraftRefresh(FrmRemoveFromAircraft frmRemoveFromAircraft)
        {
            List<Airport> listAirport = Communication.Instance.SendRequest<List<Airport>>(Operation.GetAirports, new Airport { TableNameIndex = 0, SelectFieldsIndex = 0, ConditionIndex = 0 });
            frmRemoveFromAircraft.CbAirport.DataSource = listAirport.ToList();
            frmRemoveFromAircraft.CbAircraft.DataSource = Communication.Instance.SendRequest<List<Aircraft>>(Operation.GetAircrafts, new Aircraft { TableNameIndex = 1, SelectFieldsIndex = 0, ConditionIndex = 0 });
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

        private RotablePartsLog NadjiDioAvion(RotablePartsLog rotablePartsLog)
        {
            return Communication.Instance.SendRequest<RotablePartsLog>(Operation.SearchRotablePartsAircraft, rotablePartsLog);
        }

        private RotablePartsLog PrebaciDioSaAvionaUMagacin(RotablePartsLog rotablePartsLog)
        {
            return Communication.Instance.SendRequest<RotablePartsLog>(Operation.SendFromAircraftToStock, rotablePartsLog);
        }
    }
}
