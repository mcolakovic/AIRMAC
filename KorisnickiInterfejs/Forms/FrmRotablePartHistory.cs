using KorisnickiInterfejs.GUIController;
using KorisnickiInterfejs.GUISession;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.Forms
{
    public partial class FrmRotablePartHistory : Form
    {
        private RotablePartHistoryController controller;
        public FrmRotablePartHistory()
        {
            InitializeComponent();
            controller = new RotablePartHistoryController();
            controller.InitData(this);
        }

        private void btnCardHistory_Click(object sender, EventArgs e)
        {
            controller.GetCard();
        }
    }
}
