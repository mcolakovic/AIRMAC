namespace KorisnickiInterfejs.Forms
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aircraftSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFlightToLogBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightsReviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.rotablePartCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeRotablePartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addComponentToAircraftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeComponentFromAircraftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendComponentToServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceInspectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.resourceAvailabilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remainingReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoursRemainingReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyclesRemainingReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daysRemainingReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotablePartHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logBookToolStripMenuItem,
            this.exitApplicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1025, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logBookToolStripMenuItem
            // 
            this.logBookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aircraftSettingsToolStripMenuItem,
            this.addFlightToLogBookToolStripMenuItem,
            this.flightsReviewToolStripMenuItem,
            this.toolStripSeparator1,
            this.rotablePartCardToolStripMenuItem,
            this.changeRotablePartsToolStripMenuItem,
            this.toolStripSeparator2,
            this.addComponentToAircraftToolStripMenuItem,
            this.removeComponentFromAircraftToolStripMenuItem,
            this.sendComponentToServiceToolStripMenuItem,
            this.serviceInspectionToolStripMenuItem,
            this.returnToStockToolStripMenuItem,
            this.toolStripSeparator3,
            this.resourceAvailabilityToolStripMenuItem,
            this.remainingReportsToolStripMenuItem,
            this.rotablePartHistoryToolStripMenuItem});
            this.logBookToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBookToolStripMenuItem.Name = "logBookToolStripMenuItem";
            this.logBookToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.logBookToolStripMenuItem.Text = "LogBook";
            // 
            // aircraftSettingsToolStripMenuItem
            // 
            this.aircraftSettingsToolStripMenuItem.Name = "aircraftSettingsToolStripMenuItem";
            this.aircraftSettingsToolStripMenuItem.Size = new System.Drawing.Size(362, 26);
            this.aircraftSettingsToolStripMenuItem.Text = "Aircraft Settings";
            this.aircraftSettingsToolStripMenuItem.Click += new System.EventHandler(this.aircraftSettingsToolStripMenuItem_Click);
            // 
            // addFlightToLogBookToolStripMenuItem
            // 
            this.addFlightToLogBookToolStripMenuItem.Name = "addFlightToLogBookToolStripMenuItem";
            this.addFlightToLogBookToolStripMenuItem.Size = new System.Drawing.Size(362, 26);
            this.addFlightToLogBookToolStripMenuItem.Text = "Add Flight to LogBook";
            this.addFlightToLogBookToolStripMenuItem.Click += new System.EventHandler(this.addFlightToLogBookToolStripMenuItem_Click);
            // 
            // flightsReviewToolStripMenuItem
            // 
            this.flightsReviewToolStripMenuItem.Name = "flightsReviewToolStripMenuItem";
            this.flightsReviewToolStripMenuItem.Size = new System.Drawing.Size(362, 26);
            this.flightsReviewToolStripMenuItem.Text = "Flights Review";
            this.flightsReviewToolStripMenuItem.Click += new System.EventHandler(this.flightsReviewToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(359, 6);
            // 
            // rotablePartCardToolStripMenuItem
            // 
            this.rotablePartCardToolStripMenuItem.Name = "rotablePartCardToolStripMenuItem";
            this.rotablePartCardToolStripMenuItem.Size = new System.Drawing.Size(362, 26);
            this.rotablePartCardToolStripMenuItem.Text = "Rotable Part Card";
            this.rotablePartCardToolStripMenuItem.Click += new System.EventHandler(this.rotablePartCardToolStripMenuItem_Click);
            // 
            // changeRotablePartsToolStripMenuItem
            // 
            this.changeRotablePartsToolStripMenuItem.Name = "changeRotablePartsToolStripMenuItem";
            this.changeRotablePartsToolStripMenuItem.Size = new System.Drawing.Size(362, 26);
            this.changeRotablePartsToolStripMenuItem.Text = "Change Rotable Parts";
            this.changeRotablePartsToolStripMenuItem.Click += new System.EventHandler(this.changeRotablePartsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(359, 6);
            // 
            // addComponentToAircraftToolStripMenuItem
            // 
            this.addComponentToAircraftToolStripMenuItem.Name = "addComponentToAircraftToolStripMenuItem";
            this.addComponentToAircraftToolStripMenuItem.Size = new System.Drawing.Size(362, 26);
            this.addComponentToAircraftToolStripMenuItem.Text = "Add Component to Aircraft";
            this.addComponentToAircraftToolStripMenuItem.Click += new System.EventHandler(this.addComponentToAircraftToolStripMenuItem_Click);
            // 
            // removeComponentFromAircraftToolStripMenuItem
            // 
            this.removeComponentFromAircraftToolStripMenuItem.Name = "removeComponentFromAircraftToolStripMenuItem";
            this.removeComponentFromAircraftToolStripMenuItem.Size = new System.Drawing.Size(362, 26);
            this.removeComponentFromAircraftToolStripMenuItem.Text = "Remove Component from Aircraft";
            this.removeComponentFromAircraftToolStripMenuItem.Click += new System.EventHandler(this.removeComponentFromAircraftToolStripMenuItem_Click);
            // 
            // sendComponentToServiceToolStripMenuItem
            // 
            this.sendComponentToServiceToolStripMenuItem.Name = "sendComponentToServiceToolStripMenuItem";
            this.sendComponentToServiceToolStripMenuItem.Size = new System.Drawing.Size(362, 26);
            this.sendComponentToServiceToolStripMenuItem.Text = "Send Component To Service";
            this.sendComponentToServiceToolStripMenuItem.Click += new System.EventHandler(this.sendComponentToServiceToolStripMenuItem_Click);
            // 
            // serviceInspectionToolStripMenuItem
            // 
            this.serviceInspectionToolStripMenuItem.Name = "serviceInspectionToolStripMenuItem";
            this.serviceInspectionToolStripMenuItem.Size = new System.Drawing.Size(362, 26);
            this.serviceInspectionToolStripMenuItem.Text = "Service Inspection";
            this.serviceInspectionToolStripMenuItem.Click += new System.EventHandler(this.serviceInspectionToolStripMenuItem_Click);
            // 
            // returnToStockToolStripMenuItem
            // 
            this.returnToStockToolStripMenuItem.Name = "returnToStockToolStripMenuItem";
            this.returnToStockToolStripMenuItem.Size = new System.Drawing.Size(362, 26);
            this.returnToStockToolStripMenuItem.Text = "Return to Stock";
            this.returnToStockToolStripMenuItem.Click += new System.EventHandler(this.returnToStockToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(359, 6);
            // 
            // resourceAvailabilityToolStripMenuItem
            // 
            this.resourceAvailabilityToolStripMenuItem.Name = "resourceAvailabilityToolStripMenuItem";
            this.resourceAvailabilityToolStripMenuItem.Size = new System.Drawing.Size(362, 26);
            this.resourceAvailabilityToolStripMenuItem.Text = "Resource Availability";
            this.resourceAvailabilityToolStripMenuItem.Click += new System.EventHandler(this.resourceAvailabilityToolStripMenuItem_Click);
            // 
            // remainingReportsToolStripMenuItem
            // 
            this.remainingReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hoursRemainingReportToolStripMenuItem,
            this.cyclesRemainingReportToolStripMenuItem,
            this.daysRemainingReportToolStripMenuItem});
            this.remainingReportsToolStripMenuItem.Name = "remainingReportsToolStripMenuItem";
            this.remainingReportsToolStripMenuItem.Size = new System.Drawing.Size(362, 26);
            this.remainingReportsToolStripMenuItem.Text = "Remaining Reports";
            // 
            // hoursRemainingReportToolStripMenuItem
            // 
            this.hoursRemainingReportToolStripMenuItem.Name = "hoursRemainingReportToolStripMenuItem";
            this.hoursRemainingReportToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.hoursRemainingReportToolStripMenuItem.Text = "Hours Remaining Report";
            this.hoursRemainingReportToolStripMenuItem.Click += new System.EventHandler(this.hoursRemainingReportToolStripMenuItem_Click);
            // 
            // cyclesRemainingReportToolStripMenuItem
            // 
            this.cyclesRemainingReportToolStripMenuItem.Name = "cyclesRemainingReportToolStripMenuItem";
            this.cyclesRemainingReportToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.cyclesRemainingReportToolStripMenuItem.Text = "Cycles Remaining Report";
            this.cyclesRemainingReportToolStripMenuItem.Click += new System.EventHandler(this.cyclesRemainingReportToolStripMenuItem_Click);
            // 
            // daysRemainingReportToolStripMenuItem
            // 
            this.daysRemainingReportToolStripMenuItem.Name = "daysRemainingReportToolStripMenuItem";
            this.daysRemainingReportToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.daysRemainingReportToolStripMenuItem.Text = "Days Remaining Report";
            this.daysRemainingReportToolStripMenuItem.Click += new System.EventHandler(this.daysRemainingReportToolStripMenuItem_Click);
            // 
            // rotablePartHistoryToolStripMenuItem
            // 
            this.rotablePartHistoryToolStripMenuItem.Name = "rotablePartHistoryToolStripMenuItem";
            this.rotablePartHistoryToolStripMenuItem.Size = new System.Drawing.Size(362, 26);
            this.rotablePartHistoryToolStripMenuItem.Text = "Rotable Part History";
            this.rotablePartHistoryToolStripMenuItem.Click += new System.EventHandler(this.rotablePartHistoryToolStripMenuItem_Click);
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.exitApplicationToolStripMenuItem.Text = "Exit Application";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1025, 588);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1920, 1020);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aircraft Maintenance Control";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFlightToLogBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightsReviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotablePartCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addComponentToAircraftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeComponentFromAircraftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendComponentToServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceInspectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resourceAvailabilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeRotablePartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remainingReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hoursRemainingReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cyclesRemainingReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daysRemainingReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotablePartHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aircraftSettingsToolStripMenuItem;
    }
}