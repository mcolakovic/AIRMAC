using KorisnickiInterfejs.GUIController;
using KorisnickiInterfejs.GUISession;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.Forms
{
    public partial class FrmReturnToStock : Form
    {
        private ReturnToStockController controller;
        public FrmReturnToStock()
        {
            InitializeComponent();
            controller = new ReturnToStockController();
            controller.InitData(this);
        }

        private void btnSearchForItem_Click(object sender, EventArgs e)
        {
            FrmServiceableParts frmServiceableParts = new FrmServiceableParts();

            if (frmServiceableParts.ShowDialog() == DialogResult.OK)
            {
                controller.GetCard(Session.Instance.CurrentServiceablePartNumber, Session.Instance.CurrentServiceableSerialNumber);
                frmServiceableParts.Dispose();
            }
        }

        private void btnReturnToStock_Click(object sender, EventArgs e)
        {
            controller.SendToStock();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            controller.ClearComponent();
        }
    }
}
