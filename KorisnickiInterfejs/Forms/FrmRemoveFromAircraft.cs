using KorisnickiInterfejs.GUIController;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace KorisnickiInterfejs.Forms
{
    public partial class FrmRemoveFromAircraft : Form
    {
        private RemoveFromAircraftController controller;
        public FrmRemoveFromAircraft()
        {
            InitializeComponent();
            controller = new RemoveFromAircraftController();
            controller.InitData(this);
        }

        private void btnSearchForItem_Click(object sender, EventArgs e)
        {
            FrmResourceAvailability frmResourceAvailability = new FrmResourceAvailability(false);
            if (frmResourceAvailability.ShowDialog() == DialogResult.OK)
            {
                frmResourceAvailability.Dispose();
                frmResourceAvailability = null;
                controller.GetCard();
            }
        }

    private void cbAircraft_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.AircraftChanged();
        }

        private void btnRemoveFromAircraft_Click(object sender, EventArgs e)
        {
            controller.SendItemToStock();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            controller.ClearComponent();
        }
    }
}
