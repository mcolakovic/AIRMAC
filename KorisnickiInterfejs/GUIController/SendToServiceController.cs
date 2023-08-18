using KorisnickiInterfejs.Forms;
using KorisnickiInterfejs.ServerCommunication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using Domain;
using System.Windows.Forms;
using Common;
using KorisnickiInterfejs.Exceptions;

namespace KorisnickiInterfejs.GUIController
{
    public class SendToServiceController
    {
        FrmSendToService frmSendToService;
        Decimal id_RotableParts;

        internal void InitData(FrmSendToService frmSendToService)
        {
            try
            {
                this.frmSendToService = frmSendToService;
            }
            catch (ServerCommunicationException)
            {
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                frmSendToService.Dispose();
                frmSendToService = null;
            }
        }

        internal void SendToService()
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
                    SubClass = (int)SubClass.Service,
                    TableNameIndex = 1,
                    RotablePartsSubClass = new RotablePartsService
                    {
                        RotablePartsLog = new RotablePartsLog(),
                        RotableParts = new RotableParts
                        {
                            ID_RotableParts = id_RotableParts
                        },
                        WorkOrder = frmSendToService.TxtWorkOrder.Text,
                        WorkOrderDescription = frmSendToService.RtbWorkOrderDescription.Text,

                        HoursOperationalLimit = String.IsNullOrEmpty(frmSendToService.TxtHoursOperationalLimit.Text) ? (decimal?)null : decimal.Parse(frmSendToService.TxtHoursOperationalLimit.Text),
                        CyclesOperationalLimit = String.IsNullOrEmpty(frmSendToService.TxtCyclesOperationalLimit.Text) ? (decimal?)null : decimal.Parse(frmSendToService.TxtCyclesOperationalLimit.Text),
                        DaysOperationalLimit = String.IsNullOrEmpty(frmSendToService.TxtDaysOperationalLimit.Text) ? (decimal?)null : decimal.Parse(frmSendToService.TxtDaysOperationalLimit.Text),
                        StorageLimit = String.IsNullOrEmpty(frmSendToService.TxtStorageLimit.Text) ? (decimal?)null : decimal.Parse(frmSendToService.TxtStorageLimit.Text),
                        TimeSinceNew = String.IsNullOrEmpty(frmSendToService.TxtTimeSinceNew.Text) ? (decimal?)null : decimal.Parse(frmSendToService.TxtTimeSinceNew.Text),
                        CyclesSinceNew = String.IsNullOrEmpty(frmSendToService.TxtCyclesSinceNew.Text) ? (decimal?)null : decimal.Parse(frmSendToService.TxtCyclesSinceNew.Text),
                        DaysSinceNew = String.IsNullOrEmpty(frmSendToService.TxtDaysSinceNew.Text) ? (decimal?)null : decimal.Parse(frmSendToService.TxtDaysSinceNew.Text),
                        TimeSinceOverhaul = String.IsNullOrEmpty(frmSendToService.TxtTimeSinceOverhaul.Text) ? (decimal?)null : decimal.Parse(frmSendToService.TxtTimeSinceOverhaul.Text),
                        CyclesSinceOverhaul = String.IsNullOrEmpty(frmSendToService.TxtCyclesSinceOverhaul.Text) ? (decimal?)null : decimal.Parse(frmSendToService.TxtCyclesSinceOverhaul.Text),
                        DaysSinceOverhaul = String.IsNullOrEmpty(frmSendToService.TxtDaysSinceOverhaul.Text) ? (decimal?)null : decimal.Parse(frmSendToService.TxtDaysSinceOverhaul.Text),
                        TableNameIndex = 1
                    }
                };
                rotablePartsLog = PrebaciDioIzMagacinaUServis(rotablePartsLog);
                MessageBox.Show("Sistem je izvršio prebacanje dijela u magacin avio servisa!", "System Operation is successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                ClearComponent();
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da prebaci avionski dio u magacin avio servisa!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                frmSendToService.Dispose();
                frmSendToService = null;
            }
        }

        internal void GetCard()
        {
            try
            {
                if (!SearchValidation())
                {
                    MessageBox.Show("Unos podataka nije validan!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    return;
                }

                RotablePartsLog rotablePartsLog = new RotablePartsLog
                {
                    RotableParts = new RotableParts
                    {
                        PartNumber = frmSendToService.TxtPartNumber.Text,
                        SerialNumber = frmSendToService.TxtSerialNumber.Text
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
                    frmSendToService.RtbDescription.Text = rpl.RotableParts.Description;
                    id_RotableParts = rpl.RotableParts.ID_RotableParts;
                    frmSendToService.TxtHoursOperationalLimit.Text = ((RotablePartsStock)rpl.RotablePartsSubClass).HoursOperationalLimit.ToString();
                    frmSendToService.TxtCyclesOperationalLimit.Text = ((RotablePartsStock)rpl.RotablePartsSubClass).CyclesOperationalLimit.ToString();
                    frmSendToService.TxtDaysOperationalLimit.Text = ((RotablePartsStock)rpl.RotablePartsSubClass).DaysOperationalLimit.ToString();
                    frmSendToService.TxtStorageLimit.Text = ((RotablePartsStock)rpl.RotablePartsSubClass).StorageLimit.ToString();
                    frmSendToService.TxtTimeSinceNew.Text = ((RotablePartsStock)rpl.RotablePartsSubClass).TimeSinceNew.ToString();
                    frmSendToService.TxtCyclesSinceNew.Text = ((RotablePartsStock)rpl.RotablePartsSubClass).CyclesSinceNew.ToString();
                    frmSendToService.TxtDaysSinceNew.Text = ((RotablePartsStock)rpl.RotablePartsSubClass).DaysSinceNew.ToString();
                    frmSendToService.TxtTimeSinceOverhaul.Text = ((RotablePartsStock)rpl.RotablePartsSubClass).TimeSinceOverhaul.ToString();
                    frmSendToService.TxtCyclesSinceOverhaul.Text = ((RotablePartsStock)rpl.RotablePartsSubClass).CyclesSinceOverhaul.ToString();
                    frmSendToService.TxtDaysSinceOverhaul.Text = ((RotablePartsStock)rpl.RotablePartsSubClass).DaysSinceOverhaul.ToString();
                    MessageBox.Show("Sistem je našao avionski dio u magacinu avionskih dijelova!", "System Operation is successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    frmSendToService.BtnSendToService.Enabled = true;
                    frmSendToService.BtnSearchForItem.Enabled = false;
                    frmSendToService.BtnCancel.Enabled = true;                 
                }                
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da pronađe avionski dio u magacinu avionskih dijelova!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                frmSendToService.Dispose();
                frmSendToService = null;
            }
        }

        internal void ClearComponent()
        {
            frmSendToService.TxtPartNumber.Text = string.Empty;
            frmSendToService.TxtSerialNumber.Text = string.Empty;
            frmSendToService.RtbDescription.Text = string.Empty;
            frmSendToService.TxtHoursOperationalLimit.Text = string.Empty;
            frmSendToService.TxtCyclesOperationalLimit.Text = string.Empty;
            frmSendToService.TxtDaysOperationalLimit.Text = string.Empty;
            frmSendToService.TxtStorageLimit.Text = string.Empty;
            frmSendToService.TxtTimeSinceNew.Text = string.Empty;
            frmSendToService.TxtCyclesSinceNew.Text = string.Empty;
            frmSendToService.TxtDaysSinceNew.Text = string.Empty;
            frmSendToService.TxtTimeSinceOverhaul.Text = string.Empty;
            frmSendToService.TxtCyclesSinceOverhaul.Text = string.Empty;
            frmSendToService.TxtDaysSinceOverhaul.Text = string.Empty;
            frmSendToService.TxtWorkOrder.Text = string.Empty;
            frmSendToService.RtbWorkOrderDescription.Text = string.Empty;
            frmSendToService.BtnSendToService.Enabled = false;
            frmSendToService.BtnSearchForItem.Enabled = true;
            frmSendToService.BtnCancel.Enabled = false; 
        }

        private bool Validation()
        {
            if (frmSendToService.TxtWorkOrder.Text == string.Empty) return false;
            if (frmSendToService.RtbWorkOrderDescription.Text == string.Empty) return false;

            return true;
        }
        private bool SearchValidation()
        {
            if (frmSendToService.TxtPartNumber.Text == string.Empty) return false;
            if (frmSendToService.TxtSerialNumber.Text == string.Empty) return false;

            return true;
        }

        private RotablePartsLog NadjiDioMagacin(RotablePartsLog rotablePartsLog)
        {
            return Communication.Instance.SendRequest<RotablePartsLog>(Operation.SearchRotablePartsStock, rotablePartsLog);
        }

        private RotablePartsLog PrebaciDioIzMagacinaUServis(RotablePartsLog rotablePartsLog)
        {
            return Communication.Instance.SendRequest<RotablePartsLog>(Operation.SendToService, rotablePartsLog);
        }

    }
}
