using KorisnickiInterfejs.GUIController;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace KorisnickiInterfejs.Forms
{
    public partial class FrmChangeRotableParts : Form
    {
        private ChangeRotablePartsController controller;
        public FrmChangeRotableParts()
        {
            InitializeComponent();
            controller = new ChangeRotablePartsController();
            controller.InitData(this);
        }

        private void btnSearchForItem_Click(object sender, EventArgs e)
        {
            controller.GetCard();
        }

        private void btnUpdateRotablePartsItem_Click(object sender, EventArgs e)
        {
            controller.UpdateCard();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            controller.ClearComponent();
        }
    }
}
