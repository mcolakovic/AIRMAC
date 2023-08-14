using KorisnickiInterfejs.GUISession;
using System;
using System.Linq;
using System.Windows.Forms;

namespace KorisnickiInterfejs.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.Text += "     Logged user:  " + Session.Instance.Username;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void addFlightToLogBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FrmLogBook>(new FrmLogBook());
        }

        private void OpenForm<T>(T myForm) where T : Form
        {
            if (!Application.OpenForms.OfType<T>().Any())
            {
                myForm.MdiParent = this;
                myForm.Show();
            }
        }

        private void flightsReviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FrmFlightsReview>(new FrmFlightsReview());
        }

        private void rotablePartCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FrmRotableParts>(new FrmRotableParts());
        }

        private void addComponentToAircraftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FrmInstallToAircraft>(new FrmInstallToAircraft());
        }

        private void removeComponentFromAircraftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FrmRemoveFromAircraft>(new FrmRemoveFromAircraft());
        }

        private void sendComponentToServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FrmSendToService>(new FrmSendToService());
        }

        private void serviceInspectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FrmServiceInspenction>(new FrmServiceInspenction());
        }

        private void returnToStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FrmReturnToStock>(new FrmReturnToStock());
        }

        private void resourceAvailabilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            OpenForm<FrmResourceAvailability>(new FrmResourceAvailability());
        }

        private void changeRotablePartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FrmChangeRotableParts>(new FrmChangeRotableParts());

        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void hoursRemainingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FrmRemainingHours>(new FrmRemainingHours());
        }

        private void cyclesRemainingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FrmRemainingCycles>(new FrmRemainingCycles());
        }

        private void daysRemainingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FrmRemainingDays>(new FrmRemainingDays());
        }

        private void rotablePartHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FrmRotablePartHistory>(new FrmRotablePartHistory());
        }

        private void aircraftSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FrmAircraftSettings>(new FrmAircraftSettings());
        }
    }
}
