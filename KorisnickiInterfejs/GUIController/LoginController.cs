using System;
using System.Net.Sockets;
using System.Windows.Forms;
using Common;
using Domain;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.Forms;
using KorisnickiInterfejs.GUISession;
using KorisnickiInterfejs.ServerCommunication;

namespace KorisnickiInterfejs.GUIController
{
    public class LoginController
    {
        FrmLogin frmLogin;
        internal void InitData(FrmLogin frmLogin)
        {       
                try
                {
                    this.frmLogin = frmLogin;
                }
                catch (SocketException ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    Environment.Exit(0);
                }
        }

        public void Connect()
        {
            Communication.Instance.Connect();
        }
        
        internal void Login()
        {
            try
            {
                Connect();

                if (!Validation())
                {
                    MessageBox.Show("Unos podataka nije validan!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    return;
                }
                User user = new User
                {
                    Username = frmLogin.TxtUsername.Text,
                    Password = Function.Functions.ComputeSha256Hash(frmLogin.TxtPassword.Text)
                };

                user = VerifikacijaKorisnika(user);
                if (user != null)
                {
                    MessageBox.Show("Korisnik je prijavljen.", "Sistem Operation is succesful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    frmLogin.DialogResult = DialogResult.OK;
                    Session.Instance.Username = frmLogin.TxtUsername.Text;
                }
                else
                {
                    Communication.Instance.CloseConnestion();
                }
                    

            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da pronađe podatke o korisniku!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            catch (SocketException)
            {
                MessageBox.Show("Veza sa serverom ne postoji!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        private User VerifikacijaKorisnika(User user)
        {
            return Communication.Instance.SendRequest<User>(Operation.Login, user);

        }

        private bool Validation()
        {
            if (frmLogin.TxtUsername.Text == string.Empty) return false;
            if (frmLogin.TxtPassword.Text == string.Empty) return false;

            return true;
        }
    }
}
