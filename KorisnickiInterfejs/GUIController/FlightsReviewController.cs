using Common;
using Domain;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.Forms;
using KorisnickiInterfejs.ServerCommunication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Serialization.Formatters;
using System.Collections;
using ObrerverPatern.Objects;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace KorisnickiInterfejs.GUIController
   
{
    public class FlightsReviewController
    {
        FrmFlightsReview flightsReview;
        public event EventHandler FormRefresh;

        internal BindingList<LogBook> stavke = new BindingList<LogBook>();
        List<Airport> listAirport;
        bool isInit = true;
        private TcpChannel chan = null;
        private ServerObject Server = null;
        private ClientObject Client = null;

        internal void InitData(FrmFlightsReview flightsReview)
        {
            try
            {
                this.flightsReview = flightsReview;
                flightsReview.DpFlightTimeStart.CustomFormat = " ";
                flightsReview.DpFlightTimeStop.CustomFormat = " ";
                InitializeComponent();
                flightsReview.CbAircraft.SelectedIndex = -1;
                flightsReview.DgvLogBook.DataSource = stavke;
                flightsReview.DgvLogBook.Columns[0].Visible = false;
                flightsReview.DgvLogBook.Columns[1].Visible = false;
                flightsReview.DgvLogBook.Columns[2].HeaderText = "Flight Number";
                flightsReview.DgvLogBook.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                flightsReview.DgvLogBook.Columns[2].Width = 60;
                flightsReview.DgvLogBook.Columns[3].Visible = false;
                flightsReview.DgvLogBook.Columns[4].Visible = false;
                flightsReview.DgvLogBook.Columns[5].Visible = false;
                flightsReview.DgvLogBook.Columns[6].HeaderText = "Flight Time Start";
                flightsReview.DgvLogBook.Columns[6].Width = 150;
                flightsReview.DgvLogBook.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                flightsReview.DgvLogBook.Columns[7].HeaderText = "Flight Time Stop";
                flightsReview.DgvLogBook.Columns[7].Width = 150;
                flightsReview.DgvLogBook.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                flightsReview.DgvLogBook.Columns[8].HeaderText = "Previous Hours";
                flightsReview.DgvLogBook.Columns[8].Width = 80;
                flightsReview.DgvLogBook.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                flightsReview.DgvLogBook.Columns[9].HeaderText = "Previous Cycles";
                flightsReview.DgvLogBook.Columns[9].Width = 80;
                flightsReview.DgvLogBook.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                flightsReview.DgvLogBook.Columns[10].HeaderText = "Next Hours";
                flightsReview.DgvLogBook.Columns[10].Width = 80;
                flightsReview.DgvLogBook.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                flightsReview.DgvLogBook.Columns[11].HeaderText = "Next Cycles";
                flightsReview.DgvLogBook.Columns[11].Width = 60;
                flightsReview.DgvLogBook.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                flightsReview.DgvLogBook.Columns[12].Visible = false;
                flightsReview.DgvLogBook.Columns[13].Visible = false;
                flightsReview.DgvLogBook.Columns[14].Visible = false;
                flightsReview.DgvLogBook.Columns[15].Visible = false;
                flightsReview.DgvLogBook.Columns[16].Visible = false;
                flightsReview.DgvLogBook.Columns[17].Visible = false;

                DataGridViewComboBoxColumn dgvAirportFROM = new DataGridViewComboBoxColumn
                {
                    HeaderText = "FROM",
                    DataSource = listAirport.ToList(),
                    DataPropertyName = "Airport_FROM",
                    ValueMember = "Self",
                    DisplayMember = "NameOfAirports",
                    DisplayIndex = 3
                };
                flightsReview.DgvLogBook.Columns.Add(dgvAirportFROM);
                flightsReview.DgvLogBook.Columns[18].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                flightsReview.DgvLogBook.Columns[18].Width = 125;


                DataGridViewComboBoxColumn dgvAirportTO = new DataGridViewComboBoxColumn
                {
                    HeaderText = "TO",
                    DataSource = listAirport.ToList(),
                    DataPropertyName = "Airport_TO",
                    ValueMember = "Self",
                    DisplayMember = "NameOfAirports",
                    DisplayIndex = 4
                };
                flightsReview.DgvLogBook.Columns.Add(dgvAirportTO);
                flightsReview.DgvLogBook.Columns[19].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                flightsReview.DgvLogBook.Columns[19].Width = 125;

            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da pronađe podatke o avionu i aerodromima!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                flightsReview.Dispose();
                flightsReview = null;
            }
        }

        internal void ClearComponent()
        {
            flightsReview.TxtIDLogBook.Text = string.Empty;
            flightsReview.TxtFlightNumber.Text = string.Empty;
            flightsReview.CbAirportFrom.SelectedIndex = -1;
            flightsReview.CbAirportTo.SelectedIndex = -1;
            flightsReview.DpFlightTimeStart.CustomFormat = " ";
            flightsReview.DpFlightTimeStop.CustomFormat = " ";
            flightsReview.TxtDuration.Text = string.Empty;
            flightsReview.BtnUpdate.Enabled = false;
            flightsReview.BtnCancel.Enabled = false;
            flightsReview.DpFlightTimeStart.Enabled = false;
            flightsReview.DpFlightTimeStop.Enabled = false;
            flightsReview.TxtFlightNumber.Enabled = false;
            isInit = true;
        }

        internal void SelectFlight(DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                {
                    return;
                }

                int index = e.RowIndex;
                flightsReview.DgvLogBook.Rows[index].Selected = true;
                LogBook lb = PronadjiLet();

                flightsReview.TxtIDLogBook.Text = lb.ID_LogBook.ToString();
                flightsReview.TxtFlightNumber.Text = lb.FlightNumber.ToString();
                flightsReview.CbAirportFrom.SelectedItem = lb.Airport_FROM;
                flightsReview.CbAirportTo.SelectedItem = lb.Airport_TO;
                flightsReview.DpFlightTimeStart.CustomFormat = "dd/MM/yyyy HH:mm";
                flightsReview.DpFlightTimeStop.CustomFormat = "dd/MM/yyyy HH:mm";
                flightsReview.DpFlightTimeStart.Value = lb.FlightTimeStart;
                flightsReview.DpFlightTimeStop.Value = lb.FlightTimeStop;
                flightsReview.BtnUpdate.Enabled = true;
                flightsReview.BtnCancel.Enabled = true;
                flightsReview.DpFlightTimeStart.Enabled = true;
                flightsReview.DpFlightTimeStop.Enabled = true;
                flightsReview.TxtFlightNumber.Enabled = true;
                isInit = false;
                FlightChanged();
                MessageBox.Show("Sistem je našao podatke o konkretnom letu!", "System Operation is successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da nađe podatke o konkretnom letu!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                flightsReview.Dispose();
                flightsReview = null;
            }
        }

        internal void GetFlights()
        {
            try
            {
                stavke = UcitajListuLetova();
                flightsReview.DgvLogBook.DataSource = stavke;
                if (isInit) MessageBox.Show("Sistem je našao sledeće realizovane letove!", "System Operation is successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da pronađe podatke o realizovanim letovima!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                throw new Exception(ex.Message);
                //MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                //flightsReview.Dispose();
                //flightsReview = null;
            }
        }

        internal void UpdateFlight()
        {
            try
            {
                if (!Validation())
                {
                    MessageBox.Show("Unos podataka nije validan!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    return;
                }
                AzurirajLet();
                GetFlights();
                MessageBox.Show("Sistem je ažurirao let u evidenciji realizovanih letova!", "System Operation is successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da sačuva ažurirane podatke o realizovanom letu!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                flightsReview.Dispose();
                flightsReview = null;
            }
        }

        private void InitializeComponent()
        {
            listAirport = UcitajListuAerodroma();
            flightsReview.CbAircraft.DataSource = UcitajListuAviona();
            flightsReview.CbAirportFrom.DataSource = listAirport.ToList();
            flightsReview.CbAirportTo.DataSource = listAirport.ToList();
            flightsReview.CbAirportFrom.SelectedIndex = -1;
            flightsReview.CbAirportTo.SelectedIndex = -1;
        }

        internal void FlightChanged()
        {
            try
            {
                TimeSpan ts = DateTime.Parse(flightsReview.DpFlightTimeStop.Text) - DateTime.Parse(flightsReview.DpFlightTimeStart.Text);
                double differenceInMinuts = ts.TotalMinutes;
                if (differenceInMinuts > 0)
                    flightsReview.TxtDuration.Text = differenceInMinuts.ToString();
                else
                    flightsReview.TxtDuration.Text = string.Empty;
            }
            catch (Exception)
            {
                flightsReview.TxtDuration.Text = string.Empty;
            }
        }

        private bool Validation()
        {
            if (!DateTime.TryParse(flightsReview.DpFlightTimeStart.Text, out _)) return false;
            if (!DateTime.TryParse(flightsReview.DpFlightTimeStop.Text, out _)) return false;
            if (!int.TryParse(flightsReview.TxtDuration.Text, out _)) return false;
            if (flightsReview.DpFlightTimeStart.Value > flightsReview.DpFlightTimeStop.Value) return false;
            if (flightsReview.TxtFlightNumber.Text == string.Empty) return false;
            return true;
        }

        private List<Aircraft> UcitajListuAviona()
        {
            return Communication.Instance.SendRequest<List<Aircraft>>(Operation.GetAircrafts, new Aircraft { TableNameIndex = 1, SelectFieldsIndex = 0, ConditionIndex = 0 });
        }

        private List<Airport> UcitajListuAerodroma()
        {
            return Communication.Instance.SendRequest<List<Airport>>(Operation.GetAirports, new Airport { TableNameIndex = 0, SelectFieldsIndex = 0, ConditionIndex = 0 });
        }

        private BindingList<LogBook> UcitajListuLetova()
        {
            return new BindingList<LogBook>(Communication.Instance.SendRequest<List<LogBook>>(Operation.GetLogBook, new LogBook { Aircraft = ((Aircraft)flightsReview.CbAircraft.SelectedItem), FlightTimeStart = DateTime.Parse(flightsReview.DpFlightTimeFROM.Text), FlightTimeStop = DateTime.Parse(flightsReview.DpFlightTimeTO.Text), TableNameIndex = 0, SelectFieldsIndex = 0, ConditionIndex = 0 }));
        }

        private LogBook PronadjiLet()
        {
            return Communication.Instance.SendRequest<LogBook>(Operation.GetFlight, new LogBook { ID_LogBook = ((LogBook)flightsReview.DgvLogBook.SelectedRows[0].DataBoundItem).ID_LogBook, ConditionIndex = 1 });
        }

        private void AzurirajLet()
        {
            TimeSpan ts = DateTime.Parse(flightsReview.DpFlightTimeStop.Text) - DateTime.Parse(flightsReview.DpFlightTimeStart.Text);
            decimal difference = (int)(ts.TotalMinutes / 60) + (decimal)(ts.TotalMinutes % 60) / 100;

            LogBook lb = new LogBook
            {
                ID_LogBook = Decimal.Parse(flightsReview.TxtIDLogBook.Text),
                FlightNumber = flightsReview.TxtFlightNumber.Text,
                FlightTimeStart = DateTime.Parse(flightsReview.DpFlightTimeStart.Text),
                FlightTimeStop = DateTime.Parse(flightsReview.DpFlightTimeStop.Text),
                ConditionIndex = 1
            };
            Communication.Instance.SendRequest<LogBook>(Operation.UpdateLogBook, lb);
        }

        internal void ObserverStart()
        {
            if (chan == null)
            {
                BinaryServerFormatterSinkProvider provider = new BinaryServerFormatterSinkProvider();
                provider.TypeFilterLevel = TypeFilterLevel.Full;
                IDictionary props = new Hashtable();
                props["port"] = 0;
                chan = new TcpChannel(props, null, provider);
                ChannelServices.RegisterChannel(chan,false);
                string url = String.Format("tcp://{0}:9000/Server", "127.0.0.1");
                Server = (ServerObject)Activator.GetObject(typeof(ServerObject), url);
                Client = new ClientObject();
                Client.ServerRefresh += Client_ServerRefresh;
                Server.Attach(Client);
            }
        }

        internal void ObserverStop()
        {
            if(Client != null)
            {
                Server.Detach(Client);
                ChannelServices.UnregisterChannel(chan);
                chan = null;
            }
        }

        private void Client_ServerRefresh(object sender, EventArgs e)
        {
            FormRefresh?.Invoke(this, EventArgs.Empty);
  
        }

        public void report()
        {
            if (flightsReview.DgvLogBook.Rows.Count == 0) return;
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Reports\rptLogBook.rpt"));
            ParameterFields paramFields = new ParameterFields();
            ParameterField paramField_AC = new ParameterField();
            ParameterDiscreteValue paramDiscreteValue_AC = new ParameterDiscreteValue();
            paramField_AC.Name = "AC";
            paramDiscreteValue_AC.Value = flightsReview.CbAircraft.SelectedItem.ToString();
            paramField_AC.CurrentValues.Add(paramDiscreteValue_AC);
            paramFields.Add(paramField_AC);

            ParameterField paramField_AC_HRS = new ParameterField();
            ParameterDiscreteValue paramDiscreteValue_AC_HRS = new ParameterDiscreteValue();
            paramField_AC_HRS.Name = "AC_HRS";
            paramDiscreteValue_AC_HRS.Value = ((Aircraft)flightsReview.CbAircraft.SelectedItem).LastACHours;
            paramField_AC_HRS.CurrentValues.Add(paramDiscreteValue_AC_HRS);
            paramFields.Add(paramField_AC_HRS);

            ParameterField paramField_AC_CYC = new ParameterField();
            ParameterDiscreteValue paramDiscreteValue_AC_CYC = new ParameterDiscreteValue();
            paramField_AC_CYC.Name = "AC_CYC";
            paramDiscreteValue_AC_CYC.Value = ((Aircraft)flightsReview.CbAircraft.SelectedItem).LastACCycles;
            paramField_AC_CYC.CurrentValues.Add(paramDiscreteValue_AC_CYC);
            paramFields.Add(paramField_AC_CYC);

            ParameterField paramField_AC_LASTUPDATE = new ParameterField();
            ParameterDiscreteValue paramDiscreteValue_AC_LASTUPDATE = new ParameterDiscreteValue();
            paramField_AC_LASTUPDATE.Name = "AC_LASTUPDATE";
            paramDiscreteValue_AC_LASTUPDATE.Value = ((Aircraft)flightsReview.CbAircraft.SelectedItem).LastUpdate;
            paramField_AC_LASTUPDATE.CurrentValues.Add(paramDiscreteValue_AC_LASTUPDATE);
            paramFields.Add(paramField_AC_LASTUPDATE);

            BindingList<Domain.Report> rpt = new BindingList<Domain.Report>();


            foreach (Object item in stavke)
            {
                LogBook rh = (LogBook)item;
                Domain.Report r = new Domain.Report
                {
                    STRING_1 = rh.FlightNumber,
                    STRING_2 = listAirport.SingleOrDefault(p => p.ID_Airport == rh.Airport_FROM.ID_Airport).NameOfAirports,
                    STRING_3 = listAirport.SingleOrDefault(p => p.ID_Airport == rh.Airport_TO.ID_Airport).NameOfAirports,
                    DATE_1 = DateTime.Parse(rh.FlightTimeStart.ToString("dd/MM/yyyy HH:mm")),
                    DATE_2 = DateTime.Parse(rh.FlightTimeStop.ToString("dd/MM/yyyy HH:mm")),
                    NUMBER_1 = rh.PreviousACHours,
                    NUMBER_2 = rh.PreviousACCycles,
                    NUMBER_3 = rh.NextACHours,
                    NUMBER_4 = rh.NextACCycles,
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
       
    }
}






    
