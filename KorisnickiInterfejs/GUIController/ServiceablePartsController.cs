using Common;
using Domain;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.Forms;
using KorisnickiInterfejs.GUISession;
using KorisnickiInterfejs.ServerCommunication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIController
{
    public class ServiceablePartsController
    {
        FrmServiceableParts frmServiceableParts;
        BindingList<RotablePartsService> stavke = new BindingList<RotablePartsService>();

        internal void InitData(FrmServiceableParts frmServiceableParts)
        {
                try
                {
                    this.frmServiceableParts = frmServiceableParts;
                    frmServiceableParts.DgvServiceableParts.DataSource = GetServiceable();
                    frmServiceableParts.DgvServiceableParts.Columns[0].Visible = false;
                    frmServiceableParts.DgvServiceableParts.Columns[1].Visible = false;
                    frmServiceableParts.DgvServiceableParts.Columns[6].Visible = false;
                    frmServiceableParts.DgvServiceableParts.Columns[7].Visible = false;
                    frmServiceableParts.DgvServiceableParts.Columns[8].Visible = false;
                    frmServiceableParts.DgvServiceableParts.Columns[9].Visible = false;
                    frmServiceableParts.DgvServiceableParts.Columns[10].Visible = false;
                    frmServiceableParts.DgvServiceableParts.Columns[11].Visible = false;

                    frmServiceableParts.DgvServiceableParts.Columns[2].HeaderText = "Part Number";
                    frmServiceableParts.DgvServiceableParts.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    frmServiceableParts.DgvServiceableParts.Columns[2].Width = 120;
                    frmServiceableParts.DgvServiceableParts.Columns[3].HeaderText = "Serial Number";
                    frmServiceableParts.DgvServiceableParts.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    frmServiceableParts.DgvServiceableParts.Columns[3].Width = 130;
                    frmServiceableParts.DgvServiceableParts.Columns[4].HeaderText = "Description";
                    frmServiceableParts.DgvServiceableParts.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    frmServiceableParts.DgvServiceableParts.Columns[4].Width = 300;
                    frmServiceableParts.DgvServiceableParts.Columns[5].HeaderText = "Work Order";
                    frmServiceableParts.DgvServiceableParts.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    frmServiceableParts.DgvServiceableParts.Columns[5].Width = 110;
                    MessageBox.Show("Sistem je našao sledeće servisirane avio dijelove!", "System Operation is successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
                catch (ServerCommunicationException)
                {
                    MessageBox.Show("Sistem ne može da pronađe servisirane dijelove aviona!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    throw new ServerCommunicationException("Veza sa serverom ne postoji!");
                }
                catch (SystemOperationException ex)
                {
                    MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    frmServiceableParts.Dispose();
                    frmServiceableParts = null;
                }
            }


        internal void ChoiceItem(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            frmServiceableParts.DgvServiceableParts.Rows[index].Selected = true;
            Session.Instance.CurrentServiceablePartNumber = ((ServiceableParts)frmServiceableParts.DgvServiceableParts.SelectedRows[0].DataBoundItem).PartNumber;
            Session.Instance.CurrentServiceableSerialNumber = ((ServiceableParts)frmServiceableParts.DgvServiceableParts.SelectedRows[0].DataBoundItem).SerialNumber;
            Session.Instance.CurrentServiceableID_RotablePartsLog = ((ServiceableParts)frmServiceableParts.DgvServiceableParts.SelectedRows[0].DataBoundItem).RotablePartsLog.ID_RotablePartsLog;

            frmServiceableParts.DialogResult = DialogResult.OK;
        }

        
        internal List<ServiceableParts> GetServiceable()
        {
                ServiceableParts serviceableParts = new ServiceableParts
                {
                    RotablePartsLog = new RotablePartsLog(),
                    RotableParts = new RotableParts(),
                    TableNameIndex = 0,
                    SelectFieldsIndex = 0,
                    ConditionIndex = 0
                };
                return NadjiServisirane(serviceableParts); 
        }

        private List<ServiceableParts> NadjiServisirane(ServiceableParts servicableParts)
        {
            return Communication.Instance.SendRequest<List<ServiceableParts>>(Operation.SearchServiceable, servicableParts);
        }
    }
}
