using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.Forms;
using System;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool cancel = false;
            while (!cancel)
            {
                try
                {
                    FrmLogin frmLogin = new FrmLogin();
                    frmLogin.ShowDialog();
                    if (frmLogin.DialogResult == DialogResult.OK)
                    {
                        frmLogin.Dispose();
                        Application.Run(new FrmMain());
                    }
                    else
                    {
                        cancel = true;
                    }
                }
                catch (ServerCommunicationException ex)
                {
                    MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }

            }

        }
    }
}
