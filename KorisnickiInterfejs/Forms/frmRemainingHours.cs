using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KorisnickiInterfejs.GUIController;

namespace KorisnickiInterfejs.Forms
{
    public partial class FrmRemainingHours : Form
    {

        private RemainingHoursController controller;
       
        public FrmRemainingHours()
        {
            InitializeComponent();
            controller = new RemainingHoursController();
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
