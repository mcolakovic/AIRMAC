using KorisnickiInterfejs.GUIController;
using System;
using System.Windows.Forms;

namespace KorisnickiInterfejs.Forms
{
    public partial class FrmLogin : Form
    {
        private LoginController controller;
         public FrmLogin()
        {
            InitializeComponent();
            controller = new LoginController();
            controller.InitData(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            controller.Login();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            FrmRegistration frmRegistration = new FrmRegistration();
            this.Visible = false;
            frmRegistration.ShowDialog();
            frmRegistration.Dispose();
            this.Visible = true;
        }
    }
}
