using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Domain;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.Forms;
using System.Text.RegularExpressions;
using KorisnickiInterfejs.GUISession;
using KorisnickiInterfejs.ServerCommunication;
using System.Net.Sockets;

namespace KorisnickiInterfejs.GUIController
{
    public class RegistrationController
    {
        FrmRegistration frmRegistration;
        internal void InitData(FrmRegistration frmRegistration)
        {
            try
            {
                this.frmRegistration = frmRegistration;
         
            }
         catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                frmRegistration.Dispose();
                frmRegistration = null;
            }
        }

        public void Connect()
        {
            Communication.Instance.Connect();
        }

        private bool Validation()
        {
            if (frmRegistration.TxtUsername.Text == string.Empty) return false;
            if (frmRegistration.TxtPassword.Text == string.Empty) return false;
            if (frmRegistration.TxtFirstName.Text == string.Empty) return false;
            if (frmRegistration.TxtLastName.Text == string.Empty) return false;
            if (frmRegistration.TxtAddress.Text == string.Empty) return false;
            if (frmRegistration.TxtPhone.Text == string.Empty) return false;
            if (frmRegistration.CbCountry.SelectedItem == null) return false;
            Regex validatePhoneNumberRegex = new Regex("^\\+[1-9][0-9]{7,14}||0[0-9]{7,14}$");
            if (!validatePhoneNumberRegex.IsMatch(frmRegistration.TxtPhone.Text)) return false;
            return true;
        }

        internal void NewRegistration()
        {
            try
            {
                Connect();

                if (!Validation())
                {
                    MessageBox.Show("Unos podataka nije validan!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    return;
                }
                User user = ZapamtiRegistraciju();
                MessageBox.Show("Sistem je dodao korisnika u bazu korisnika!", "Sistem Operation is succesful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da sačuva podatke o novoj registraciji!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                frmRegistration.Dispose();
                frmRegistration = null;
            }
            catch (SocketException)
            {
                MessageBox.Show("Veza sa serverom ne postoji!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }


        private User ZapamtiRegistraciju()
        {
            User user = new User
            {
                Username = frmRegistration.TxtUsername.Text,
                Password = Function.Functions.ComputeSha256Hash(frmRegistration.TxtPassword.Text),
                Firstname = frmRegistration.TxtFirstName.Text,
                Lastname = frmRegistration.TxtLastName.Text,
                Address = frmRegistration.TxtAddress.Text,
                Phone = frmRegistration.TxtPhone.Text,
                Country = frmRegistration.CbCountry.SelectedItem.ToString(),
                TableNameIndex = 1
            };
            return Communication.Instance.SendRequest<User>(Operation.AddUser, user);
        }
    }
}
