using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.GUIController;
using KorisnickiInterfejs.GUISession;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.Forms
{
    public partial class FrmServiceInspenction : Form
    {
        private ServiceInspenctionController controller;
        public FrmServiceInspenction()
        {
            InitializeComponent();
            controller = new ServiceInspenctionController();
            controller.InitData(this);
        }

       
        private void btnSearchForItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmUnserviceableParts frmUnserviceableParts = new FrmUnserviceableParts();

                if (frmUnserviceableParts.ShowDialog() == DialogResult.OK)
                {
                    controller.GetCard(Session.Instance.CurrentUnserviceablePartNumber, Session.Instance.CurrentUnserviceableSerialNumber);
                    frmUnserviceableParts.Dispose();
                }
            }
            catch (ServerCommunicationException)
            {
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                this.Dispose();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            controller.ResultOfInspection();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            controller.ClearComponent();
        }

        private void rbNewOperationalLimit_CheckedChanged(object sender, EventArgs e)
        {
            controller.OperationalLimit();
        }

        private void rbOverhaul_CheckedChanged(object sender, EventArgs e)
        {
            controller.OperationalLimit();
        }

        private void rbTested_CheckedChanged(object sender, EventArgs e)
        {
            controller.OperationalLimit();
        }
    }
}
