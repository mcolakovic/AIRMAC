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
    public class UnserviceablePartsController
    {
        FrmUnserviceableParts frmUnserviceableParts;
        BindingList<RotablePartsService> stavke = new BindingList<RotablePartsService>();

        internal void InitData(FrmUnserviceableParts frmUnserviceableParts)
        {
            try
            {
                this.frmUnserviceableParts = frmUnserviceableParts;
                frmUnserviceableParts.DgvUnserviceableParts.DataSource = GetUnserviceable();
                frmUnserviceableParts.DgvUnserviceableParts.Columns[0].Visible = false;
                frmUnserviceableParts.DgvUnserviceableParts.Columns[1].Visible = false;
                frmUnserviceableParts.DgvUnserviceableParts.Columns[6].Visible = false;
                frmUnserviceableParts.DgvUnserviceableParts.Columns[7].Visible = false;
                frmUnserviceableParts.DgvUnserviceableParts.Columns[8].Visible = false;
                frmUnserviceableParts.DgvUnserviceableParts.Columns[9].Visible = false;
                frmUnserviceableParts.DgvUnserviceableParts.Columns[10].Visible = false;
                frmUnserviceableParts.DgvUnserviceableParts.Columns[11].Visible = false;

                frmUnserviceableParts.DgvUnserviceableParts.Columns[2].HeaderText = "Part Number";
                frmUnserviceableParts.DgvUnserviceableParts.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                frmUnserviceableParts.DgvUnserviceableParts.Columns[2].Width = 120;
                frmUnserviceableParts.DgvUnserviceableParts.Columns[3].HeaderText = "Serial Number";
                frmUnserviceableParts.DgvUnserviceableParts.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                frmUnserviceableParts.DgvUnserviceableParts.Columns[3].Width = 130;
                frmUnserviceableParts.DgvUnserviceableParts.Columns[4].HeaderText = "Description";
                frmUnserviceableParts.DgvUnserviceableParts.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                frmUnserviceableParts.DgvUnserviceableParts.Columns[4].Width = 300;
                frmUnserviceableParts.DgvUnserviceableParts.Columns[5].HeaderText = "Work Order";
                frmUnserviceableParts.DgvUnserviceableParts.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                frmUnserviceableParts.DgvUnserviceableParts.Columns[5].Width = 110;
                MessageBox.Show("Sistem je našao sledeće neservisirane avio dijelove!", "System Operation is successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da pronađe neservisirane dijelove aviona!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                frmUnserviceableParts.Dispose();
                frmUnserviceableParts = null;
            }
        }

        internal void ChoiceItem(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            frmUnserviceableParts.DgvUnserviceableParts.Rows[index].Selected = true;
            Session.Instance.CurrentUnserviceablePartNumber = ((UnserviceableParts)frmUnserviceableParts.DgvUnserviceableParts.SelectedRows[0].DataBoundItem).PartNumber;
            Session.Instance.CurrentUnserviceableSerialNumber = ((UnserviceableParts)frmUnserviceableParts.DgvUnserviceableParts.SelectedRows[0].DataBoundItem).SerialNumber;
            Session.Instance.CurrentUnserviceableID_RotablePartsLog = ((UnserviceableParts)frmUnserviceableParts.DgvUnserviceableParts.SelectedRows[0].DataBoundItem).RotablePartsLog.ID_RotablePartsLog;

            frmUnserviceableParts.DialogResult = DialogResult.OK;
        }

        internal List<UnserviceableParts> GetUnserviceable()
        {
                UnserviceableParts unservicableParts = new UnserviceableParts
                {
                    RotablePartsLog = new RotablePartsLog(),
                    RotableParts = new RotableParts(),
                    TableNameIndex = 0,
                    SelectFieldsIndex = 0,
                    ConditionIndex = 0
                };
                return NadjiNeservisirane(unservicableParts);
        }

        private List<UnserviceableParts> NadjiNeservisirane(UnserviceableParts unservicableParts)
        {
            return Communication.Instance.SendRequest<List<UnserviceableParts>>(Operation.SearchUnservicable, unservicableParts);
        }
    }
}
