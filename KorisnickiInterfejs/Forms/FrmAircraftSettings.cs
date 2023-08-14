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
    public partial class FrmAircraftSettings : Form
    {
        private AircraftSettingsController controller;
        public FrmAircraftSettings()
        {
            InitializeComponent();
            controller = new AircraftSettingsController();
            controller.InitData(this);
        }

        private void btnAddAircraaft_Click(object sender, EventArgs e)
        {
            controller.AddAircraft();
        }
    }
}
