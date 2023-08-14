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
    public partial class FrmServiceableParts : Form
    {
        private ServiceablePartsController controller;
        public FrmServiceableParts()
        {
            InitializeComponent();
            controller = new ServiceablePartsController();
        }

        private void dgvServiceableParts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            controller.ChoiceItem(e);
        }

        private void FrmServiceableParts_Shown(object sender, EventArgs e)
        {
            controller.InitData(this);
        }
    }
}
