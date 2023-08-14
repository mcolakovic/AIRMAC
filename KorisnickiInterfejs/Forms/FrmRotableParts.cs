using KorisnickiInterfejs.GUIController;
using System;
using System.Windows.Forms;

namespace KorisnickiInterfejs.Forms
{
    public partial class FrmRotableParts : Form
    {
        private RotablePartsController controller;
        public FrmRotableParts()
        {
            InitializeComponent();
            controller = new RotablePartsController();
            controller.InitData(this);
        }

          private void btnAddRotablePartsItem_Click(object sender, EventArgs e)
        {
            controller.SaveCard();
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
