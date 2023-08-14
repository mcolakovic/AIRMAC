using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using KorisnickiInterfejs.Forms;
using KorisnickiInterfejs.ServerCommunication;
using Domain;
using System.Windows.Forms;
using Common;
using KorisnickiInterfejs.Exceptions;

namespace KorisnickiInterfejs.GUIController
{
    public class ReturnToStockController
    {
        FrmReturnToStock frmReturnToStock;
        Decimal id_RotablePartsLog;
        Decimal id_RotableParts;
        Decimal? TSN;
        Decimal? CSN;
        Decimal? DSN;
        Decimal? TSO;
        Decimal? CSO;
        Decimal? DSO;
        Decimal? HOL;
        Decimal? COL;
        Decimal? DOL;
        Decimal? SL;

        internal void InitData(FrmReturnToStock frmReturnToStock)
        {
            try
            {
                this.frmReturnToStock = frmReturnToStock;
                 frmReturnToStock.DpDateOfEntry.CustomFormat = " ";
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da pronađe podatke o avionu i aerodromima!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                frmReturnToStock.Dispose();
                frmReturnToStock = null;
            }
        }

        internal void GetCard(string partNumber, string serialNumber)
        {
            try
            {
                frmReturnToStock.TxtPartNumber.Text = partNumber;
                frmReturnToStock.TxtSerialNumber.Text = serialNumber;



                RotablePartsLog rotablePartsLog = new RotablePartsLog
                {
                    RotableParts = new RotableParts
                    {
                        PartNumber = frmReturnToStock.TxtPartNumber.Text,
                        SerialNumber = frmReturnToStock.TxtSerialNumber.Text
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


                    RotablePartsLog rpl = ServisiraniDio(rotablePartsLog);
                    if (rpl != null)
                    {
                        frmReturnToStock.RtbDescription.Text = rpl.RotableParts.Description;
                        id_RotablePartsLog = ((RotablePartsService)rpl.RotablePartsSubClass).RotablePartsLog.ID_RotablePartsLog;
                        id_RotableParts = ((RotablePartsService)rpl.RotablePartsSubClass).RotableParts.ID_RotableParts;
                        frmReturnToStock.TxtWorkOrder.Text = ((RotablePartsService)rpl.RotablePartsSubClass).WorkOrder;
                        frmReturnToStock.RtbWorkOrderDescription.Text = ((RotablePartsService)rpl.RotablePartsSubClass).WorkOrderDescription;
                        switch(((RotablePartsService)rpl.RotablePartsSubClass).ID_ResultOfInspection) {
                            case 1:
                                 frmReturnToStock.RbNewOperationalLimit.Checked = true;
                                 break;
                            case 2:
                                 frmReturnToStock.RbOverhaul.Checked = true;
                                 break;
                            case 3
:                                frmReturnToStock.RbTested.Checked = true;
                                 break;
                        }
                        frmReturnToStock.TxtHoursOperationalLimit.Text = ((RotablePartsService)rpl.RotablePartsSubClass).NewHoursOperationalLimit.ToString() ==  "0" ? "" : ((RotablePartsService)rpl.RotablePartsSubClass).NewHoursOperationalLimit.ToString();
                        frmReturnToStock.TxtCyclesOperationalLimit.Text = ((RotablePartsService)rpl.RotablePartsSubClass).NewCyclesOperationalLimit.ToString() == "0" ? "" : ((RotablePartsService)rpl.RotablePartsSubClass).NewCyclesOperationalLimit.ToString();
                        frmReturnToStock.TxtDaysOperationalLimit.Text = ((RotablePartsService)rpl.RotablePartsSubClass).NewDaysOperationalLimit.ToString() == "0" ? "" : ((RotablePartsService)rpl.RotablePartsSubClass).NewDaysOperationalLimit.ToString();
                        frmReturnToStock.TxtStorageLimit.Text = ((RotablePartsService)rpl.RotablePartsSubClass).NewStorageLimit.ToString() == "0" ? "" : ((RotablePartsService)rpl.RotablePartsSubClass).NewStorageLimit.ToString();
                        frmReturnToStock.RtbResultOfInspection.Text = ((RotablePartsService)rpl.RotablePartsSubClass).Description;
                        TSN = ((RotablePartsService)rpl.RotablePartsSubClass).TimeSinceNew;
                        TSO = ((RotablePartsService)rpl.RotablePartsSubClass).TimeSinceOverhaul;
                        CSN = ((RotablePartsService)rpl.RotablePartsSubClass).CyclesSinceNew;
                        CSO = ((RotablePartsService)rpl.RotablePartsSubClass).CyclesSinceOverhaul;
                        DSN = ((RotablePartsService)rpl.RotablePartsSubClass).DaysSinceNew;
                        DSO = ((RotablePartsService)rpl.RotablePartsSubClass).DaysSinceOverhaul;
                        HOL = ((RotablePartsService)rpl.RotablePartsSubClass).HoursOperationalLimit;
                        COL = ((RotablePartsService)rpl.RotablePartsSubClass).CyclesOperationalLimit;
                        DOL = ((RotablePartsService)rpl.RotablePartsSubClass).DaysOperationalLimit;
                        SL = ((RotablePartsService)rpl.RotablePartsSubClass).StorageLimit;
                        frmReturnToStock.DpDateOfEntry.CustomFormat = "dd/MM/yyyy";
                        frmReturnToStock.DpDateOfEntry.Value = DateTime.Now;
                        MessageBox.Show("Sistem je spreman da prebaci dio u magacin avio dijelova!", "System Operation is successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                        frmReturnToStock.BtnCancel.Enabled = true;
                        frmReturnToStock.BtnReturnToStock.Enabled = true;
                        frmReturnToStock.BtnSearchForItem.Enabled = false;
                    }
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da pronađe servisirani dio aviona!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                frmReturnToStock.Dispose();
                frmReturnToStock = null;
            }
        }

        internal void SendToStock()
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
                        RotableParts = new RotableParts { ID_RotableParts = id_RotableParts },
                        DateOfEntry = DateTime.Parse(frmReturnToStock.DpDateOfEntry.Text),
                        HoursOperationalLimit = frmReturnToStock.RbNewOperationalLimit.Checked == true && !String.IsNullOrEmpty(frmReturnToStock.TxtHoursOperationalLimit.Text) ? decimal.Parse(frmReturnToStock.TxtHoursOperationalLimit.Text) : (decimal?)HOL,
                        CyclesOperationalLimit = frmReturnToStock.RbNewOperationalLimit.Checked == true && !String.IsNullOrEmpty(frmReturnToStock.TxtCyclesOperationalLimit.Text) ? decimal.Parse(frmReturnToStock.TxtCyclesOperationalLimit.Text) : (decimal?)COL,
                        DaysOperationalLimit = frmReturnToStock.RbNewOperationalLimit.Checked == true && !String.IsNullOrEmpty(frmReturnToStock.TxtDaysOperationalLimit.Text) ? decimal.Parse(frmReturnToStock.TxtDaysOperationalLimit.Text) : (decimal?)DOL,
                        StorageLimit = frmReturnToStock.RbNewOperationalLimit.Checked == true && !String.IsNullOrEmpty(frmReturnToStock.TxtStorageLimit.Text) ? decimal.Parse(frmReturnToStock.TxtStorageLimit.Text) : (decimal?)SL,
                        TimeSinceNew = TSN,
                        CyclesSinceNew = CSN,
                        DaysSinceNew = DSN,
                        TimeSinceOverhaul = (frmReturnToStock.RbOverhaul.Checked == true || frmReturnToStock.RbNewOperationalLimit.Checked == true) ? 0 : (decimal?)TSO,
                        CyclesSinceOverhaul = (frmReturnToStock.RbOverhaul.Checked == true || frmReturnToStock.RbNewOperationalLimit.Checked == true) ? 0 : (decimal?)CSO,
                        DaysSinceOverhaul = (frmReturnToStock.RbOverhaul.Checked == true || frmReturnToStock.RbNewOperationalLimit.Checked == true) ? 0 : (decimal?)DSO,
                        ExpireAtDate = DateTime.Parse(frmReturnToStock.DpDateOfEntry.Text).AddDays((double)(frmReturnToStock.RbNewOperationalLimit.Checked == true ? decimal.Parse(frmReturnToStock.TxtStorageLimit.Text) : SL)),
                        IsInitial = false,
                        TableNameIndex = 1,
                    }
                };

                rotablePartsLog = PrebaciDioIzServisaUMagacin(rotablePartsLog);
                MessageBox.Show("Sistem je izvršio prebacanje dijela u magacin avio dijelova!", "System Operation is successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                ClearComponent();
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da prebaci dio iz avio servisa u magacin avio dijelova!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                frmReturnToStock.Dispose();
                frmReturnToStock = null;
            }
        }

        internal void ClearComponent()
        {
            frmReturnToStock.TxtPartNumber.Text = string.Empty;
            frmReturnToStock.TxtSerialNumber.Text = string.Empty;
            frmReturnToStock.RtbDescription.Text = string.Empty;
            frmReturnToStock.TxtWorkOrder.Text = string.Empty;
            frmReturnToStock.RtbWorkOrderDescription.Text = string.Empty;
            frmReturnToStock.TxtHoursOperationalLimit.Text = string.Empty;
            frmReturnToStock.TxtCyclesOperationalLimit.Text = string.Empty;
            frmReturnToStock.TxtDaysOperationalLimit.Text = string.Empty;
            frmReturnToStock.TxtStorageLimit.Text = string.Empty;
            frmReturnToStock.RtbResultOfInspection.Text = string.Empty;
            frmReturnToStock.BtnCancel.Enabled = false;
            frmReturnToStock.BtnReturnToStock.Enabled = false;
            frmReturnToStock.BtnSearchForItem.Enabled = true;
            frmReturnToStock.RbTested.Checked = true;
            frmReturnToStock.DpDateOfEntry.CustomFormat = " ";
        }

        private RotablePartsLog PrebaciDioIzServisaUMagacin(RotablePartsLog rotablePartsLog)
        {
           return Communication.Instance.SendRequest<RotablePartsLog>(Operation.SendFromServiceToStock, rotablePartsLog);
        }

        private RotablePartsLog ServisiraniDio(RotablePartsLog rotablePartsLog)
        {
            return Communication.Instance.SendRequest<RotablePartsLog>(Operation.SearchRotablePartsService, rotablePartsLog);
        }
        
    }
}
