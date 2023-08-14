using KorisnickiInterfejs.GUIController;
using System;
using System.Windows.Forms;


namespace KorisnickiInterfejs.Forms
{
    public partial class FrmRegistration : Form
    {
        private RegistrationController controller;
        public FrmRegistration()
        {
            controller = new RegistrationController();
            controller.InitData(this);
            InitializeComponent();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            controller.NewRegistration();
            this.DialogResult = DialogResult.OK;
        }
    }
}
