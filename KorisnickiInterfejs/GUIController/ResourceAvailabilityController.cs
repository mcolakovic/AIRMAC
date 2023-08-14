using Common;
using Domain;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.Forms;
using KorisnickiInterfejs.GUISession;
using KorisnickiInterfejs.ServerCommunication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIController
{
    public class ResourceAvailabilityController
    {
        FrmResourceAvailability frmResourceAvailability;
        BindingList<ResourceAvailability> stavke = new BindingList<ResourceAvailability>();
        bool IsInit = true;

        internal void InitData(FrmResourceAvailability frmResourceAvailability)
        {
            try
            {
                this.frmResourceAvailability = frmResourceAvailability;
                InitializeComponent();
                frmResourceAvailability.CbAircraft.SelectedIndex = -1;
                frmResourceAvailability.DgvResourceAvailability.DataSource = stavke;
                frmResourceAvailability.DgvResourceAvailability.Columns[0].Visible = false;
                frmResourceAvailability.DgvResourceAvailability.Columns[1].HeaderText = "Part Number";
                frmResourceAvailability.DgvResourceAvailability.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                frmResourceAvailability.DgvResourceAvailability.Columns[1].Width = 120;
                frmResourceAvailability.DgvResourceAvailability.Columns[2].HeaderText = "Serial Number";
                frmResourceAvailability.DgvResourceAvailability.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                frmResourceAvailability.DgvResourceAvailability.Columns[2].Width = 110;
                frmResourceAvailability.DgvResourceAvailability.Columns[3].HeaderText = "Description";
                frmResourceAvailability.DgvResourceAvailability.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                frmResourceAvailability.DgvResourceAvailability.Columns[3].Width = 365;
                frmResourceAvailability.DgvResourceAvailability.Columns[4].HeaderText = "Rem Hours";
                frmResourceAvailability.DgvResourceAvailability.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                frmResourceAvailability.DgvResourceAvailability.Columns[4].Width = 60;
                frmResourceAvailability.DgvResourceAvailability.Columns[5].HeaderText = "Rem Cycles";
                frmResourceAvailability.DgvResourceAvailability.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                frmResourceAvailability.DgvResourceAvailability.Columns[5].Width = 60;
                frmResourceAvailability.DgvResourceAvailability.Columns[6].HeaderText = "Rem Dayz";
                frmResourceAvailability.DgvResourceAvailability.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                frmResourceAvailability.DgvResourceAvailability.Columns[6].Width = 60;

                frmResourceAvailability.DgvResourceAvailability.Columns[7].Visible = false;
                frmResourceAvailability.DgvResourceAvailability.Columns[8].Visible = false;
                frmResourceAvailability.DgvResourceAvailability.Columns[9].Visible = false;
                frmResourceAvailability.DgvResourceAvailability.Columns[10].Visible = false;
                frmResourceAvailability.DgvResourceAvailability.Columns[11].Visible = false;
                frmResourceAvailability.DgvResourceAvailability.Columns[12].Visible = false;
                IsInit = false;
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da pronađe podatke o avionu i aerodromima!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                frmResourceAvailability.Dispose();
                frmResourceAvailability = null;
            }
        }

        internal void ChoiceRotablePart(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            frmResourceAvailability.DgvResourceAvailability.Rows[index].Selected = true;
            Session.Instance.CurrentServiceablePartNumber = ((ResourceAvailability)frmResourceAvailability.DgvResourceAvailability.SelectedRows[0].DataBoundItem).PartNumber;
            Session.Instance.CurrentServiceableSerialNumber = ((ResourceAvailability)frmResourceAvailability.DgvResourceAvailability.SelectedRows[0].DataBoundItem).SerialNumber;
            frmResourceAvailability.DialogResult = DialogResult.OK;
        }

        private void InitializeComponent()
        {
                List<Airport> listAirport = UcitajListuAerodroma();
                frmResourceAvailability.CbAirport.DataSource = listAirport.ToList();
                frmResourceAvailability.CbAircraft.DataSource = UcitajListuAviona();   
        }

        internal void AircraftChanged()
        {
            AircraftRefresh();
        }

        private void AircraftRefresh()
        {
            try
            {
                if ((Aircraft)frmResourceAvailability.CbAircraft.SelectedItem != null)
                {
                    Aircraft aircraft = (Aircraft)frmResourceAvailability.CbAircraft.SelectedItem;
                    frmResourceAvailability.TxtLastACHours.Text = aircraft.LastACHours.ToString();
                    frmResourceAvailability.TxtLastACCycles.Text = aircraft.LastACCycles.ToString();
                    frmResourceAvailability.DpLastUpdate.CustomFormat = "dd/MM/yyyy HH:mm";
                    frmResourceAvailability.DpLastUpdate.Value = aircraft.LastUpdate;
                    frmResourceAvailability.CbAirport.SelectedItem = aircraft.Airport;
                    if (!IsInit) frmResourceAvailability.DgvResourceAvailability.DataSource = GetResources();
                    if (!IsInit) MessageBox.Show("Spisak avionskih dijelova sa preostalim resursima", "System Operation is successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
                else
                {
                    frmResourceAvailability.TxtLastACHours.Text = string.Empty;
                    frmResourceAvailability.TxtLastACCycles.Text = string.Empty;
                    frmResourceAvailability.DpLastUpdate.CustomFormat = " ";
                    frmResourceAvailability.CbAirport.SelectedIndex = -1;
                }
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da pronađe podatke o preostalim resursima!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                frmResourceAvailability.Dispose();
                frmResourceAvailability = null;
            }
        }

        internal List<ResourceAvailability> GetResources()
        {
             ResourceAvailability resourceAvailability = new ResourceAvailability
                {
                    Aircraft = new Aircraft
                    {
                        RegistrationNumber = ((Aircraft)frmResourceAvailability.CbAircraft.SelectedItem).RegistrationNumber
                    },
                    TableNameIndex = 0,
                    SelectFieldsIndex = 0,
                    ConditionIndex = 0
                };
                return VratiResurse(resourceAvailability);
        }

        private List<Aircraft> UcitajListuAviona()
        {
            return Communication.Instance.SendRequest<List<Aircraft>>(Operation.GetAircrafts, new Aircraft { TableNameIndex = 1, SelectFieldsIndex = 0, ConditionIndex = 0 });
        }

        private List<Airport> UcitajListuAerodroma()
        {
            return Communication.Instance.SendRequest<List<Airport>>(Operation.GetAirports, new Airport { TableNameIndex = 0, SelectFieldsIndex = 0, ConditionIndex = 0 });
        }

        private List<ResourceAvailability> VratiResurse(ResourceAvailability resourceAvailability)
        {
            return Communication.Instance.SendRequest<List<ResourceAvailability>>(Operation.SearchResourceAvailability, resourceAvailability);
        }

    }
}
