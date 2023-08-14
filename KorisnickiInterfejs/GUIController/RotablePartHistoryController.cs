using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Common;
using Domain;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.Forms;
using KorisnickiInterfejs.ServerCommunication;

namespace KorisnickiInterfejs.GUIController
{
    public class RotablePartHistoryController
    {
        FrmRotablePartHistory frmRotablePartHistory;
        BindingList<RotablePartHistory> stavke = new BindingList<RotablePartHistory>();

        internal void InitData(FrmRotablePartHistory frmRotablePartHistory)
        {
            try
            {
                this.frmRotablePartHistory = frmRotablePartHistory;

                frmRotablePartHistory.DgvCardHistory.DataSource = stavke;
                frmRotablePartHistory.DgvCardHistory.Columns[0].Visible = false;
                frmRotablePartHistory.DgvCardHistory.Columns[1].Visible = false;
                frmRotablePartHistory.DgvCardHistory.Columns[2].Visible = false;
                frmRotablePartHistory.DgvCardHistory.Columns[3].HeaderText = "Action";
                frmRotablePartHistory.DgvCardHistory.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                frmRotablePartHistory.DgvCardHistory.Columns[3].Width = 180;
                frmRotablePartHistory.DgvCardHistory.Columns[4].HeaderText = "Detais";
                frmRotablePartHistory.DgvCardHistory.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                frmRotablePartHistory.DgvCardHistory.Columns[4].Width = 650;
                frmRotablePartHistory.DgvCardHistory.Columns[5].Visible = false;
                frmRotablePartHistory.DgvCardHistory.Columns[6].Visible = false;
                frmRotablePartHistory.DgvCardHistory.Columns[7].Visible = false;
                frmRotablePartHistory.DgvCardHistory.Columns[8].Visible = false;
                frmRotablePartHistory.DgvCardHistory.Columns[9].Visible = false;
                frmRotablePartHistory.DgvCardHistory.Columns[10].Visible = false;



            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da pronađe istoriju avionskog dijela!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                frmRotablePartHistory.Dispose();
                frmRotablePartHistory = null;
            }
        }

        internal void GetCard()
        {
            if (!Validation())
            {
                MessageBox.Show("Unos podataka nije validan!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }
            try
            {
                RotableParts rotableParts = new RotableParts
                {
                    PartNumber = frmRotablePartHistory.TxtPartNumber.Text,
                    SerialNumber = frmRotablePartHistory.TxtSerialNumber.Text
                };
                RotableParts rp = NadjiKarton(rotableParts);
                frmRotablePartHistory.RtbDescription.Text = rp.Description;

                RotablePartHistory rotablePartHistory = new RotablePartHistory
                {
                    PartNumber = rp.PartNumber,
                    SerialNumber = rp.SerialNumber
                };

                stavke = VratiIstorijuDijela(rotablePartHistory);
                frmRotablePartHistory.DgvCardHistory.DataSource = stavke;
                MessageBox.Show("Sistem je našao istoriju dijela!", "System Operation is successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da nađe karton dijela u evidenciji avio dijelova!", "System Operation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show("Sistem ne može da nađe karton dijela u evidenciji avio dijelova!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

       

        private bool Validation()
        {
            if (frmRotablePartHistory.TxtPartNumber.Text == string.Empty) return false;
            if (frmRotablePartHistory.TxtSerialNumber.Text == string.Empty) return false;
  
            
            return true;
        }

        private RotableParts NadjiKarton(RotableParts rotableParts)
            {
                return Communication.Instance.SendRequest<RotableParts>(Operation.SearchRotableParts, rotableParts);
            }

        private BindingList<RotablePartHistory> VratiIstorijuDijela(RotablePartHistory rotablePartHistory)
        {
            return new BindingList<RotablePartHistory>(Communication.Instance.SendRequest<List<RotablePartHistory>>(Operation.SearchRotablePartHistory, rotablePartHistory));
        }
    }

}
