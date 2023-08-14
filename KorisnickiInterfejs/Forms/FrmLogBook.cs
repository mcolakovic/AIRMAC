using KorisnickiInterfejs.GUIController;
using System;
using System.Windows.Forms;

namespace KorisnickiInterfejs.Forms
{
    public partial class FrmLogBook : Form
    {
        private LogBookController controller;

        public FrmLogBook()
        {
            InitializeComponent();
            controller = new LogBookController();
            controller.InitData(this);
        }

        private void cbAircraft_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.AircraftChanged();
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            controller.AddFlight();
        }

        private void dpFlightTimeStart_ValueChanged(object sender, EventArgs e)
        {
            controller.FlightChanged();
        }

        private void dpFlightTimeStop_ValueChanged(object sender, EventArgs e)
        {
            controller.FlightChanged();
        }

        private void btnNewFlight_Click(object sender, EventArgs e)
        {
            controller.NewFlight();
        }

       
    }
}
