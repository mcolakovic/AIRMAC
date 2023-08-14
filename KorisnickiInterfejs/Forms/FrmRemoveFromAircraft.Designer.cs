using System.Windows.Forms;

namespace KorisnickiInterfejs.Forms
{
    partial class FrmRemoveFromAircraft
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRemoveFromAircraft));
            this.cbAirport = new System.Windows.Forms.ComboBox();
            this.txtLastACHours = new System.Windows.Forms.TextBox();
            this.txtLastACCycles = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dpLastUpdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAircraft = new System.Windows.Forms.ComboBox();
            this.gbAircraft = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemoveFromAircraft = new System.Windows.Forms.Button();
            this.txtDaysSinceOverhaul = new System.Windows.Forms.TextBox();
            this.txtCyclesSinceOverhaul = new System.Windows.Forms.TextBox();
            this.txtTimeSinceOverhaul = new System.Windows.Forms.TextBox();
            this.txtDaysSinceNew = new System.Windows.Forms.TextBox();
            this.txtCyclesSinceNew = new System.Windows.Forms.TextBox();
            this.txtTimeSinceNew = new System.Windows.Forms.TextBox();
            this.txtStorageLimit = new System.Windows.Forms.TextBox();
            this.txtDaysOperationalLimit = new System.Windows.Forms.TextBox();
            this.txtCyclesOperationalLimit = new System.Windows.Forms.TextBox();
            this.txtHoursOperationalLimit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.btnSearchForItem = new System.Windows.Forms.Button();
            this.txtACHoursOnInstall = new System.Windows.Forms.TextBox();
            this.txtACCyclesOnInstall = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dpInstalationDate = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbAircraft.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbAirport
            // 
            this.cbAirport.BackColor = System.Drawing.SystemColors.Info;
            this.cbAirport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAirport.Enabled = false;
            this.cbAirport.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAirport.FormattingEnabled = true;
            this.cbAirport.Location = new System.Drawing.Point(103, 113);
            this.cbAirport.Name = "cbAirport";
            this.cbAirport.Size = new System.Drawing.Size(166, 23);
            this.cbAirport.TabIndex = 19;
            // 
            // txtLastACHours
            // 
            this.txtLastACHours.BackColor = System.Drawing.SystemColors.Info;
            this.txtLastACHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastACHours.Location = new System.Drawing.Point(155, 26);
            this.txtLastACHours.Name = "txtLastACHours";
            this.txtLastACHours.ReadOnly = true;
            this.txtLastACHours.Size = new System.Drawing.Size(114, 23);
            this.txtLastACHours.TabIndex = 17;
            // 
            // txtLastACCycles
            // 
            this.txtLastACCycles.BackColor = System.Drawing.SystemColors.Info;
            this.txtLastACCycles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastACCycles.Location = new System.Drawing.Point(155, 55);
            this.txtLastACCycles.Name = "txtLastACCycles";
            this.txtLastACCycles.ReadOnly = true;
            this.txtLastACCycles.Size = new System.Drawing.Size(114, 23);
            this.txtLastACCycles.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 113);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 15);
            this.label16.TabIndex = 12;
            this.label16.Text = "On Airport";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 15);
            this.label17.TabIndex = 10;
            this.label17.Text = "AC Total Cycles";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 28);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(112, 15);
            this.label18.TabIndex = 9;
            this.label18.Text = "AC Total Hours:";
            // 
            // dpLastUpdate
            // 
            this.dpLastUpdate.Cursor = System.Windows.Forms.Cursors.No;
            this.dpLastUpdate.Enabled = false;
            this.dpLastUpdate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpLastUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpLastUpdate.Location = new System.Drawing.Point(103, 84);
            this.dpLastUpdate.Name = "dpLastUpdate";
            this.dpLastUpdate.ShowUpDown = true;
            this.dpLastUpdate.Size = new System.Drawing.Size(166, 23);
            this.dpLastUpdate.TabIndex = 7;
            this.dpLastUpdate.Value = new System.DateTime(2023, 1, 8, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 96;
            this.label4.Text = "Aircraft:";
            // 
            // cbAircraft
            // 
            this.cbAircraft.BackColor = System.Drawing.SystemColors.Info;
            this.cbAircraft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAircraft.Enabled = false;
            this.cbAircraft.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAircraft.FormattingEnabled = true;
            this.cbAircraft.Location = new System.Drawing.Point(399, 172);
            this.cbAircraft.Name = "cbAircraft";
            this.cbAircraft.Size = new System.Drawing.Size(176, 23);
            this.cbAircraft.TabIndex = 95;
            this.cbAircraft.SelectedIndexChanged += new System.EventHandler(this.cbAircraft_SelectedIndexChanged);
            // 
            // gbAircraft
            // 
            this.gbAircraft.Controls.Add(this.cbAirport);
            this.gbAircraft.Controls.Add(this.txtLastACHours);
            this.gbAircraft.Controls.Add(this.txtLastACCycles);
            this.gbAircraft.Controls.Add(this.label16);
            this.gbAircraft.Controls.Add(this.label17);
            this.gbAircraft.Controls.Add(this.label18);
            this.gbAircraft.Controls.Add(this.label19);
            this.gbAircraft.Controls.Add(this.dpLastUpdate);
            this.gbAircraft.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAircraft.Location = new System.Drawing.Point(296, 210);
            this.gbAircraft.Name = "gbAircraft";
            this.gbAircraft.Size = new System.Drawing.Size(279, 152);
            this.gbAircraft.TabIndex = 94;
            this.gbAircraft.TabStop = false;
            this.gbAircraft.Text = "Aircraft Details";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 84);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 15);
            this.label19.TabIndex = 8;
            this.label19.Text = "Last Update:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 405);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 15);
            this.label15.TabIndex = 93;
            this.label15.Text = "Days Since Overhaul";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 379);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 15);
            this.label14.TabIndex = 92;
            this.label14.Text = "Cycles Since Overhaul";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 354);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 15);
            this.label13.TabIndex = 91;
            this.label13.Text = "Time Since Overhaul";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 328);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 15);
            this.label12.TabIndex = 90;
            this.label12.Text = "Days Since New";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 15);
            this.label11.TabIndex = 89;
            this.label11.Text = "Cycles Since New";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 15);
            this.label10.TabIndex = 88;
            this.label10.Text = "Time Since New";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 15);
            this.label9.TabIndex = 87;
            this.label9.Text = "Storage Limit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 15);
            this.label8.TabIndex = 86;
            this.label8.Text = "Days Operational Limit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 15);
            this.label7.TabIndex = 85;
            this.label7.Text = "Cycles Operational Limit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 15);
            this.label6.TabIndex = 84;
            this.label6.Text = "Hours Operational Limit";
            // 
            // btnRemoveFromAircraft
            // 
            this.btnRemoveFromAircraft.Enabled = false;
            this.btnRemoveFromAircraft.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFromAircraft.Image = global::KorisnickiInterfejs.Properties.Resources.Remove;
            this.btnRemoveFromAircraft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveFromAircraft.Location = new System.Drawing.Point(8, 465);
            this.btnRemoveFromAircraft.Name = "btnRemoveFromAircraft";
            this.btnRemoveFromAircraft.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnRemoveFromAircraft.Size = new System.Drawing.Size(174, 33);
            this.btnRemoveFromAircraft.TabIndex = 83;
            this.btnRemoveFromAircraft.Text = "  Remove From Aircraft";
            this.btnRemoveFromAircraft.UseVisualStyleBackColor = true;
            this.btnRemoveFromAircraft.Click += new System.EventHandler(this.btnRemoveFromAircraft_Click);
            // 
            // txtDaysSinceOverhaul
            // 
            this.txtDaysSinceOverhaul.BackColor = System.Drawing.SystemColors.Info;
            this.txtDaysSinceOverhaul.Location = new System.Drawing.Point(184, 403);
            this.txtDaysSinceOverhaul.Name = "txtDaysSinceOverhaul";
            this.txtDaysSinceOverhaul.ReadOnly = true;
            this.txtDaysSinceOverhaul.Size = new System.Drawing.Size(100, 20);
            this.txtDaysSinceOverhaul.TabIndex = 82;
            // 
            // txtCyclesSinceOverhaul
            // 
            this.txtCyclesSinceOverhaul.BackColor = System.Drawing.SystemColors.Info;
            this.txtCyclesSinceOverhaul.Location = new System.Drawing.Point(184, 378);
            this.txtCyclesSinceOverhaul.Name = "txtCyclesSinceOverhaul";
            this.txtCyclesSinceOverhaul.ReadOnly = true;
            this.txtCyclesSinceOverhaul.Size = new System.Drawing.Size(100, 20);
            this.txtCyclesSinceOverhaul.TabIndex = 81;
            // 
            // txtTimeSinceOverhaul
            // 
            this.txtTimeSinceOverhaul.BackColor = System.Drawing.SystemColors.Info;
            this.txtTimeSinceOverhaul.Location = new System.Drawing.Point(184, 352);
            this.txtTimeSinceOverhaul.Name = "txtTimeSinceOverhaul";
            this.txtTimeSinceOverhaul.ReadOnly = true;
            this.txtTimeSinceOverhaul.Size = new System.Drawing.Size(100, 20);
            this.txtTimeSinceOverhaul.TabIndex = 80;
            // 
            // txtDaysSinceNew
            // 
            this.txtDaysSinceNew.BackColor = System.Drawing.SystemColors.Info;
            this.txtDaysSinceNew.Location = new System.Drawing.Point(184, 326);
            this.txtDaysSinceNew.Name = "txtDaysSinceNew";
            this.txtDaysSinceNew.ReadOnly = true;
            this.txtDaysSinceNew.Size = new System.Drawing.Size(100, 20);
            this.txtDaysSinceNew.TabIndex = 79;
            // 
            // txtCyclesSinceNew
            // 
            this.txtCyclesSinceNew.BackColor = System.Drawing.SystemColors.Info;
            this.txtCyclesSinceNew.Location = new System.Drawing.Point(184, 300);
            this.txtCyclesSinceNew.Name = "txtCyclesSinceNew";
            this.txtCyclesSinceNew.ReadOnly = true;
            this.txtCyclesSinceNew.Size = new System.Drawing.Size(100, 20);
            this.txtCyclesSinceNew.TabIndex = 78;
            // 
            // txtTimeSinceNew
            // 
            this.txtTimeSinceNew.BackColor = System.Drawing.SystemColors.Info;
            this.txtTimeSinceNew.Location = new System.Drawing.Point(184, 275);
            this.txtTimeSinceNew.Name = "txtTimeSinceNew";
            this.txtTimeSinceNew.ReadOnly = true;
            this.txtTimeSinceNew.Size = new System.Drawing.Size(100, 20);
            this.txtTimeSinceNew.TabIndex = 77;
            // 
            // txtStorageLimit
            // 
            this.txtStorageLimit.BackColor = System.Drawing.SystemColors.Info;
            this.txtStorageLimit.Location = new System.Drawing.Point(184, 250);
            this.txtStorageLimit.Name = "txtStorageLimit";
            this.txtStorageLimit.ReadOnly = true;
            this.txtStorageLimit.Size = new System.Drawing.Size(100, 20);
            this.txtStorageLimit.TabIndex = 76;
            // 
            // txtDaysOperationalLimit
            // 
            this.txtDaysOperationalLimit.BackColor = System.Drawing.SystemColors.Info;
            this.txtDaysOperationalLimit.Location = new System.Drawing.Point(184, 224);
            this.txtDaysOperationalLimit.Name = "txtDaysOperationalLimit";
            this.txtDaysOperationalLimit.ReadOnly = true;
            this.txtDaysOperationalLimit.Size = new System.Drawing.Size(100, 20);
            this.txtDaysOperationalLimit.TabIndex = 75;
            // 
            // txtCyclesOperationalLimit
            // 
            this.txtCyclesOperationalLimit.BackColor = System.Drawing.SystemColors.Info;
            this.txtCyclesOperationalLimit.Location = new System.Drawing.Point(184, 198);
            this.txtCyclesOperationalLimit.Name = "txtCyclesOperationalLimit";
            this.txtCyclesOperationalLimit.ReadOnly = true;
            this.txtCyclesOperationalLimit.Size = new System.Drawing.Size(100, 20);
            this.txtCyclesOperationalLimit.TabIndex = 74;
            // 
            // txtHoursOperationalLimit
            // 
            this.txtHoursOperationalLimit.BackColor = System.Drawing.SystemColors.Info;
            this.txtHoursOperationalLimit.Location = new System.Drawing.Point(184, 172);
            this.txtHoursOperationalLimit.Name = "txtHoursOperationalLimit";
            this.txtHoursOperationalLimit.ReadOnly = true;
            this.txtHoursOperationalLimit.Size = new System.Drawing.Size(100, 20);
            this.txtHoursOperationalLimit.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 72;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 71;
            this.label2.Text = "Serial Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 70;
            this.label1.Text = "Part Number";
            // 
            // rtbDescription
            // 
            this.rtbDescription.BackColor = System.Drawing.SystemColors.Info;
            this.rtbDescription.Location = new System.Drawing.Point(118, 63);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(454, 96);
            this.rtbDescription.TabIndex = 69;
            this.rtbDescription.Text = "";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.BackColor = System.Drawing.SystemColors.Info;
            this.txtSerialNumber.Location = new System.Drawing.Point(118, 37);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.ReadOnly = true;
            this.txtSerialNumber.Size = new System.Drawing.Size(218, 20);
            this.txtSerialNumber.TabIndex = 68;
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.BackColor = System.Drawing.SystemColors.Info;
            this.txtPartNumber.Location = new System.Drawing.Point(118, 11);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.ReadOnly = true;
            this.txtPartNumber.Size = new System.Drawing.Size(218, 20);
            this.txtPartNumber.TabIndex = 67;
            // 
            // btnSearchForItem
            // 
            this.btnSearchForItem.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchForItem.Image = global::KorisnickiInterfejs.Properties.Resources.Find;
            this.btnSearchForItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchForItem.Location = new System.Drawing.Point(419, 20);
            this.btnSearchForItem.Name = "btnSearchForItem";
            this.btnSearchForItem.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnSearchForItem.Size = new System.Drawing.Size(146, 30);
            this.btnSearchForItem.TabIndex = 66;
            this.btnSearchForItem.Text = "  Search for Item";
            this.btnSearchForItem.UseVisualStyleBackColor = true;
            this.btnSearchForItem.Click += new System.EventHandler(this.btnSearchForItem_Click);
            // 
            // txtACHoursOnInstall
            // 
            this.txtACHoursOnInstall.BackColor = System.Drawing.SystemColors.Info;
            this.txtACHoursOnInstall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtACHoursOnInstall.Location = new System.Drawing.Point(454, 403);
            this.txtACHoursOnInstall.Name = "txtACHoursOnInstall";
            this.txtACHoursOnInstall.ReadOnly = true;
            this.txtACHoursOnInstall.Size = new System.Drawing.Size(114, 20);
            this.txtACHoursOnInstall.TabIndex = 100;
            // 
            // txtACCyclesOnInstall
            // 
            this.txtACCyclesOnInstall.BackColor = System.Drawing.SystemColors.Info;
            this.txtACCyclesOnInstall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtACCyclesOnInstall.Location = new System.Drawing.Point(454, 429);
            this.txtACCyclesOnInstall.Name = "txtACCyclesOnInstall";
            this.txtACCyclesOnInstall.ReadOnly = true;
            this.txtACCyclesOnInstall.Size = new System.Drawing.Size(114, 20);
            this.txtACCyclesOnInstall.TabIndex = 99;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(305, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 15);
            this.label5.TabIndex = 98;
            this.label5.Text = "AC Cycles On Install";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(305, 406);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(140, 15);
            this.label20.TabIndex = 97;
            this.label20.Text = "AC Hours On Install";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(305, 380);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(119, 15);
            this.label21.TabIndex = 102;
            this.label21.Text = "Instalation Date";
            // 
            // dpInstalationDate
            // 
            this.dpInstalationDate.Cursor = System.Windows.Forms.Cursors.No;
            this.dpInstalationDate.Enabled = false;
            this.dpInstalationDate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpInstalationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpInstalationDate.Location = new System.Drawing.Point(454, 373);
            this.dpInstalationDate.Name = "dpInstalationDate";
            this.dpInstalationDate.ShowUpDown = true;
            this.dpInstalationDate.Size = new System.Drawing.Size(118, 23);
            this.dpInstalationDate.TabIndex = 101;
            this.dpInstalationDate.Value = new System.DateTime(2023, 1, 8, 0, 0, 0, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::KorisnickiInterfejs.Properties.Resources.Cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(461, 465);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnCancel.Size = new System.Drawing.Size(107, 33);
            this.btnCancel.TabIndex = 103;
            this.btnCancel.Text = " Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmRemoveFromAircraft
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(580, 510);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.dpInstalationDate);
            this.Controls.Add(this.txtACHoursOnInstall);
            this.Controls.Add(this.txtACCyclesOnInstall);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbAircraft);
            this.Controls.Add(this.gbAircraft);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRemoveFromAircraft);
            this.Controls.Add(this.txtDaysSinceOverhaul);
            this.Controls.Add(this.txtCyclesSinceOverhaul);
            this.Controls.Add(this.txtTimeSinceOverhaul);
            this.Controls.Add(this.txtDaysSinceNew);
            this.Controls.Add(this.txtCyclesSinceNew);
            this.Controls.Add(this.txtTimeSinceNew);
            this.Controls.Add(this.txtStorageLimit);
            this.Controls.Add(this.txtDaysOperationalLimit);
            this.Controls.Add(this.txtCyclesOperationalLimit);
            this.Controls.Add(this.txtHoursOperationalLimit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.txtSerialNumber);
            this.Controls.Add(this.txtPartNumber);
            this.Controls.Add(this.btnSearchForItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRemoveFromAircraft";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Component from Aircraft";
            this.gbAircraft.ResumeLayout(false);
            this.gbAircraft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAirport;
        private System.Windows.Forms.TextBox txtLastACHours;
        private System.Windows.Forms.TextBox txtLastACCycles;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dpLastUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAircraft;
        private System.Windows.Forms.GroupBox gbAircraft;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemoveFromAircraft;
        private System.Windows.Forms.TextBox txtDaysSinceOverhaul;
        private System.Windows.Forms.TextBox txtCyclesSinceOverhaul;
        private System.Windows.Forms.TextBox txtTimeSinceOverhaul;
        private System.Windows.Forms.TextBox txtDaysSinceNew;
        private System.Windows.Forms.TextBox txtCyclesSinceNew;
        private System.Windows.Forms.TextBox txtTimeSinceNew;
        private System.Windows.Forms.TextBox txtStorageLimit;
        private System.Windows.Forms.TextBox txtDaysOperationalLimit;
        private System.Windows.Forms.TextBox txtCyclesOperationalLimit;
        private System.Windows.Forms.TextBox txtHoursOperationalLimit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.TextBox txtPartNumber;
        private System.Windows.Forms.Button btnSearchForItem;
        private System.Windows.Forms.TextBox txtACHoursOnInstall;
        private System.Windows.Forms.TextBox txtACCyclesOnInstall;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label20;
        private Label label21;
        private DateTimePicker dpInstalationDate;
        private Button btnCancel;

        public ComboBox CbAirport { get => cbAirport; set => cbAirport = value; }
        public TextBox TxtLastACHours { get => txtLastACHours; set => txtLastACHours = value; }
        public TextBox TxtLastACCycles { get => txtLastACCycles; set => txtLastACCycles = value; }
        public DateTimePicker DpLastUpdate { get => dpLastUpdate; set => dpLastUpdate = value; }
        public ComboBox CbAircraft { get => cbAircraft; set => cbAircraft = value; }
        public TextBox TxtDaysSinceOverhaul { get => txtDaysSinceOverhaul; set => txtDaysSinceOverhaul = value; }
        public TextBox TxtCyclesSinceOverhaul { get => txtCyclesSinceOverhaul; set => txtCyclesSinceOverhaul = value; }
        public TextBox TxtTimeSinceOverhaul { get => txtTimeSinceOverhaul; set => txtTimeSinceOverhaul = value; }
        public TextBox TxtDaysSinceNew { get => txtDaysSinceNew; set => txtDaysSinceNew = value; }
        public TextBox TxtCyclesSinceNew { get => txtCyclesSinceNew; set => txtCyclesSinceNew = value; }
        public TextBox TxtTimeSinceNew { get => txtTimeSinceNew; set => txtTimeSinceNew = value; }
        public TextBox TxtStorageLimit { get => txtStorageLimit; set => txtStorageLimit = value; }
        public TextBox TxtDaysOperationalLimit { get => txtDaysOperationalLimit; set => txtDaysOperationalLimit = value; }
        public TextBox TxtCyclesOperationalLimit { get => txtCyclesOperationalLimit; set => txtCyclesOperationalLimit = value; }
        public TextBox TxtHoursOperationalLimit { get => txtHoursOperationalLimit; set => txtHoursOperationalLimit = value; }
        public RichTextBox RtbDescription { get => rtbDescription; set => rtbDescription = value; }
        public TextBox TxtSerialNumber { get => txtSerialNumber; set => txtSerialNumber = value; }
        public TextBox TxtPartNumber { get => txtPartNumber; set => txtPartNumber = value; }
        public TextBox TxtACHoursOnInstall { get => txtACHoursOnInstall; set => txtACHoursOnInstall = value; }
        public TextBox TxtACCyclesOnInstall { get => txtACCyclesOnInstall; set => txtACCyclesOnInstall = value; }
        public DateTimePicker DpInstalationDate { get => dpInstalationDate; set => dpInstalationDate = value; }
        public Button BtnCancel { get => btnCancel; set => btnCancel = value; }
        public Button BtnRemoveFromAircraft { get => btnRemoveFromAircraft; set => btnRemoveFromAircraft = value; }
        public Button BtnSearchForItem { get => btnSearchForItem; set => btnSearchForItem = value; }
    }
}