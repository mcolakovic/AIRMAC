using KorisnickiInterfejs.Forms;
using KorisnickiInterfejs.ServerCommunication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using Domain;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.Windows.Forms;
using KorisnickiInterfejs.GUISession;
using System.Net.Configuration;
using KorisnickiInterfejs.Exceptions;

namespace KorisnickiInterfejs.GUIController
{
    class ServiceInspenctionController
    {
        FrmServiceInspenction frmServiceInspenction;
        Decimal id_RotablePartsLog;
        Decimal id_RotableParts;
        internal void InitData(FrmServiceInspenction frmServiceInspenction)
        {
            try
            {
                this.frmServiceInspenction = frmServiceInspenction;
            }
            catch (ServerCommunicationException)
            {
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                frmServiceInspenction.Dispose();
                frmServiceInspenction = null;
            }
        }

        internal void OperationalLimit()
        {
            if (frmServiceInspenction.RbNewOperationalLimit.Checked)
            {
                frmServiceInspenction.GbLimit.Enabled = true;
            }
            else if (frmServiceInspenction.RbOverhaul.Checked)
            {
                frmServiceInspenction.GbLimit.Enabled = false;
            }
            else if (frmServiceInspenction.RbTested.Checked)
            {
                frmServiceInspenction.GbLimit.Enabled = false;
            }
            frmServiceInspenction.TxtHoursOperationalLimit.Text = "";
            frmServiceInspenction.TxtCyclesOperationalLimit.Text = "";
            frmServiceInspenction.TxtDaysOperationalLimit.Text = "";
            frmServiceInspenction.TxtStorageLimit.Text = "";
        }

        internal void ResultOfInspection()
        {
            try
            {
                if (!Validation())
                {
                    MessageBox.Show("Unos podataka nije validan!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    return;
                }

                    RotablePartsService rotablePartsService = new RotablePartsService
                    {
                        RotablePartsLog = new RotablePartsLog
                        {
                            ID_RotablePartsLog = Session.Instance.CurrentUnserviceableID_RotablePartsLog
                        },
                        RotableParts = new RotableParts(),
                        ID_ResultOfInspection = CheckRadio(),
                        NewHoursOperationalLimit = frmServiceInspenction.TxtHoursOperationalLimit.Text == "" ? (decimal?)null : Decimal.Parse(frmServiceInspenction.TxtHoursOperationalLimit.Text),
                        NewCyclesOperationalLimit = frmServiceInspenction.TxtCyclesOperationalLimit.Text == "" ? (decimal?)null : Decimal.Parse(frmServiceInspenction.TxtCyclesOperationalLimit.Text),
                        NewDaysOperationalLimit = frmServiceInspenction.TxtDaysOperationalLimit.Text == "" ? (decimal?)null : Decimal.Parse(frmServiceInspenction.TxtDaysOperationalLimit.Text),
                        NewStorageLimit = frmServiceInspenction.TxtStorageLimit.Text == "" ? (decimal?)null : Decimal.Parse(frmServiceInspenction.TxtStorageLimit.Text),
                        Description = frmServiceInspenction.RtbResultOfInspection.Text,

                        TableNameIndex = 0,
                        ConditionIndex = 1
                    };
                
                    RotablePartsService rpa = RezultatInspekcije(rotablePartsService); 
                    MessageBox.Show("Sistem je prebacio dio u magacin servisiranih avio dijelova!", "System Operation is successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    frmServiceInspenction.BtnCancel.Enabled = false;
                    frmServiceInspenction.BtnConfirm.Enabled = false;
                    frmServiceInspenction.BtnSearchForItem.Enabled = true;
                    ClearComponent();
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da prebaci dio u magacin servisiranih avionskih dijelova!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                frmServiceInspenction.Dispose();
                frmServiceInspenction = null;
            }
        }

        private decimal CheckRadio()
        {
            if (frmServiceInspenction.RbNewOperationalLimit.Checked) return 1;
            if (frmServiceInspenction.RbOverhaul.Checked) return 2;
            if (frmServiceInspenction.RbTested.Checked) return 3;
            return 0;
        }

        internal void GetCard(string partNumber, string serialNumber)
        {
            try
            {
                frmServiceInspenction.TxtPartNumber.Text = partNumber;
                frmServiceInspenction.TxtSerialNumber.Text = serialNumber;


                RotablePartsLog rotablePartsLog = new RotablePartsLog
                {
                    RotableParts = new RotableParts
                    {
                        PartNumber = frmServiceInspenction.TxtPartNumber.Text,
                        SerialNumber = frmServiceInspenction.TxtSerialNumber.Text
                    },

                    RotablePartsSubClass = new RotablePartsService
                    {
                        RotablePartsLog = new RotablePartsLog(),
                        RotableParts = new RotableParts(),
                        TableNameIndex = 0,
                        SelectFieldsIndex = 0,
                        ConditionIndex = 0
                    }
                };

                    RotablePartsLog rpl = NeservisiraniDio(rotablePartsLog);
                    if (rpl != null)
                    {
                        frmServiceInspenction.RtbDescription.Text = rpl.RotableParts.Description;
                        id_RotablePartsLog = ((RotablePartsService)rpl.RotablePartsSubClass).RotablePartsLog.ID_RotablePartsLog;
                        id_RotableParts = ((RotablePartsService)rpl.RotablePartsSubClass).RotableParts.ID_RotableParts;
                        frmServiceInspenction.TxtWorkOrder.Text = ((RotablePartsService)rpl.RotablePartsSubClass).WorkOrder;
                        frmServiceInspenction.RtbWorkOrderDescription.Text = ((RotablePartsService)rpl.RotablePartsSubClass).WorkOrderDescription;
                        MessageBox.Show("Sistem je spreman da sačuva rezultat inspekcije dijela!", "System Operation is successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                        frmServiceInspenction.BtnCancel.Enabled = true;
                        frmServiceInspenction.BtnConfirm.Enabled = true;
                        frmServiceInspenction.BtnSearchForItem.Enabled = false;
                    }               
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da pronađe neservisirani dio aviona!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                frmServiceInspenction.Dispose();
                frmServiceInspenction = null;
            }
        }

        internal void ClearComponent()
        {
            frmServiceInspenction.TxtPartNumber.Text = string.Empty;
            frmServiceInspenction.TxtSerialNumber.Text = string.Empty;
            frmServiceInspenction.RtbDescription.Text = string.Empty;
            frmServiceInspenction.TxtWorkOrder.Text = string.Empty;
            frmServiceInspenction.RtbWorkOrderDescription.Text = string.Empty;
            frmServiceInspenction.TxtHoursOperationalLimit.Text = string.Empty;
            frmServiceInspenction.TxtCyclesOperationalLimit.Text = string.Empty;
            frmServiceInspenction.TxtDaysOperationalLimit.Text = string.Empty;
            frmServiceInspenction.TxtStorageLimit.Text = string.Empty;
            frmServiceInspenction.RtbResultOfInspection.Text = string.Empty;
            frmServiceInspenction.BtnCancel.Enabled = false;
            frmServiceInspenction.BtnConfirm.Enabled = false;
            frmServiceInspenction.BtnSearchForItem.Enabled = true;
            frmServiceInspenction.RbTested.Checked = true;
        }

        private bool Validation()
        {
            if (frmServiceInspenction.RtbResultOfInspection.Text == string.Empty) return false;
            if (frmServiceInspenction.RbNewOperationalLimit.Checked && !String.IsNullOrEmpty(frmServiceInspenction.TxtHoursOperationalLimit.Text) && !decimal.TryParse(frmServiceInspenction.TxtHoursOperationalLimit.Text, out _)) return false;
            if (frmServiceInspenction.RbNewOperationalLimit.Checked && !String.IsNullOrEmpty(frmServiceInspenction.TxtCyclesOperationalLimit.Text) && !decimal.TryParse(frmServiceInspenction.TxtCyclesOperationalLimit.Text, out _)) return false;
            if (frmServiceInspenction.RbNewOperationalLimit.Checked && !String.IsNullOrEmpty(frmServiceInspenction.TxtDaysOperationalLimit.Text) && !decimal.TryParse(frmServiceInspenction.TxtDaysOperationalLimit.Text, out _)) return false;
            if (frmServiceInspenction.RbNewOperationalLimit.Checked && !String.IsNullOrEmpty(frmServiceInspenction.TxtStorageLimit.Text) && !decimal.TryParse(frmServiceInspenction.TxtStorageLimit.Text, out _)) return false;
            if (frmServiceInspenction.RbNewOperationalLimit.Checked && String.IsNullOrEmpty(frmServiceInspenction.TxtHoursOperationalLimit.Text) && String.IsNullOrEmpty(frmServiceInspenction.TxtDaysOperationalLimit.Text) && String.IsNullOrEmpty(frmServiceInspenction.TxtDaysOperationalLimit.Text)) return false;

            return true;
        }

        private RotablePartsLog NeservisiraniDio(RotablePartsLog rotablePartsLog)
        {
            return Communication.Instance.SendRequest<RotablePartsLog>(Operation.SearchRotablePartsService, rotablePartsLog);
        }

        private RotablePartsService RezultatInspekcije(RotablePartsService rotablePartsService)
        {
            return Communication.Instance.SendRequest<RotablePartsService>(Operation.ServiceInspection, rotablePartsService);
        }
    }
}
