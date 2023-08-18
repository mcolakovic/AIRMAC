using KorisnickiInterfejs.GUIController;
using System;
using System.Diagnostics;
using System.Windows.Forms;


namespace KorisnickiInterfejs.Forms
{
    public partial class FrmFlightsReview : Form
    {
        private FlightsReviewController controller;

        public FrmFlightsReview()
        {
            InitializeComponent();
            this.ControlBox = false;
            controller = new FlightsReviewController();
            controller.FormRefresh += Controller_FormRefresh;
            controller.InitData(this);
        }

        private void Controller_FormRefresh(object sender, EventArgs e)
        {
            Invoke(new Action(() =>
            {
                controller.GetFlights();

            }));
         }

        private void btnFlightSearch_Click(object sender, EventArgs e)
        {
            try
            {
                controller.GetFlights();
                controller.ObserverStart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                this.Dispose();
            } 
        }

        private void dgvLogBook_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            controller.SelectFlight(e); 
        }

        private void dpFlightTimeStart_ValueChanged(object sender, System.EventArgs e)
        {
            controller.FlightChanged();
        }

        private void dpFlightTimeStop_ValueChanged(object sender, System.EventArgs e)
        {
            controller.FlightChanged();
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {

            controller.UpdateFlight();
            controller.ClearComponent();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            controller.ClearComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.report();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                controller.ObserverStop();
            }
            catch (Exception)
            {

                Debug.WriteLine("Error");
            }
            finally
            {
                this.Close();
            }
           
            
        }
    }
}
