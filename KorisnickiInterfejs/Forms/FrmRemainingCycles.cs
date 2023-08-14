using System;
using System.Windows.Forms;
using KorisnickiInterfejs.GUIController;

namespace KorisnickiInterfejs.Forms
{
    public partial class FrmRemainingCycles : Form
    {
        private RemainingCyclesController controller;

        public FrmRemainingCycles()
        {
            InitializeComponent();
            controller = new RemainingCyclesController();
            controller.InitData(this);
        }

        private void cbAircraft_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.AircraftChanged();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            controller.SearchREM();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            controller.report();
        }

    }
}
