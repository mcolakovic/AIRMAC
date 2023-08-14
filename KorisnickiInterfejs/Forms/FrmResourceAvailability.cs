using KorisnickiInterfejs.GUIController;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace KorisnickiInterfejs.Forms
{
    public partial class FrmResourceAvailability : Form
    {
        bool IsInit;
        private ResourceAvailabilityController controller;
        public FrmResourceAvailability(bool IsInit = true)
        {
            InitializeComponent();
            this.IsInit = IsInit;
            controller = new ResourceAvailabilityController();
            controller.InitData(this);
        }

        private void cbAircraft_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.AircraftChanged();

        }

        private void dgvResourceAvailability_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!IsInit) controller.ChoiceRotablePart(e);
        }

        
    }
}
