using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Domain;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.Forms;
using KorisnickiInterfejs.ServerCommunication;

namespace KorisnickiInterfejs.GUIController
{
    public class ChangeRotablePartsController
    {
        FrmChangeRotableParts frmChangeRotableParts;
        Decimal id_RotablePartsLog;
        Decimal id_RotableParts;

        internal void InitData(FrmChangeRotableParts frmChangeRotableParts)
        {
            try
            {
                this.frmChangeRotableParts = frmChangeRotableParts;
                frmChangeRotableParts.DpDateOfEntry.CustomFormat = " ";
            }
            catch (ServerCommunicationException)
            {
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                frmChangeRotableParts.Dispose();
                frmChangeRotableParts = null;
            }
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
                        PartNumber = frmChangeRotableParts.TxtPartNumber.Text,
                        SerialNumber = frmChangeRotableParts.TxtSerialNumber.Text
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
                        frmChangeRotableParts.RtbDescription.Text = rpl.RotableParts.Description;
                        id_RotableParts = rpl.RotableParts.ID_RotableParts;
                        frmChangeRotableParts.DpDateOfEntry.CustomFormat = "dd/MM/yyyy";
                        id_RotablePartsLog = ((RotablePartsStock)rpl.RotablePartsSubClass).RotablePartsLog.ID_RotablePartsLog;
                        frmChangeRotableParts.DpDateOfEntry.Value = ((RotablePartsStock)rpl.RotablePartsSubClass).DateOfEntry;
                        frmChangeRotableParts.TxtHoursOperationalLimit.Text = ((RotablePartsStock)rpl.RotablePartsSubClass).HoursOperationalLimit.ToString();
                        frmChangeRotableParts.TxtCyclesOperationalLimit.Text = ((RotablePartsStock)rpl.RotablePartsSubClass).CyclesOperationalLimit.ToString();
                        frmChangeRotableParts.TxtDaysOperationalLimit.Text = ((RotablePartsStock)rpl.RotablePartsSubClass).DaysOperationalLimit.ToString();
                        frmChangeRotableParts.TxtStorageLimit.Text = ((RotablePartsStock)rpl.RotablePartsSubClass).StorageLimit.ToString();
                        frmChangeRotableParts.TxtTimeSinceNew.Text = ((RotablePartsStock)rpl.RotablePartsSubClass).TimeSinceNew.ToString();
                        frmChangeRotableParts.TxtCyclesSinceNew.Text = ((RotablePartsStock)rpl.RotablePartsSubClass).CyclesSinceNew.ToString();
                        frmChangeRotableParts.TxtDaysSinceNew.Text = ((RotablePartsStock)rpl.RotablePartsSubClass).DaysSinceNew.ToString();
                        frmChangeRotableParts.TxtTimeSinceOverhaul.Text = ((RotablePartsStock)rpl.RotablePartsSubClass).TimeSinceOverhaul.ToString();
                        frmChangeRotableParts.TxtCyclesSinceOverhaul.Text = ((RotablePartsStock)rpl.RotablePartsSubClass).CyclesSinceOverhaul.ToString();
                        frmChangeRotableParts.TxtDaysSinceOverhaul.Text = ((RotablePartsStock)rpl.RotablePartsSubClass).DaysSinceOverhaul.ToString();
                        
                        if (!((RotablePartsStock)rpl.RotablePartsSubClass).IsInitial)
                        {
                            frmChangeRotableParts.DpDateOfEntry.Enabled = false;
                            frmChangeRotableParts.TxtHoursOperationalLimit.ReadOnly = true;
                            frmChangeRotableParts.TxtCyclesOperationalLimit.ReadOnly = true;
                            frmChangeRotableParts.TxtDaysOperationalLimit.ReadOnly = true;
                            frmChangeRotableParts.TxtStorageLimit.ReadOnly = true;
                            frmChangeRotableParts.TxtTimeSinceNew.ReadOnly = true;
                            frmChangeRotableParts.TxtCyclesSinceNew.ReadOnly = true;
                            frmChangeRotableParts.TxtDaysSinceNew.ReadOnly = true;
                            frmChangeRotableParts.TxtTimeSinceOverhaul.ReadOnly = true;
                            frmChangeRotableParts.TxtCyclesSinceOverhaul.ReadOnly = true;
                            frmChangeRotableParts.TxtDaysSinceOverhaul.ReadOnly = true;
                        }
                        else
                        {
                            frmChangeRotableParts.DpDateOfEntry.Enabled = true;
                            frmChangeRotableParts.TxtHoursOperationalLimit.ReadOnly = false;
                            frmChangeRotableParts.TxtCyclesOperationalLimit.ReadOnly = false;
                            frmChangeRotableParts.TxtDaysOperationalLimit.ReadOnly = false;
                            frmChangeRotableParts.TxtStorageLimit.ReadOnly = false;
                            frmChangeRotableParts.TxtTimeSinceNew.ReadOnly = false;
                            frmChangeRotableParts.TxtCyclesSinceNew.ReadOnly = false;
                            frmChangeRotableParts.TxtDaysSinceNew.ReadOnly = false;
                            frmChangeRotableParts.TxtTimeSinceOverhaul.ReadOnly = false;
                            frmChangeRotableParts.TxtCyclesSinceOverhaul.ReadOnly = false;
                            frmChangeRotableParts.TxtDaysSinceOverhaul.ReadOnly = false;                
                        }
                        MessageBox.Show("Sistem je spreman za ažuriranje kartona avio dijela!", "System Operation is successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                        frmChangeRotableParts.BtnCancel.Enabled = true;
                        frmChangeRotableParts.BtnAddRotablePartsItem.Enabled = true;
                        frmChangeRotableParts.BtnSearchForItem.Enabled = false;
                    }
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da pronađe karton dijela u evidenciji avio dijelov!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                frmChangeRotableParts.Dispose();
                frmChangeRotableParts = null;
            }
        }

        internal void UpdateCard()
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
                        Description = frmChangeRotableParts.RtbDescription.Text,
                        TableNameIndex = 0,
                        ConditionIndex = 1

                    },
                    SubClass = (int)SubClass.Stock,
                    TableNameIndex = 1,
                    RotablePartsSubClass = new RotablePartsStock
                    {
                        RotablePartsLog = new RotablePartsLog
                        {
                            ID_RotablePartsLog = id_RotablePartsLog
                        },
                        RotableParts = new RotableParts
                        {
                            ID_RotableParts = id_RotableParts
                        },
                        DateOfEntry = DateTime.Parse(frmChangeRotableParts.DpDateOfEntry.Text),


                        HoursOperationalLimit = String.IsNullOrEmpty(frmChangeRotableParts.TxtHoursOperationalLimit.Text) ? (decimal?)null : decimal.Parse(frmChangeRotableParts.TxtHoursOperationalLimit.Text),
                        CyclesOperationalLimit = String.IsNullOrEmpty(frmChangeRotableParts.TxtCyclesOperationalLimit.Text) ? (decimal?)null : decimal.Parse(frmChangeRotableParts.TxtCyclesOperationalLimit.Text),
                        DaysOperationalLimit = String.IsNullOrEmpty(frmChangeRotableParts.TxtDaysOperationalLimit.Text) ? (decimal?)null : decimal.Parse(frmChangeRotableParts.TxtDaysOperationalLimit.Text),
                        StorageLimit = String.IsNullOrEmpty(frmChangeRotableParts.TxtStorageLimit.Text) ? (decimal?)null : decimal.Parse(frmChangeRotableParts.TxtStorageLimit.Text),
                        TimeSinceNew = String.IsNullOrEmpty(frmChangeRotableParts.TxtTimeSinceNew.Text) ? (decimal?)null : decimal.Parse(frmChangeRotableParts.TxtTimeSinceNew.Text),
                        CyclesSinceNew = String.IsNullOrEmpty(frmChangeRotableParts.TxtCyclesSinceNew.Text) ? (decimal?)null : decimal.Parse(frmChangeRotableParts.TxtCyclesSinceNew.Text),
                        DaysSinceNew = String.IsNullOrEmpty(frmChangeRotableParts.TxtDaysSinceNew.Text) ? (decimal?)null : decimal.Parse(frmChangeRotableParts.TxtDaysSinceNew.Text),
                        TimeSinceOverhaul = String.IsNullOrEmpty(frmChangeRotableParts.TxtTimeSinceOverhaul.Text) ? (decimal?)null : decimal.Parse(frmChangeRotableParts.TxtTimeSinceOverhaul.Text),
                        CyclesSinceOverhaul = String.IsNullOrEmpty(frmChangeRotableParts.TxtCyclesSinceOverhaul.Text) ? (decimal?)null : decimal.Parse(frmChangeRotableParts.TxtCyclesSinceOverhaul.Text),
                        DaysSinceOverhaul = String.IsNullOrEmpty(frmChangeRotableParts.TxtDaysSinceOverhaul.Text) ? (decimal?)null : decimal.Parse(frmChangeRotableParts.TxtDaysSinceOverhaul.Text),
                        ExpireAtDate = String.IsNullOrEmpty(frmChangeRotableParts.TxtStorageLimit.Text) ? (DateTime?)null : DateTime.Parse(frmChangeRotableParts.DpDateOfEntry.Text).AddDays(double.Parse(frmChangeRotableParts.TxtStorageLimit.Text)),
                       // HoursOperationalLimit = decimal.Parse(frmChangeRotableParts.TxtHoursOperationalLimit.Text),
                       // CyclesOperationalLimit = decimal.Parse(frmChangeRotableParts.TxtCyclesOperationalLimit.Text),
                       // DaysOperationalLimit = decimal.Parse(frmChangeRotableParts.TxtDaysOperationalLimit.Text),
                       // StorageLimit = decimal.Parse(frmChangeRotableParts.TxtStorageLimit.Text),
                       // TimeSinceNew = decimal.Parse(frmChangeRotableParts.TxtTimeSinceNew.Text),
                       // CyclesSinceNew = decimal.Parse(frmChangeRotableParts.TxtCyclesSinceNew.Text),
                       // DaysSinceNew = decimal.Parse(frmChangeRotableParts.TxtDaysSinceNew.Text),
                       // TimeSinceOverhaul = decimal.Parse(frmChangeRotableParts.TxtTimeSinceOverhaul.Text),
                       // CyclesSinceOverhaul = decimal.Parse(frmChangeRotableParts.TxtCyclesSinceOverhaul.Text),
                       // DaysSinceOverhaul = decimal.Parse(frmChangeRotableParts.TxtDaysSinceOverhaul.Text),
                       // ExpireAtDate = DateTime.Parse(frmChangeRotableParts.DpDateOfEntry.Text).AddDays(double.Parse(frmChangeRotableParts.TxtStorageLimit.Text)),
                        TableNameIndex = 0,
                        ConditionIndex = 1
                    }
                };

                rotablePartsLog = AzurirajKarton(rotablePartsLog);
                MessageBox.Show("Sistem je ažurirao karton  dijela u evidenciji avio dijelova!", "System Operation is successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                ClearComponent();
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da sačuva karton dijela u evidenciju avio dijelova!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                frmChangeRotableParts.Dispose();
                frmChangeRotableParts = null;
            }
        }

        internal void ClearComponent()
        {
            frmChangeRotableParts.TxtPartNumber.Text = string.Empty;
            frmChangeRotableParts.TxtSerialNumber.Text = string.Empty;
            frmChangeRotableParts.RtbDescription.Text = string.Empty;
            frmChangeRotableParts.DpDateOfEntry.Value = DateTime.Now;
            frmChangeRotableParts.TxtHoursOperationalLimit.Text = string.Empty;
            frmChangeRotableParts.TxtCyclesOperationalLimit.Text = string.Empty;
            frmChangeRotableParts.TxtDaysOperationalLimit.Text = string.Empty;
            frmChangeRotableParts.TxtStorageLimit.Text = string.Empty;
            frmChangeRotableParts.TxtTimeSinceNew.Text = string.Empty;
            frmChangeRotableParts.TxtCyclesSinceNew.Text = string.Empty;
            frmChangeRotableParts.TxtDaysSinceNew.Text = string.Empty;
            frmChangeRotableParts.TxtTimeSinceOverhaul.Text = string.Empty;
            frmChangeRotableParts.TxtCyclesSinceOverhaul.Text = string.Empty;
            frmChangeRotableParts.TxtDaysSinceOverhaul.Text = string.Empty;
            frmChangeRotableParts.BtnCancel.Enabled = false;
            frmChangeRotableParts.BtnAddRotablePartsItem.Enabled = false;
            frmChangeRotableParts.BtnSearchForItem.Enabled = true;
            frmChangeRotableParts.DpDateOfEntry.CustomFormat = " ";
        }

        private bool Validation()
        {
            if (frmChangeRotableParts.TxtPartNumber.Text == string.Empty) return false;
            if (frmChangeRotableParts.TxtSerialNumber.Text == string.Empty) return false;
            if (frmChangeRotableParts.RtbDescription.Text == string.Empty) return false;

            if (!DateTime.TryParse(frmChangeRotableParts.DpDateOfEntry.Text, out _)) return false;
            if (!String.IsNullOrEmpty(frmChangeRotableParts.TxtHoursOperationalLimit.Text) && !decimal.TryParse(frmChangeRotableParts.TxtHoursOperationalLimit.Text, out _)) return false;
            if (!String.IsNullOrEmpty(frmChangeRotableParts.TxtCyclesOperationalLimit.Text) && !decimal.TryParse(frmChangeRotableParts.TxtCyclesOperationalLimit.Text, out _)) return false;
            if (!String.IsNullOrEmpty(frmChangeRotableParts.TxtDaysOperationalLimit.Text) && !decimal.TryParse(frmChangeRotableParts.TxtDaysOperationalLimit.Text, out _)) return false;
            if (!String.IsNullOrEmpty(frmChangeRotableParts.TxtStorageLimit.Text) && !decimal.TryParse(frmChangeRotableParts.TxtStorageLimit.Text, out _)) return false;
            if (!String.IsNullOrEmpty(frmChangeRotableParts.TxtTimeSinceNew.Text) && !decimal.TryParse(frmChangeRotableParts.TxtTimeSinceNew.Text, out _)) return false;
            if (!String.IsNullOrEmpty(frmChangeRotableParts.TxtCyclesSinceNew.Text) && !decimal.TryParse(frmChangeRotableParts.TxtCyclesSinceNew.Text, out _)) return false;
            if (!String.IsNullOrEmpty(frmChangeRotableParts.TxtDaysSinceNew.Text) && !decimal.TryParse(frmChangeRotableParts.TxtDaysSinceNew.Text, out _)) return false;
            if (!String.IsNullOrEmpty(frmChangeRotableParts.TxtTimeSinceOverhaul.Text) && !decimal.TryParse(frmChangeRotableParts.TxtTimeSinceOverhaul.Text, out _)) return false;
            if (!String.IsNullOrEmpty(frmChangeRotableParts.TxtCyclesSinceOverhaul.Text) && !decimal.TryParse(frmChangeRotableParts.TxtCyclesSinceOverhaul.Text, out _)) return false;
            if (!String.IsNullOrEmpty(frmChangeRotableParts.TxtDaysSinceOverhaul.Text) && !decimal.TryParse(frmChangeRotableParts.TxtDaysSinceOverhaul.Text, out _)) return false;
            if (String.IsNullOrEmpty(frmChangeRotableParts.TxtHoursOperationalLimit.Text))
            {
                frmChangeRotableParts.TxtTimeSinceNew.Text = "";
                frmChangeRotableParts.TxtTimeSinceOverhaul.Text = "";
            }
            if (String.IsNullOrEmpty(frmChangeRotableParts.TxtCyclesOperationalLimit.Text))
            {
                frmChangeRotableParts.TxtCyclesSinceNew.Text = "";
                frmChangeRotableParts.TxtCyclesSinceOverhaul.Text = "";
            }
            if (String.IsNullOrEmpty(frmChangeRotableParts.TxtDaysOperationalLimit.Text))
            {
                frmChangeRotableParts.TxtDaysSinceNew.Text = "";
                frmChangeRotableParts.TxtDaysSinceOverhaul.Text = "";
            }
            if (String.IsNullOrEmpty(frmChangeRotableParts.TxtHoursOperationalLimit.Text) && String.IsNullOrEmpty(frmChangeRotableParts.TxtDaysOperationalLimit.Text) && String.IsNullOrEmpty(frmChangeRotableParts.TxtDaysOperationalLimit.Text)) return false;

            return true;
        }

        private bool SearchValidation()
        {
            if (frmChangeRotableParts.TxtPartNumber.Text == string.Empty) return false;
            if (frmChangeRotableParts.TxtSerialNumber.Text == string.Empty) return false;

            return true;
        }


        private RotablePartsLog NadjiDioMagacin(RotablePartsLog rotablePartsLog)
        {
            return Communication.Instance.SendRequest<RotablePartsLog>(Operation.SearchRotablePartsStock, rotablePartsLog);
        }


        private RotablePartsLog AzurirajKarton(RotablePartsLog rotablePartsLog)
        {
            return Communication.Instance.SendRequest<RotablePartsLog>(Operation.UpdateRotableParts, rotablePartsLog);
        }
    }
}
