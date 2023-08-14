using System;
using System.Drawing;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using SQLDependency;
namespace Server
{
    public partial class FrmServer : Form
    {
        private Server server = new Server();
        public FrmServer()
        {
            InitializeComponent();
            server.ServerRefresh += Server_ServerRefresh;
            initGrid();
        }

        private void Server_ServerRefresh(object sender, EventArgs e)
        {    
            Invoke(new Action(() => dgvUser.Rows.Clear()));
            foreach (ClientHandler c in server.Clients)
            {
                Invoke(new Action(() => dgvUser.Rows.Add(c.User.Username, c.User.Firstname, c.User.Lastname, c.User.IPAddress, c.User.LogTime)));
            }
        }

        private void initGrid()
        {
            dgvUser.DataSource = null;
            dgvUser.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvUser.DefaultCellStyle.Font = new Font("Consolas", 9, FontStyle.Italic);
            dgvUser.ColumnCount = 5;
            dgvUser.Columns[0].HeaderText = "Username";
            dgvUser.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvUser.Columns[0].Width = 90;
            dgvUser.Columns[1].HeaderText = "Name";
            dgvUser.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvUser.Columns[1].Width = 100;
            dgvUser.Columns[2].HeaderText = "Surname";
            dgvUser.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvUser.Columns[2].Width = 100;
            dgvUser.Columns[3].HeaderText = "IP Address";
            dgvUser.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvUser.Columns[3].Width = 130;
            dgvUser.Columns[4].HeaderText = "Login At";
            dgvUser.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvUser.Columns[4].Width = 163;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                server.Start();
                Dependency.Instance.start_dependency();
                server.start_Subject();
                lblOnOff.Text = "State of server: Started";
                lblOnOff.ForeColor = Color.Green;
                Thread serverNit = new Thread(server.HandleClients);
                serverNit.Start();
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Server ne moze da se pokrene!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            server.Stop();
            Dependency.Instance.stop_dependency();
            server.stop_Subject();
            lblOnOff.Text = "State of server: Stopped";
            lblOnOff.ForeColor = Color.Red;
        }

        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void dgvUser_SelectionChanged(object sender, EventArgs e)
        {
            dgvUser.ClearSelection();
        }
    }
}
