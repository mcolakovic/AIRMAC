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
    public class RemainingHoursController
    {
        FrmRemainingHours frmRemainingHours;
        BindingList<RemainingHours> stavke = new BindingList<RemainingHours>();

        internal void InitData(FrmRemainingHours frmRemainingHours)
        {
            try
            {
                this.frmRemainingHours = frmRemainingHours;
                InitializeComponent();
                frmRemainingHours.CbAircraft.SelectedIndex = -1;
                frmRemainingHours.DgvRemainingHours.DataSource = stavke;
                frmRemainingHours.DgvRemainingHours.Columns[0].Visible = false;
                frmRemainingHours.DgvRemainingHours.Columns[1].HeaderText = "Part Number";
                frmRemainingHours.DgvRemainingHours.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                frmRemainingHours.DgvRemainingHours.Columns[1].Width = 100;
                frmRemainingHours.DgvRemainingHours.Columns[2].HeaderText = "Serial Number";
                frmRemainingHours.DgvRemainingHours.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                frmRemainingHours.DgvRemainingHours.Columns[2].Width = 100;
                frmRemainingHours.DgvRemainingHours.Columns[3].HeaderText = "Description";
                frmRemainingHours.DgvRemainingHours.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                frmRemainingHours.DgvRemainingHours.Columns[3].Width = 300;
                frmRemainingHours.DgvRemainingHours.Columns[4].HeaderText = "Hours Limit";
                frmRemainingHours.DgvRemainingHours.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                frmRemainingHours.DgvRemainingHours.Columns[4].Width = 100;
                frmRemainingHours.DgvRemainingHours.Columns[5].HeaderText = "Remaining";
                frmRemainingHours.DgvRemainingHours.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                frmRemainingHours.DgvRemainingHours.Columns[5].Width = 100;
                frmRemainingHours.DgvRemainingHours.Columns[6].HeaderText = "Expire";
                frmRemainingHours.DgvRemainingHours.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                frmRemainingHours.DgvRemainingHours.Columns[6].Width = 100;
                frmRemainingHours.DgvRemainingHours.Columns[7].HeaderText = "Estimated";
                frmRemainingHours.DgvRemainingHours.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                frmRemainingHours.DgvRemainingHours.Columns[7].Width = 100;
                frmRemainingHours.DgvRemainingHours.Columns[8].Visible = false;
                frmRemainingHours.DgvRemainingHours.Columns[9].Visible = false;
                frmRemainingHours.DgvRemainingHours.Columns[10].Visible = false;
                frmRemainingHours.DgvRemainingHours.Columns[11].Visible = false;
                frmRemainingHours.DgvRemainingHours.Columns[12].Visible = false;
                frmRemainingHours.DgvRemainingHours.Columns[13].Visible = false;
                frmRemainingHours.DgvRemainingHours.Columns[14].Visible = false;
                frmRemainingHours.DgvRemainingHours.Columns[15].Visible = false;
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da pronađe podatke o avionu i aerodromima!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                frmRemainingHours.Dispose();
                frmRemainingHours = null;
            }
        }

        internal void report()
        {
                if (frmRemainingHours.DgvRemainingHours.Rows.Count == 0) return;            
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Reports\rptRemainingHours.rpt"));
                ParameterFields paramFields = new ParameterFields();
                ParameterField paramField_AC = new ParameterField();
                ParameterDiscreteValue paramDiscreteValue_AC = new ParameterDiscreteValue();
                paramField_AC.Name = "AC";
                paramDiscreteValue_AC.Value = frmRemainingHours.CbAircraft.SelectedItem.ToString();
                paramField_AC.CurrentValues.Add(paramDiscreteValue_AC);
                paramFields.Add(paramField_AC);
            
                ParameterField paramField_AC_HRS = new ParameterField();
                ParameterDiscreteValue paramDiscreteValue_AC_HRS = new ParameterDiscreteValue();
                paramField_AC_HRS.Name = "AC_HRS";
                paramDiscreteValue_AC_HRS.Value = ((Aircraft)frmRemainingHours.CbAircraft.SelectedItem).LastACHours;
                paramField_AC_HRS.CurrentValues.Add(paramDiscreteValue_AC_HRS);
                paramFields.Add(paramField_AC_HRS);
               
                ParameterField paramField_AC_LASTUPDATE = new ParameterField();
                ParameterDiscreteValue paramDiscreteValue_AC_LASTUPDATE = new ParameterDiscreteValue();
                paramField_AC_LASTUPDATE.Name = "AC_LASTUPDATE";
                paramDiscreteValue_AC_LASTUPDATE.Value = ((Aircraft)frmRemainingHours.CbAircraft.SelectedItem).LastUpdate;
                paramField_AC_LASTUPDATE.CurrentValues.Add(paramDiscreteValue_AC_LASTUPDATE);
                paramFields.Add(paramField_AC_LASTUPDATE);
            
                ParameterField paramField_ALERT = new ParameterField();
                ParameterDiscreteValue paramDiscreteValue_ALERT = new ParameterDiscreteValue();
                paramField_ALERT.Name = "ALERT";
                paramDiscreteValue_ALERT.Value = Decimal.Parse(frmRemainingHours.TxtAlert.Text);
                paramField_ALERT.CurrentValues.Add(paramDiscreteValue_ALERT);
                paramFields.Add(paramField_ALERT);

                ParameterField paramField_UTILIZATION = new ParameterField();
                ParameterDiscreteValue paramDiscreteValue_UTILIZATION = new ParameterDiscreteValue();
                paramField_UTILIZATION.Name = "UTILIZATION";
                paramDiscreteValue_UTILIZATION.Value = Decimal.Parse(frmRemainingHours.TxtUtilisation.Text);
                paramField_UTILIZATION.CurrentValues.Add(paramDiscreteValue_UTILIZATION);
                paramFields.Add(paramField_UTILIZATION);

            BindingList<Domain.Report> rpt = new BindingList<Domain.Report>();



                foreach (Object item in stavke)
                {
                RemainingHours rh = (RemainingHours)item;
                    Domain.Report r = new Domain.Report { 
                        STRING_1 = rh.Description,
                        STRING_2 = rh.PartNumber,
                        STRING_3 = rh.SerialNumber,
                        NUMBER_1 = rh.HoursOperationalLimit,
                        NUMBER_2 = rh.Remaining,
                        NUMBER_3 = rh.ExpireOnHours,
                        DATE_1 = DateTime.Parse(rh.Estimated.ToString("dd.MM.yyyy"))
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

                RemainingHours remainingHours = new RemainingHours
                {
                    Aircraft = (Aircraft)frmRemainingHours.CbAircraft.SelectedItem,
                    UtilisationHours = decimal.Parse(frmRemainingHours.TxtUtilisation.Text),
                    AlertHours = decimal.Parse(frmRemainingHours.TxtAlert.Text)
                };
                stavke = VratiPreostaleSate(remainingHours);
                frmRemainingHours.DgvRemainingHours.DataSource = stavke;

                foreach (DataGridViewRow row in frmRemainingHours.DgvRemainingHours.Rows)
                {
                    if ((Decimal.Parse(frmRemainingHours.TxtLastACHours.Text) + (decimal)0.4 * Decimal.Parse(frmRemainingHours.TxtAlert.Text)) >= Decimal.Parse(row.Cells[6].Value.ToString()))
                        row.Cells["ExpireOnHours"].Style = new DataGridViewCellStyle { ForeColor = Color.Red };

                    if (((Decimal.Parse(frmRemainingHours.TxtLastACHours.Text) + (decimal)0.4 * Decimal.Parse(frmRemainingHours.TxtAlert.Text)) < Decimal.Parse(row.Cells[6].Value.ToString())) & ((Decimal.Parse(frmRemainingHours.TxtLastACHours.Text) + Decimal.Parse(frmRemainingHours.TxtAlert.Text)) >= Decimal.Parse(row.Cells[6].Value.ToString())))
                        row.Cells["ExpireOnHours"].Style = new DataGridViewCellStyle { ForeColor = Color.Magenta };
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
                frmRemainingHours.Dispose();
                frmRemainingHours = null;
            }
        }

        private bool Validation()
        {
            if (!Decimal.TryParse(frmRemainingHours.TxtUtilisation.Text, out _)) return false;
            if (!Decimal.TryParse(frmRemainingHours.TxtAlert.Text, out _)) return false;
            if (frmRemainingHours.CbAircraft.SelectedItem == null) return false;
            return true;
        }

        private void InitializeComponent()
        {
            List<Airport> listAirport = UcitajListuAerodroma();
            frmRemainingHours.CbAirport.DataSource = listAirport.ToList();
            frmRemainingHours.CbAircraft.DataSource = UcitajListuAviona();
        }

        internal void AircraftChanged()
        {
            AircraftRefresh();
        }

        private void AircraftRefresh()
        {
                if ((Aircraft)frmRemainingHours.CbAircraft.SelectedItem != null)
                {
                    Aircraft aircraft = (Aircraft)frmRemainingHours.CbAircraft.SelectedItem;
                    frmRemainingHours.TxtLastACHours.Text = aircraft.LastACHours.ToString();
                    frmRemainingHours.TxtLastACCycles.Text = aircraft.LastACCycles.ToString();
                    frmRemainingHours.DpLastUpdate.CustomFormat = "dd/MM/yyyy HH:mm";
                    frmRemainingHours.DpLastUpdate.Value = aircraft.LastUpdate;
                    frmRemainingHours.CbAirport.SelectedItem = aircraft.Airport;
               }
                else
                {
                    frmRemainingHours.TxtLastACHours.Text = string.Empty;
                    frmRemainingHours.TxtLastACCycles.Text = string.Empty;
                    frmRemainingHours.DpLastUpdate.CustomFormat = " ";
                    frmRemainingHours.CbAirport.SelectedIndex = -1;
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

        private BindingList<RemainingHours> VratiPreostaleSate(RemainingHours remainingHours)
        {
            return new BindingList<RemainingHours>(Communication.Instance.SendRequest<List<RemainingHours>>(Operation.SearchRemainingHours, remainingHours));
        }
    }
}
