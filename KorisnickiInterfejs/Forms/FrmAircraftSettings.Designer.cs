using System.Windows.Forms;

namespace KorisnickiInterfejs.Forms
{
    partial class FrmAircraftSettings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAircraftSettings));
            this.cbAirport = new System.Windows.Forms.ComboBox();
            this.txtLastACHours = new System.Windows.Forms.TextBox();
            this.txtLastACCycles = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dpLastUpdate = new System.Windows.Forms.DateTimePicker();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.txtRegistrationNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAircrafts = new System.Windows.Forms.DataGridView();
            this.btnAddAircraaft = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAircrafts)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAirport
            // 
            this.cbAirport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAirport.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAirport.FormattingEnabled = true;
            this.cbAirport.Location = new System.Drawing.Point(10, 117);
            this.cbAirport.Name = "cbAirport";
            this.cbAirport.Size = new System.Drawing.Size(185, 27);
            this.cbAirport.TabIndex = 2;
            // 
            // txtLastACHours
            // 
            this.txtLastACHours.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtLastACHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastACHours.Location = new System.Drawing.Point(263, 30);
            this.txtLastACHours.Name = "txtLastACHours";
            this.txtLastACHours.Size = new System.Drawing.Size(114, 22);
            this.txtLastACHours.TabIndex = 3;
            // 
            // txtLastACCycles
            // 
            this.txtLastACCycles.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtLastACCycles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastACCycles.Location = new System.Drawing.Point(263, 71);
            this.txtLastACCycles.Name = "txtLastACCycles";
            this.txtLastACCycles.Size = new System.Drawing.Size(114, 22);
            this.txtLastACCycles.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.label16.Location = new System.Drawing.Point(7, 99);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 20);
            this.label16.TabIndex = 24;
            this.label16.Text = "On Airport";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.label17.Location = new System.Drawing.Point(260, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(144, 20);
            this.label17.TabIndex = 23;
            this.label17.Text = "AC Total Cycles";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.label18.Location = new System.Drawing.Point(260, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(144, 20);
            this.label18.TabIndex = 22;
            this.label18.Text = "AC Total Hours:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.label19.Location = new System.Drawing.Point(260, 99);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(117, 20);
            this.label19.TabIndex = 21;
            this.label19.Text = "Last Update:";
            // 
            // dpLastUpdate
            // 
            this.dpLastUpdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.dpLastUpdate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpLastUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpLastUpdate.Location = new System.Drawing.Point(263, 117);
            this.dpLastUpdate.Name = "dpLastUpdate";
            this.dpLastUpdate.ShowUpDown = true;
            this.dpLastUpdate.Size = new System.Drawing.Size(166, 27);
            this.dpLastUpdate.TabIndex = 5;
            this.dpLastUpdate.Value = new System.DateTime(2023, 1, 8, 0, 0, 0, 0);
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerialNumber.Location = new System.Drawing.Point(10, 71);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(185, 22);
            this.txtSerialNumber.TabIndex = 1;
            // 
            // txtRegistrationNumber
            // 
            this.txtRegistrationNumber.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtRegistrationNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegistrationNumber.Location = new System.Drawing.Point(10, 30);
            this.txtRegistrationNumber.Name = "txtRegistrationNumber";
            this.txtRegistrationNumber.Size = new System.Drawing.Size(185, 22);
            this.txtRegistrationNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.label1.Location = new System.Drawing.Point(7, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Serial Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.label2.Location = new System.Drawing.Point(7, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Registration Number:";
            // 
            // dgvAircrafts
            // 
            this.dgvAircrafts.AllowUserToAddRows = false;
            this.dgvAircrafts.AllowUserToDeleteRows = false;
            this.dgvAircrafts.AllowUserToResizeColumns = false;
            this.dgvAircrafts.AllowUserToResizeRows = false;
            this.dgvAircrafts.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAircrafts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAircrafts.ColumnHeadersHeight = 35;
            this.dgvAircrafts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAircrafts.Location = new System.Drawing.Point(7, 156);
            this.dgvAircrafts.MultiSelect = false;
            this.dgvAircrafts.Name = "dgvAircrafts";
            this.dgvAircrafts.ReadOnly = true;
            this.dgvAircrafts.RowHeadersVisible = false;
            this.dgvAircrafts.RowHeadersWidth = 51;
            this.dgvAircrafts.Size = new System.Drawing.Size(625, 282);
            this.dgvAircrafts.TabIndex = 51;
            // 
            // btnAddAircraaft
            // 
            this.btnAddAircraaft.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAircraaft.Image = global::KorisnickiInterfejs.Properties.Resources.Add;
            this.btnAddAircraaft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAircraaft.Location = new System.Drawing.Point(487, 112);
            this.btnAddAircraaft.Name = "btnAddAircraaft";
            this.btnAddAircraaft.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnAddAircraaft.Size = new System.Drawing.Size(145, 30);
            this.btnAddAircraaft.TabIndex = 6;
            this.btnAddAircraaft.Text = "  Add Aircraft";
            this.btnAddAircraaft.UseVisualStyleBackColor = true;
            this.btnAddAircraaft.Click += new System.EventHandler(this.btnAddAircraaft_Click);
            // 
            // FrmAircraftSettings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(641, 443);
            this.Controls.Add(this.btnAddAircraaft);
            this.Controls.Add(this.dgvAircrafts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRegistrationNumber);
            this.Controls.Add(this.txtSerialNumber);
            this.Controls.Add(this.cbAirport);
            this.Controls.Add(this.txtLastACHours);
            this.Controls.Add(this.txtLastACCycles);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.dpLastUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAircraftSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aircraft Settings";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAircrafts)).EndInit();
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
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dpLastUpdate;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.TextBox txtRegistrationNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAircrafts;
        private System.Windows.Forms.Button btnAddAircraaft;

        public ComboBox CbAirport { get => cbAirport; set => cbAirport = value; }
        public TextBox TxtLastACHours { get => txtLastACHours; set => txtLastACHours = value; }
        public TextBox TxtLastACCycles { get => txtLastACCycles; set => txtLastACCycles = value; }
        public DateTimePicker DpLastUpdate { get => dpLastUpdate; set => dpLastUpdate = value; }
        public TextBox TxtSerialNumber { get => txtSerialNumber; set => txtSerialNumber = value; }
        public TextBox TxtRegistrationNumber { get => txtRegistrationNumber; set => txtRegistrationNumber = value; }
        public DataGridView DgvAircrafts { get => dgvAircrafts; set => dgvAircrafts = value; }
    }
}