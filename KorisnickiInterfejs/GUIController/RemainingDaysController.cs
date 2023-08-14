using Common;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Domain;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.Forms;
using KorisnickiInterfejs.GUISession;
using KorisnickiInterfejs.ServerCommunication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIController
{
    public class RemainingDaysController
    {
        FrmRemainingDays frmRemainingDays;
        BindingList<RemainingDays> stavke = new BindingList<RemainingDays>();

        internal void InitData(FrmRemainingDays frmRemainingDays)
        {
            try
            {
                this.frmRemainingDays = frmRemainingDays;
                InitializeComponent();
                frmRemainingDays.CbAircraft.SelectedIndex = -1;
                frmRemainingDays.DgvRemainingDays.DataSource = stavke;
                frmRemainingDays.DgvRemainingDays.Columns[0].Visible = false;
                frmRemainingDays.DgvRemainingDays.Columns[1].HeaderText = "Part Number";
                frmRemainingDays.DgvRemainingDays.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                frmRemainingDays.DgvRemainingDays.Columns[1].Width = 100;
                frmRemainingDays.DgvRemainingDays.Columns[2].HeaderText = "Serial Number";
                frmRemainingDays.DgvRemainingDays.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                frmRemainingDays.DgvRemainingDays.Columns[2].Width = 100;
                frmRemainingDays.DgvRemainingDays.Columns[3].HeaderText = "Description";
                frmRemainingDays.DgvRemainingDays.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                frmRemainingDays.DgvRemainingDays.Columns[3].Width = 400;
                frmRemainingDays.DgvRemainingDays.Columns[4].HeaderText = "Days Limit";
                frmRemainingDays.DgvRemainingDays.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                frmRemainingDays.DgvRemainingDays.Columns[4].Width = 100;
                frmRemainingDays.DgvRemainingDays.Columns[5].HeaderText = "Remaining";
                frmRemainingDays.DgvRemainingDays.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                frmRemainingDays.DgvRemainingDays.Columns[5].Width = 100;
                frmRemainingDays.DgvRemainingDays.Columns[6].HeaderText = "Expire At date";
                frmRemainingDays.DgvRemainingDays.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                frmRemainingDays.DgvRemainingDays.Columns[6].Width = 100;
                frmRemainingDays.DgvRemainingDays.Columns[7].Visible = false;
                frmRemainingDays.DgvRemainingDays.Columns[8].Visible = false;
                frmRemainingDays.DgvRemainingDays.Columns[9].Visible = false;
                frmRemainingDays.DgvRemainingDays.Columns[10].Visible = false;
                frmRemainingDays.DgvRemainingDays.Columns[11].Visible = false;
                frmRemainingDays.DgvRemainingDays.Columns[12].Visible = false;
                frmRemainingDays.DgvRemainingDays.Columns[13].Visible = false;
             }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da pronađe podatke o avionu i aerodromima!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                frmRemainingDays.Dispose();
                frmRemainingDays = null;
            }
        }

        internal void report()
        {
            if (frmRemainingDays.DgvRemainingDays.Rows.Count == 0) return;
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Reports\rptRemainingDays.rpt"));
            ParameterFields paramFields = new ParameterFields();
            ParameterField paramField_AC = new ParameterField();
            ParameterDiscreteValue paramDiscreteValue_AC = new ParameterDiscreteValue();
            paramField_AC.Name = "AC";
            paramDiscreteValue_AC.Value = frmRemainingDays.CbAircraft.SelectedItem.ToString();
            paramField_AC.CurrentValues.Add(paramDiscreteValue_AC);
            paramFields.Add(paramField_AC);

            ParameterField paramField_AC_HRS = new ParameterField();
            ParameterDiscreteValue paramDiscreteValue_AC_HRS = new ParameterDiscreteValue();
            paramField_AC_HRS.Name = "AC_HRS";
            paramDiscreteValue_AC_HRS.Value = ((Aircraft)frmRemainingDays.CbAircraft.SelectedItem).LastACHours;
            paramField_AC_HRS.CurrentValues.Add(paramDiscreteValue_AC_HRS);
            paramFields.Add(paramField_AC_HRS);

            ParameterField paramField_AC_CYC = new ParameterField();
            ParameterDiscreteValue paramDiscreteValue_AC_CYC = new ParameterDiscreteValue();
            paramField_AC_CYC.Name = "AC_CYC";
            paramDiscreteValue_AC_CYC.Value = ((Aircraft)frmRemainingDays.CbAircraft.SelectedItem).LastACCycles;
            paramField_AC_CYC.CurrentValues.Add(paramDiscreteValue_AC_CYC);
            paramFields.Add(paramField_AC_CYC);

            ParameterField paramField_AC_LASTUPDATE = new ParameterField();
            ParameterDiscreteValue paramDiscreteValue_AC_LASTUPDATE = new ParameterDiscreteValue();
            paramField_AC_LASTUPDATE.Name = "AC_LASTUPDATE";
            paramDiscreteValue_AC_LASTUPDATE.Value = ((Aircraft)frmRemainingDays.CbAircraft.SelectedItem).LastUpdate;
            paramField_AC_LASTUPDATE.CurrentValues.Add(paramDiscreteValue_AC_LASTUPDATE);
            paramFields.Add(paramField_AC_LASTUPDATE);

            ParameterField paramField_ALERT = new ParameterField();
            ParameterDiscreteValue paramDiscreteValue_ALERT = new ParameterDiscreteValue();
            paramField_ALERT.Name = "ALERT";
            paramDiscreteValue_ALERT.Value = Decimal.Parse(frmRemainingDays.TxtAlert.Text);
            paramField_ALERT.CurrentValues.Add(paramDiscreteValue_ALERT);
            paramFields.Add(paramField_ALERT);

           

            BindingList<Domain.Report> rpt = new BindingList<Domain.Report>();



            foreach (Object item in stavke)
            {
                RemainingDays rh = (RemainingDays)item;
                Domain.Report r = new Domain.Report
                {
                    STRING_1 = rh.Description,
                    STRING_2 = rh.PartNumber,
                    STRING_3 = rh.SerialNumber,
                    NUMBER_1 = rh.DaysOperationalLimit,
                    NUMBER_2 = rh.Remaining,
                    DATE_1 = DateTime.Parse(rh.ExpireAtDate.ToString("dd.MM.yyyy"))
                };
                rpt.Add(r);
            }

            cryRpt.SetDataSource(rpt);
            Forms.Report frmReport = new Forms.Report();
            frmReport.CrystalReportViewer1.ReportSource = cryRpt;
            frmReport.CrystalReportViewer1.ParameterFieldInfo = paramFields;
            frmReport.CrystalReportViewer1.Refresh();
            frmReport.Show();

        }

        internal void SearchREM()
        {
            try
            {
                if (!Validation())
                {
                    MessageBox.Show("Unos podataka nije validan!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    return;
                }

                RemainingDays remainingDays = new RemainingDays
                {
                    Aircraft = (Aircraft)frmRemainingDays.CbAircraft.SelectedItem,
                    AlertDays = decimal.Parse(frmRemainingDays.TxtAlert.Text)
                };
                stavke = VratiPreostaleDane(remainingDays);
                frmRemainingDays.DgvRemainingDays.DataSource = stavke;

                foreach (DataGridViewRow row in frmRemainingDays.DgvRemainingDays.Rows)
                {
                    if (
                        (DateTime.Parse(row.Cells[6].Value.ToString()) >= ((Aircraft)frmRemainingDays.CbAircraft.SelectedItem).LastUpdate)
                        &
                        (DateTime.Parse(row.Cells[6].Value.ToString()) < ((Aircraft)frmRemainingDays.CbAircraft.SelectedItem).LastUpdate.AddDays((double)0.4 * Double.Parse(frmRemainingDays.TxtAlert.Text))))
                        row.Cells["ExpireAtDate"].Style = new DataGridViewCellStyle { ForeColor = Color.Red };
                    if (
                        (DateTime.Parse(row.Cells[6].Value.ToString()) > ((Aircraft)frmRemainingDays.CbAircraft.SelectedItem).LastUpdate.AddDays((double)0.4 * Double.Parse(frmRemainingDays.TxtAlert.Text)))
                        &
                        (DateTime.Parse(row.Cells[6].Value.ToString()) < ((Aircraft)frmRemainingDays.CbAircraft.SelectedItem).LastUpdate.AddDays(Double.Parse(frmRemainingDays.TxtAlert.Text))))
                        row.Cells["ExpireAtDate"].Style = new DataGridViewCellStyle { ForeColor = Color.Magenta };
                }
                MessageBox.Show("Sistem je našao sledeće dijelove!", "System Operation is successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da pronađe podatke o preostalim resursima", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                frmRemainingDays.Dispose();
                frmRemainingDays = null;
            }
        }

        private bool Validation()
        {
            if (!Decimal.TryParse(frmRemainingDays.TxtAlert.Text, out _)) return false;
            if (frmRemainingDays.CbAircraft.SelectedItem == null) return false;
            return true;
        }

        private void InitializeComponent()
        {
            List<Airport> listAirport = UcitajListuAerodroma();
            frmRemainingDays.CbAirport.DataSource = listAirport.ToList();
            frmRemainingDays.CbAircraft.DataSource = UcitajListuAviona();
        }

        internal void AircraftChanged()
        {
            AircraftRefresh();
        }

        private void AircraftRefresh()
        {
            if ((Aircraft)frmRemainingDays.CbAircraft.SelectedItem != null)
            {
                Aircraft aircraft = (Aircraft)frmRemainingDays.CbAircraft.SelectedItem;
                frmRemainingDays.TxtLastACHours.Text = aircraft.LastACHours.ToString();
                frmRemainingDays.TxtLastACCycles.Text = aircraft.LastACCycles.ToString();
                frmRemainingDays.DpLastUpdate.CustomFormat = "dd/MM/yyyy HH:mm";
                frmRemainingDays.DpLastUpdate.Value = aircraft.LastUpdate;
                frmRemainingDays.CbAirport.SelectedItem = aircraft.Airport;
            }
            else
            {
                frmRemainingDays.TxtLastACHours.Text = string.Empty;
                frmRemainingDays.TxtLastACCycles.Text = string.Empty;
                frmRemainingDays.DpLastUpdate.CustomFormat = " ";
                frmRemainingDays.CbAirport.SelectedIndex = -1;
            }
        }

        private List<Aircraft> UcitajListuAviona()
        {
            return Communication.Instance.SendRequest<List<Aircraft>>(Operation.GetAircrafts, new Aircraft { TableNameIndex = 1, SelectFieldsIndex = 0, ConditionIndex = 0 });
        }

        private List<Airport> UcitajListuAerodroma()
        {
            return Communication.Instance.SendRequest<List<Airport>>(Operation.GetAirports, new Airport { TableNameIndex = 0, SelectFieldsIndex = 0, ConditionIndex = 0 });
        }

        private BindingList<RemainingDays> VratiPreostaleDane(RemainingDays remainingDays)
        {
            return new BindingList<RemainingDays>(Communication.Instance.SendRequest<List<RemainingDays>>(Operation.SearchRemainingDays, remainingDays));
        }
    }
}
