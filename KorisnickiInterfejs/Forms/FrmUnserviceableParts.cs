using KorisnickiInterfejs.GUIController;
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
    public partial class FrmUnserviceableParts : Form
    {
        private UnserviceablePartsController controller;
        public FrmUnserviceableParts()
        {
            InitializeComponent();
            controller = new UnserviceablePartsController();
           
        }

          private void dgvUnserviceableParts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            controller.ChoiceItem(e);
        }

        private void FrmUnserviceableParts_Shown(object sender, EventArgs e)
        {
            controller.InitData(this);
        }
    }
}
