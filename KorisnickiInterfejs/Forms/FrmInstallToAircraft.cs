using KorisnickiInterfejs.GUIController;
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
    public partial class FrmInstallToAircraft : Form
    {
        private InstallToAircraftController controller;

        public FrmInstallToAircraft()
        {
            InitializeComponent();
            controller = new InstallToAircraftController();
            controller.InitData(this);
        }

        private void btnInstallRotablePartsOnAircraft_Click(object sender, EventArgs e)
        {
            controller.InstallRotablePartOnAircraft();
        }

        private void cbAircraft_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.AircraftChanged();
        }

        private void btnSearchForItem_Click(object sender, EventArgs e)
        {
            controller.GetCard();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            controller.ClearComponent();
        }
    }
}
