using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Common;
using Domain;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.Forms;
using KorisnickiInterfejs.ServerCommunication;

namespace KorisnickiInterfejs.GUIController
{
    public class AircraftSettingsController
    {
        FrmAircraftSettings frmAircraftSettings;
        BindingList<Aircraft> stavke = new BindingList<Aircraft>();

        internal void InitData(FrmAircraftSettings frmAircraftSettings)
        {
            try
            {
                this.frmAircraftSettings = frmAircraftSettings;
                InitializeComponent();
                frmAircraftSettings.DpLastUpdate.CustomFormat = "dd/MM/yyyy";
                frmAircraftSettings.DpLastUpdate.Value = DateTime.Now;

                frmAircraftSettings.DgvAircrafts.DataSource = stavke;
                frmAircraftSettings.DgvAircrafts.Columns[0].HeaderText = "Registration";
                frmAircraftSettings.DgvAircrafts.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                frmAircraftSettings.DgvAircrafts.Columns[0].Width = 120;
                frmAircraftSettings.DgvAircrafts.Columns[1].HeaderText = "Serial Number";
                frmAircraftSettings.DgvAircrafts.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                frmAircraftSettings.DgvAircrafts.Columns[1].Width = 150;
                frmAircraftSettings.DgvAircrafts.Columns[2].HeaderText = "Last Update";
                frmAircraftSettings.DgvAircrafts.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                frmAircraftSettings.DgvAircrafts.Columns[2].Width = 150;
                frmAircraftSettings.DgvAircrafts.Columns[4].HeaderText = "AC Hours";
                frmAircraftSettings.DgvAircrafts.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                frmAircraftSettings.DgvAircrafts.Columns[4].Width = 100;
                frmAircraftSettings.DgvAircrafts.Columns[5].HeaderText = "AC Cycles";
                frmAircraftSettings.DgvAircrafts.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                frmAircraftSettings.DgvAircrafts.Columns[5].Width = 100;
                frmAircraftSettings.DgvAircrafts.Columns[3].Visible = false;
                frmAircraftSettings.DgvAircrafts.Columns[6].Visible = false;
                frmAircraftSettings.DgvAircrafts.Columns[7].Visible = false;
                frmAircraftSettings.DgvAircrafts.Columns[8].Visible = false;
                frmAircraftSettings.DgvAircrafts.Columns[9].Visible = false;
                frmAircraftSettings.DgvAircrafts.Columns[10].Visible = false;
                frmAircraftSettings.DgvAircrafts.Columns[11].Visible = false;
                DataGridViewComboBoxColumn dgvAirport = new DataGridViewComboBoxColumn
                {
                    HeaderText = "Airport",
                    DataSource = UcitajListuAerodroma().ToList(),
                    DataPropertyName = "Airport",
                    ValueMember = "Self",
                    DisplayMember = "NameOfAirports",
                    DisplayIndex = 3
                };
                frmAircraftSettings.DgvAircrafts.Columns.Add(dgvAirport);
                frmAircraftSettings.DgvAircrafts.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                frmAircraftSettings.DgvAircrafts.Columns[12].Width = 125;
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da pronađe podatke o aerodromima!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                frmAircraftSettings.Dispose();
                frmAircraftSettings = null;
            }
        }

        internal void AddAircraft()
        {
            try
            {
                if (!Validation())
                {
                    MessageBox.Show("Unos podataka nije validan!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    return;
                }
                
                Aircraft ac = DodajAvion();
                stavke = UcitajListuAviona();
                frmAircraftSettings.DgvAircrafts.DataSource = stavke;
                MessageBox.Show("Sistem je dodao avion u bazu aviona!", "Sistem Operation is succesful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                ClearComponent();

            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da sačuva podatke o avionu!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                frmAircraftSettings.Dispose();
                frmAircraftSettings = null;
            }

        }


        private void InitializeComponent()
        {
            List<Airport> listAirport = UcitajListuAerodroma();
            frmAircraftSettings.CbAirport.DataSource = listAirport.ToList();
            frmAircraftSettings.CbAirport.SelectedIndex = -1;
            stavke = UcitajListuAviona();
            frmAircraftSettings.DgvAircrafts.DataSource = stavke;
        }

        private bool Validation()
        {
            if (frmAircraftSettings.TxtRegistrationNumber.Text == string.Empty) return false;
            if (frmAircraftSettings.TxtSerialNumber.Text == string.Empty) return false;
            if (!Decimal.TryParse(frmAircraftSettings.TxtLastACHours.Text, out _)) return false;
            if (!int.TryParse(frmAircraftSettings.TxtLastACCycles.Text, out _)) return false;
            if (frmAircraftSettings.CbAirport.SelectedItem == null) return false;
            return true;
        }

        internal void ClearComponent()
        {
            frmAircraftSettings.TxtRegistrationNumber.Text = string.Empty;
            frmAircraftSettings.TxtSerialNumber.Text = string.Empty;
            frmAircraftSettings.CbAirport.SelectedIndex = -1;
            frmAircraftSettings.DpLastUpdate.CustomFormat = "dd/MM/yyyy";
            frmAircraftSettings.DpLastUpdate.Value = DateTime.Now;
            frmAircraftSettings.TxtLastACCycles.Text = string.Empty;
            frmAircraftSettings.TxtLastACHours.Text = string.Empty;
        }


        private List<Airport> UcitajListuAerodroma()
        {
            return Communication.Instance.SendRequest<List<Airport>>(Operation.GetAirports, new Airport { TableNameIndex = 0, SelectFieldsIndex = 0, ConditionIndex = 0 });
        }

        private BindingList<Aircraft> UcitajListuAviona()
        {
            return new BindingList<Aircraft>(Communication.Instance.SendRequest<List<Aircraft>>(Operation.GetAircrafts, new Aircraft { TableNameIndex = 1, SelectFieldsIndex = 0, ConditionIndex = 0 }));
        }


        private Aircraft DodajAvion()
        {
            Aircraft aircraft = new Aircraft
            {
                Airport = (Airport)frmAircraftSettings.CbAirport.SelectedItem,
                RegistrationNumber = frmAircraftSettings.TxtRegistrationNumber.Text,
                SerialNumber = frmAircraftSettings.TxtSerialNumber.Text,
                LastUpdate = frmAircraftSettings.DpLastUpdate.Value,
                LastACHours = decimal.Parse(frmAircraftSettings.TxtLastACHours.Text),
                LastACCycles = int.Parse(frmAircraftSettings.TxtLastACCycles.Text),
                TableNameIndex = 2
            };
            return Communication.Instance.SendRequest<Aircraft>(Operation.AddAircraft, aircraft);
        }
    }

    
}
