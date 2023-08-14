using System.Windows.Forms;

namespace KorisnickiInterfejs.Forms
{
    partial class FrmLogBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogBook));
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.dpFlightTimeStart = new System.Windows.Forms.DateTimePicker();
            this.gbAircraft = new System.Windows.Forms.GroupBox();
            this.cbAirport = new System.Windows.Forms.ComboBox();
            this.txtLastACHours = new System.Windows.Forms.TextBox();
            this.txtLastACCycles = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dpLastUpdate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dpFlightTimeStop = new System.Windows.Forms.DateTimePicker();
            this.txtFlightNumber = new System.Windows.Forms.TextBox();
            this.cbAirportTo = new System.Windows.Forms.ComboBox();
            this.cbAirportFrom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAircraft = new System.Windows.Forms.ComboBox();
            this.txtIDLogBook = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnNewFlight = new System.Windows.Forms.Button();
            this.gbAircraft.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFlight.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFlight.Image")));
            this.btnAddFlight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFlight.Location = new System.Drawing.Point(534, 235);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAddFlight.Size = new System.Drawing.Size(133, 32);
            this.btnAddFlight.TabIndex = 0;
            this.btnAddFlight.Text = "Add Flight";
            this.btnAddFlight.UseVisualStyleBackColor = true;
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            // 
            // dpFlightTimeStart
            // 
            this.dpFlightTimeStart.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFlightTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFlightTimeStart.Location = new System.Drawing.Point(467, 76);
            this.dpFlightTimeStart.Name = "dpFlightTimeStart";
            this.dpFlightTimeStart.ShowUpDown = true;
            this.dpFlightTimeStart.Size = new System.Drawing.Size(200, 23);
            this.dpFlightTimeStart.TabIndex = 7;
            this.dpFlightTimeStart.ValueChanged += new System.EventHandler(this.dpFlightTimeStart_ValueChanged);
            // 
            // gbAircraft
            // 
            this.gbAircraft.Controls.Add(this.cbAirport);
            this.gbAircraft.Controls.Add(this.txtLastACHours);
            this.gbAircraft.Controls.Add(this.txtLastACCycles);
            this.gbAircraft.Controls.Add(this.label4);
            this.gbAircraft.Controls.Add(this.label3);
            this.gbAircraft.Controls.Add(this.label2);
            this.gbAircraft.Controls.Add(this.label1);
            this.gbAircraft.Controls.Add(this.dpLastUpdate);
            this.gbAircraft.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAircraft.Location = new System.Drawing.Point(12, 50);
            this.gbAircraft.Name = "gbAircraft";
            this.gbAircraft.Size = new System.Drawing.Size(279, 152);
            this.gbAircraft.TabIndex = 8;
            this.gbAircraft.TabStop = false;
            this.gbAircraft.Text = "Aircraft Details";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "On Airport";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "AC Total Cycles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "AC Total Hours:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Last Update:";
            // 
            // dpLastUpdate
            // 
            this.dpLastUpdate.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dpLastUpdate.CalendarTrailingForeColor = System.Drawing.SystemColors.Info;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(317, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Flight Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(317, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Flight Time Start:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(317, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Airport To:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(317, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Flight Time End:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(317, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Airport From:";
            // 
            // dpFlightTimeStop
            // 
            this.dpFlightTimeStop.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFlightTimeStop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFlightTimeStop.Location = new System.Drawing.Point(466, 105);
            this.dpFlightTimeStop.Name = "dpFlightTimeStop";
            this.dpFlightTimeStop.ShowUpDown = true;
            this.dpFlightTimeStop.Size = new System.Drawing.Size(200, 23);
            this.dpFlightTimeStop.TabIndex = 24;
            this.dpFlightTimeStop.ValueChanged += new System.EventHandler(this.dpFlightTimeStop_ValueChanged);
            // 
            // txtFlightNumber
            // 
            this.txtFlightNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtFlightNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFlightNumber.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlightNumber.Location = new System.Drawing.Point(466, 47);
            this.txtFlightNumber.Name = "txtFlightNumber";
            this.txtFlightNumber.Size = new System.Drawing.Size(200, 23);
            this.txtFlightNumber.TabIndex = 25;
            this.txtFlightNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbAirportTo
            // 
            this.cbAirportTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAirportTo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAirportTo.FormattingEnabled = true;
            this.cbAirportTo.Location = new System.Drawing.Point(467, 193);
            this.cbAirportTo.Name = "cbAirportTo";
            this.cbAirportTo.Size = new System.Drawing.Size(200, 23);
            this.cbAirportTo.TabIndex = 26;
            // 
            // cbAirportFrom
            // 
            this.cbAirportFrom.BackColor = System.Drawing.SystemColors.Info;
            this.cbAirportFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAirportFrom.Enabled = false;
            this.cbAirportFrom.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAirportFrom.FormattingEnabled = true;
            this.cbAirportFrom.Location = new System.Drawing.Point(467, 164);
            this.cbAirportFrom.Name = "cbAirportFrom";
            this.cbAirportFrom.Size = new System.Drawing.Size(200, 23);
            this.cbAirportFrom.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Aircraft:";
            // 
            // cbAircraft
            // 
            this.cbAircraft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAircraft.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAircraft.FormattingEnabled = true;
            this.cbAircraft.Location = new System.Drawing.Point(115, 12);
            this.cbAircraft.Name = "cbAircraft";
            this.cbAircraft.Size = new System.Drawing.Size(166, 23);
            this.cbAircraft.TabIndex = 28;
            this.cbAircraft.SelectedIndexChanged += new System.EventHandler(this.cbAircraft_SelectedIndexChanged);
            // 
            // txtIDLogBook
            // 
            this.txtIDLogBook.BackColor = System.Drawing.SystemColors.Info;
            this.txtIDLogBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDLogBook.Enabled = false;
            this.txtIDLogBook.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDLogBook.Location = new System.Drawing.Point(466, 18);
            this.txtIDLogBook.Name = "txtIDLogBook";
            this.txtIDLogBook.Size = new System.Drawing.Size(200, 23);
            this.txtIDLogBook.TabIndex = 30;
            this.txtIDLogBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(317, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 15);
            this.label11.TabIndex = 31;
            this.label11.Text = "LogBook ID:";
            // 
            // txtDuration
            // 
            this.txtDuration.BackColor = System.Drawing.SystemColors.Info;
            this.txtDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDuration.Enabled = false;
            this.txtDuration.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(466, 135);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(200, 23);
            this.txtDuration.TabIndex = 32;
            this.txtDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(317, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 15);
            this.label12.TabIndex = 33;
            this.label12.Text = "Duration [min]:";
            // 
            // btnNewFlight
            // 
            this.btnNewFlight.Enabled = false;
            this.btnNewFlight.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewFlight.Image = global::KorisnickiInterfejs.Properties.Resources.New;
            this.btnNewFlight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewFlight.Location = new System.Drawing.Point(12, 235);
            this.btnNewFlight.Name = "btnNewFlight";
            this.btnNewFlight.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnNewFlight.Size = new System.Drawing.Size(133, 32);
            this.btnNewFlight.TabIndex = 35;
            this.btnNewFlight.Text = " New Flight";
            this.btnNewFlight.UseVisualStyleBackColor = true;
            this.btnNewFlight.Click += new System.EventHandler(this.btnNewFlight_Click);
            // 
            // FrmLogBook
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(679, 279);
            this.Controls.Add(this.btnNewFlight);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtIDLogBook);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbAircraft);
            this.Controls.Add(this.cbAirportFrom);
            this.Controls.Add(this.cbAirportTo);
            this.Controls.Add(this.txtFlightNumber);
            this.Controls.Add(this.dpFlightTimeStop);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbAircraft);
            this.Controls.Add(this.dpFlightTimeStart);
            this.Controls.Add(this.btnAddFlight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Flights to LogBook";
            this.gbAircraft.ResumeLayout(false);
            this.gbAircraft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnAddFlight;
        private DateTimePicker dpFlightTimeStart;
        private GroupBox gbAircraft;
        private TextBox txtLastACCycles;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dpLastUpdate;
        private TextBox txtLastACHours;
        private ComboBox cbAirport;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private DateTimePicker dpFlightTimeStop;
        private TextBox txtFlightNumber;
        private ComboBox cbAirportTo;
        private ComboBox cbAirportFrom;
        private Label label5;
        private ComboBox cbAircraft;
        private TextBox txtIDLogBook;
        private Label label11;
        private TextBox txtDuration;
        private Label label12;
        private Button btnNewFlight;

        public ComboBox CbAirport { get => cbAirport; set => cbAirport = value; }
        public ComboBox CbAircraft { get => cbAircraft; set => cbAircraft = value; }
        public ComboBox CbAirportTo { get => cbAirportTo; set => cbAirportTo = value; }
        public ComboBox CbAirportFrom { get => cbAirportFrom; set => cbAirportFrom = value; }
        public DateTimePicker DpFlightTimeStop { get => dpFlightTimeStop; set => dpFlightTimeStop = value; }
        public DateTimePicker DpFlightTimeStart { get => dpFlightTimeStart; set => dpFlightTimeStart = value; }
        public DateTimePicker DpLastUpdate { get => dpLastUpdate; set => dpLastUpdate = value; }
        public TextBox TxtLastACCycles { get => txtLastACCycles; set => txtLastACCycles = value; }
        public TextBox TxtLastACHours { get => txtLastACHours; set => txtLastACHours = value; }
        public TextBox TxtFlightNumber { get => txtFlightNumber; set => txtFlightNumber = value; }
        public TextBox TxtIDLogBook { get => txtIDLogBook; set => txtIDLogBook = value; }
        public TextBox TxtDuration { get => txtDuration; set => txtDuration = value; }
        public Button BtnNewFlight { get => btnNewFlight; set => btnNewFlight = value; }
        public Button BtnAddFlight { get => btnAddFlight; set => btnAddFlight = value; }
    }
}

