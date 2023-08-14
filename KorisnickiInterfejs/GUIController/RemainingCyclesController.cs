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
    public class RemainingCyclesController
    {
        FrmRemainingCycles frmRemainingCycles;
        BindingList<RemainingCycles> stavke = new BindingList<RemainingCycles>();

        internal void InitData(FrmRemainingCycles frmRemainingCycles)
        {
            try
            {
                this.frmRemainingCycles = frmRemainingCycles;
                InitializeComponent();
                frmRemainingCycles.CbAircraft.SelectedIndex = -1;
                frmRemainingCycles.DgvRemainingCycles.DataSource = stavke;
                frmRemainingCycles.DgvRemainingCycles.Columns[0].Visible = false;
                frmRemainingCycles.DgvRemainingCycles.Columns[1].HeaderText = "Part Number";
                frmRemainingCycles.DgvRemainingCycles.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                frmRemainingCycles.DgvRemainingCycles.Columns[1].Width = 100;
                frmRemainingCycles.DgvRemainingCycles.Columns[2].HeaderText = "Serial Number";
                frmRemainingCycles.DgvRemainingCycles.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                frmRemainingCycles.DgvRemainingCycles.Columns[2].Width = 100;
                frmRemainingCycles.DgvRemainingCycles.Columns[3].HeaderText = "Description";
                frmRemainingCycles.DgvRemainingCycles.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                frmRemainingCycles.DgvRemainingCycles.Columns[3].Width = 300;
                frmRemainingCycles.DgvRemainingCycles.Columns[4].HeaderText = "Cycles Limit";
                frmRemainingCycles.DgvRemainingCycles.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                frmRemainingCycles.DgvRemainingCycles.Columns[4].Width = 100;
                frmRemainingCycles.DgvRemainingCycles.Columns[5].HeaderText = "Remaining";
                frmRemainingCycles.DgvRemainingCycles.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                frmRemainingCycles.DgvRemainingCycles.Columns[5].Width = 100;
                frmRemainingCycles.DgvRemainingCycles.Columns[6].HeaderText = "Expire";
                frmRemainingCycles.DgvRemainingCycles.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                frmRemainingCycles.DgvRemainingCycles.Columns[6].Width = 100;
                frmRemainingCycles.DgvRemainingCycles.Columns[7].HeaderText = "Estimated";
                frmRemainingCycles.DgvRemainingCycles.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                frmRemainingCycles.DgvRemainingCycles.Columns[7].Width = 100;
                frmRemainingCycles.DgvRemainingCycles.Columns[8].Visible = false;
                frmRemainingCycles.DgvRemainingCycles.Columns[9].Visible = false;
                frmRemainingCycles.DgvRemainingCycles.Columns[10].Visible = false;
                frmRemainingCycles.DgvRemainingCycles.Columns[11].Visible = false;
                frmRemainingCycles.DgvRemainingCycles.Columns[12].Visible = false;
                frmRemainingCycles.DgvRemainingCycles.Columns[13].Visible = false;
                frmRemainingCycles.DgvRemainingCycles.Columns[14].Visible = false;
                frmRemainingCycles.DgvRemainingCycles.Columns[15].Visible = false;
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da pronađe podatke o avionu i aerodromima!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                frmRemainingCycles.Dispose();
                frmRemainingCycles = null;
            }
        }

        internal void report()
        {
            if (frmRemainingCycles.DgvRemainingCycles.Rows.Count == 0) return;
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Reports\rptRemainingCycles.rpt"));
            ParameterFields paramFields = new ParameterFields();
            ParameterField paramField_AC = new ParameterField();
            ParameterDiscreteValue paramDiscreteValue_AC = new ParameterDiscreteValue();
            paramField_AC.Name = "AC";
            paramDiscreteValue_AC.Value = frmRemainingCycles.CbAircraft.SelectedItem.ToString();
            paramField_AC.CurrentValues.Add(paramDiscreteValue_AC);
            paramFields.Add(paramField_AC);

            ParameterField paramField_AC_CYC = new ParameterField();
            ParameterDiscreteValue paramDiscreteValue_AC_CYC = new ParameterDiscreteValue();
            paramField_AC_CYC.Name = "AC_CYC";
            paramDiscreteValue_AC_CYC.Value = ((Aircraft)frmRemainingCycles.CbAircraft.SelectedItem).LastACCycles;
            paramField_AC_CYC.CurrentValues.Add(paramDiscreteValue_AC_CYC);
            paramFields.Add(paramField_AC_CYC);

            ParameterField paramField_AC_LASTUPDATE = new ParameterField();
            ParameterDiscreteValue paramDiscreteValue_AC_LASTUPDATE = new ParameterDiscreteValue();
            paramField_AC_LASTUPDATE.Name = "AC_LASTUPDATE";
            paramDiscreteValue_AC_LASTUPDATE.Value = ((Aircraft)frmRemainingCycles.CbAircraft.SelectedItem).LastUpdate;
            paramField_AC_LASTUPDATE.CurrentValues.Add(paramDiscreteValue_AC_LASTUPDATE);
            paramFields.Add(paramField_AC_LASTUPDATE);

            ParameterField paramField_ALERT = new ParameterField();
            ParameterDiscreteValue paramDiscreteValue_ALERT = new ParameterDiscreteValue();
            paramField_ALERT.Name = "ALERT";
            paramDiscreteValue_ALERT.Value = Decimal.Parse(frmRemainingCycles.TxtAlert.Text);
            paramField_ALERT.CurrentValues.Add(paramDiscreteValue_ALERT);
            paramFields.Add(paramField_ALERT);

            ParameterField paramField_UTILIZATION = new ParameterField();
            ParameterDiscreteValue paramDiscreteValue_UTILIZATION = new ParameterDiscreteValue();
            paramField_UTILIZATION.Name = "UTILIZATION";
            paramDiscreteValue_UTILIZATION.Value = Decimal.Parse(frmRemainingCycles.TxtUtilisation.Text);
            paramField_UTILIZATION.CurrentValues.Add(paramDiscreteValue_UTILIZATION);
            paramFields.Add(paramField_UTILIZATION);

            BindingList<Domain.Report> rpt = new BindingList<Domain.Report>();



            foreach (Object item in stavke)
            {
                RemainingCycles rc = (RemainingCycles)item;
                Domain.Report r = new Domain.Report
                {
                    STRING_1 = rc.Description,
                    STRING_2 = rc.PartNumber,
                    STRING_3 = rc.SerialNumber,
                    NUMBER_1 = rc.CyclesOperationalLimit,
                    NUMBER_2 = rc.Remaining,
                    NUMBER_3 = rc.ExpireOnCycles,
                    DATE_1 = DateTime.Parse(rc.Estimated.ToString("dd.MM.yyyy"))
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

                RemainingCycles remainingCycles = new RemainingCycles
                {
                    Aircraft = (Aircraft)frmRemainingCycles.CbAircraft.SelectedItem,
                    UtilisationCycles = decimal.Parse(frmRemainingCycles.TxtUtilisation.Text),
                    AlertCycles = decimal.Parse(frmRemainingCycles.TxtAlert.Text)
                };
                stavke = VratiPreostaleCikluse(remainingCycles);
                frmRemainingCycles.DgvRemainingCycles.DataSource = stavke;

                foreach (DataGridViewRow row in frmRemainingCycles.DgvRemainingCycles.Rows)
                {
                    if ((Decimal.Parse(frmRemainingCycles.TxtLastACCycles.Text) + (decimal)0.4 * Decimal.Parse(frmRemainingCycles.TxtAlert.Text)) >= Decimal.Parse(row.Cells[6].Value.ToString()))
                        row.Cells["ExpireOnCycles"].Style = new DataGridViewCellStyle { ForeColor = Color.Red };

                    if (((Decimal.Parse(frmRemainingCycles.TxtLastACCycles.Text) + (decimal)0.4 * Decimal.Parse(frmRemainingCycles.TxtAlert.Text)) < Decimal.Parse(row.Cells[6].Value.ToString())) & ((Decimal.Parse(frmRemainingCycles.TxtLastACCycles.Text) + Decimal.Parse(frmRemainingCycles.TxtAlert.Text)) >= Decimal.Parse(row.Cells[6].Value.ToString())))
                        row.Cells["ExpireOnCycles"].Style = new DataGridViewCellStyle { ForeColor = Color.Magenta };
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
                frmRemainingCycles.Dispose();
                frmRemainingCycles = null;
            }
        }

        private bool Validation()
        {
            if (!Decimal.TryParse(frmRemainingCycles.TxtUtilisation.Text, out _)) return false;
            if (!Decimal.TryParse(frmRemainingCycles.TxtAlert.Text, out _)) return false;
            if (frmRemainingCycles.CbAircraft.SelectedItem == null) return false;
            return true;
        }

        private void InitializeComponent()
        {
            List<Airport> listAirport = UcitajListuAerodroma();
            frmRemainingCycles.CbAirport.DataSource = listAirport.ToList();
            frmRemainingCycles.CbAircraft.DataSource = UcitajListuAviona();
        }

        internal void AircraftChanged()
        {
            AircraftRefresh();
        }

        private void AircraftRefresh()
        {
            if ((Aircraft)frmRemainingCycles.CbAircraft.SelectedItem != null)
            {
                Aircraft aircraft = (Aircraft)frmRemainingCycles.CbAircraft.SelectedItem;
                frmRemainingCycles.TxtLastACHours.Text = aircraft.LastACHours.ToString();
                frmRemainingCycles.TxtLastACCycles.Text = aircraft.LastACCycles.ToString();
                frmRemainingCycles.DpLastUpdate.CustomFormat = "dd/MM/yyyy HH:mm";
                frmRemainingCycles.DpLastUpdate.Value = aircraft.LastUpdate;
                frmRemainingCycles.CbAirport.SelectedItem = aircraft.Airport;
            }
            else
            {
                frmRemainingCycles.TxtLastACHours.Text = string.Empty;
                frmRemainingCycles.TxtLastACCycles.Text = string.Empty;
                frmRemainingCycles.DpLastUpdate.CustomFormat = " ";
                frmRemainingCycles.CbAirport.SelectedIndex = -1;
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

        private BindingList<RemainingCycles> VratiPreostaleCikluse(RemainingCycles remainingCycles)
        {
            return new BindingList<RemainingCycles>(Communication.Instance.SendRequest<List<RemainingCycles>>(Operation.SearchRemainingCycles, remainingCycles));
        }
    }
}
