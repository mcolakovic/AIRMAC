﻿using KorisnickiInterfejs.GUIController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.Forms
{
    public partial class FrmSendToService : Form
    {
        private SendToServiceController controller;
        public FrmSendToService()
        {
            InitializeComponent();
            controller = new SendToServiceController();
            controller.InitData(this);

        }

        private void btnSearchForItem_Click(object sender, EventArgs e)
        {
            controller.GetCard();
        }

        private void btnAddRotablePartsItem_Click(object sender, EventArgs e)
        {
            controller.SendToService();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            controller.ClearComponent();
        }
    }
}
