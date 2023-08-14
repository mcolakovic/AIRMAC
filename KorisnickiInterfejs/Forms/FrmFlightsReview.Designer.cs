using System.Windows.Forms;

namespace KorisnickiInterfejs.Forms
{
    partial class FrmFlightsReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFlightsReview));
            this.label5 = new System.Windows.Forms.Label();
            this.cbAircraft = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIDLogBook = new System.Windows.Forms.TextBox();
            this.cbAirportFrom = new System.Windows.Forms.ComboBox();
            this.cbAirportTo = new System.Windows.Forms.ComboBox();
            this.txtFlightNumber = new System.Windows.Forms.TextBox();
            this.dpFlightTimeStop = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dpFlightTimeStart = new System.Windows.Forms.DateTimePicker();
            this.btnFlightSearch = new System.Windows.Forms.Button();
            this.dgvLogBook = new System.Windows.Forms.DataGridView();
            this.dpFlightTimeTO = new System.Windows.Forms.DateTimePicker();
            this.dpFlightTimeFROM = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogBook)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "Aircraft:";
            // 
            // cbAircraft
            // 
            this.cbAircraft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAircraft.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAircraft.FormattingEnabled = true;
            this.cbAircraft.Location = new System.Drawing.Point(88, 16);
            this.cbAircraft.Name = "cbAircraft";
            this.cbAircraft.Size = new System.Drawing.Size(178, 23);
            this.cbAircraft.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(635, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 15);
            this.label12.TabIndex = 48;
            this.label12.Text = "Duration [min]:";
            // 
            // txtDuration
            // 
            this.txtDuration.BackColor = System.Drawing.SystemColors.Info;
            this.txtDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDuration.Enabled = false;
            this.txtDuration.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(638, 212);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(150, 23);
            this.txtDuration.TabIndex = 47;
            this.txtDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(635, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 15);
            this.label11.TabIndex = 46;
            this.label11.Text = "LogBook ID:";
            // 
            // txtIDLogBook
            // 
            this.txtIDLogBook.BackColor = System.Drawing.SystemColors.Info;
            this.txtIDLogBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDLogBook.Enabled = false;
            this.txtIDLogBook.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDLogBook.Location = new System.Drawing.Point(638, 24);
            this.txtIDLogBook.Name = "txtIDLogBook";
            this.txtIDLogBook.Size = new System.Drawing.Size(150, 23);
            this.txtIDLogBook.TabIndex = 45;
            this.txtIDLogBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbAirportFrom
            // 
            this.cbAirportFrom.BackColor = System.Drawing.SystemColors.Info;
            this.cbAirportFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAirportFrom.Enabled = false;
            this.cbAirportFrom.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAirportFrom.FormattingEnabled = true;
            this.cbAirportFrom.Location = new System.Drawing.Point(638, 257);
            this.cbAirportFrom.Name = "cbAirportFrom";
            this.cbAirportFrom.Size = new System.Drawing.Size(149, 23);
            this.cbAirportFrom.TabIndex = 44;
            // 
            // cbAirportTo
            // 
            this.cbAirportTo.BackColor = System.Drawing.SystemColors.Info;
            this.cbAirportTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAirportTo.Enabled = false;
            this.cbAirportTo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAirportTo.FormattingEnabled = true;
            this.cbAirportTo.Location = new System.Drawing.Point(638, 305);
            this.cbAirportTo.Name = "cbAirportTo";
            this.cbAirportTo.Size = new System.Drawing.Size(149, 23);
            this.cbAirportTo.TabIndex = 43;
            // 
            // txtFlightNumber
            // 
            this.txtFlightNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtFlightNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFlightNumber.Enabled = false;
            this.txtFlightNumber.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlightNumber.Location = new System.Drawing.Point(638, 71);
            this.txtFlightNumber.Name = "txtFlightNumber";
            this.txtFlightNumber.Size = new System.Drawing.Size(150, 23);
            this.txtFlightNumber.TabIndex = 42;
            this.txtFlightNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dpFlightTimeStop
            // 
            this.dpFlightTimeStop.Enabled = false;
            this.dpFlightTimeStop.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFlightTimeStop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFlightTimeStop.Location = new System.Drawing.Point(638, 166);
            this.dpFlightTimeStop.Name = "dpFlightTimeStop";
            this.dpFlightTimeStop.ShowUpDown = true;
            this.dpFlightTimeStop.Size = new System.Drawing.Size(150, 23);
            this.dpFlightTimeStop.TabIndex = 41;
            this.dpFlightTimeStop.Tag = "0";
            this.dpFlightTimeStop.ValueChanged += new System.EventHandler(this.dpFlightTimeStop_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(635, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 15);
            this.label10.TabIndex = 40;
            this.label10.Text = "Airport From:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(635, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 15);
            this.label9.TabIndex = 39;
            this.label9.Text = "Flight Time End:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(635, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 38;
            this.label8.Text = "Airport To:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(635, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 15);
            this.label7.TabIndex = 37;
            this.label7.Text = "Flight Time Start:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(635, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "Flight Number:";
            // 
            // dpFlightTimeStart
            // 
            this.dpFlightTimeStart.Enabled = false;
            this.dpFlightTimeStart.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFlightTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFlightTimeStart.Location = new System.Drawing.Point(638, 118);
            this.dpFlightTimeStart.Name = "dpFlightTimeStart";
            this.dpFlightTimeStart.ShowUpDown = true;
            this.dpFlightTimeStart.Size = new System.Drawing.Size(149, 23);
            this.dpFlightTimeStart.TabIndex = 35;
            this.dpFlightTimeStart.ValueChanged += new System.EventHandler(this.dpFlightTimeStart_ValueChanged);
            // 
            // btnFlightSearch
            // 
            this.btnFlightSearch.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlightSearch.Image = global::KorisnickiInterfejs.Properties.Resources.Find;
            this.btnFlightSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFlightSearch.Location = new System.Drawing.Point(246, 402);
            this.btnFlightSearch.Name = "btnFlightSearch";
            this.btnFlightSearch.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnFlightSearch.Size = new System.Drawing.Size(138, 26);
            this.btnFlightSearch.TabIndex = 0;
            this.btnFlightSearch.Text = "   Flights Search";
            this.btnFlightSearch.UseVisualStyleBackColor = true;
            this.btnFlightSearch.Click += new System.EventHandler(this.btnFlightSearch_Click);
            // 
            // dgvLogBook
            // 
            this.dgvLogBook.AllowUserToAddRows = false;
            this.dgvLogBook.AllowUserToDeleteRows = false;
            this.dgvLogBook.AllowUserToResizeColumns = false;
            this.dgvLogBook.AllowUserToResizeRows = false;
            this.dgvLogBook.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLogBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLogBook.ColumnHeadersHeight = 35;
            this.dgvLogBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLogBook.Location = new System.Drawing.Point(10, 51);
            this.dgvLogBook.MultiSelect = false;
            this.dgvLogBook.Name = "dgvLogBook";
            this.dgvLogBook.ReadOnly = true;
            this.dgvLogBook.RowHeadersVisible = false;
            this.dgvLogBook.Size = new System.Drawing.Size(617, 321);
            this.dgvLogBook.TabIndex = 49;
            this.dgvLogBook.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLogBook_CellDoubleClick);
            // 
            // dpFlightTimeTO
            // 
            this.dpFlightTimeTO.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFlightTimeTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFlightTimeTO.Location = new System.Drawing.Point(97, 418);
            this.dpFlightTimeTO.Name = "dpFlightTimeTO";
            this.dpFlightTimeTO.ShowUpDown = true;
            this.dpFlightTimeTO.Size = new System.Drawing.Size(126, 23);
            this.dpFlightTimeTO.TabIndex = 51;
            // 
            // dpFlightTimeFROM
            // 
            this.dpFlightTimeFROM.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFlightTimeFROM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFlightTimeFROM.Location = new System.Drawing.Point(97, 383);
            this.dpFlightTimeFROM.Name = "dpFlightTimeFROM";
            this.dpFlightTimeFROM.ShowUpDown = true;
            this.dpFlightTimeFROM.Size = new System.Drawing.Size(126, 23);
            this.dpFlightTimeFROM.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 52;
            this.label1.Text = "From Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 53;
            this.label2.Text = "To Date:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(638, 343);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(65, 29);
            this.btnUpdate.TabIndex = 54;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(722, 343);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 29);
            this.btnCancel.TabIndex = 56;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Image = global::KorisnickiInterfejs.Properties.Resources.Print;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(534, 402);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(93, 26);
            this.button1.TabIndex = 57;
            this.button1.Text = "   Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.Image = global::KorisnickiInterfejs.Properties.Resources.Exit;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(713, 402);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(74, 26);
            this.button2.TabIndex = 58;
            this.button2.Text = "   Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmFlightsReview
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dpFlightTimeTO);
            this.Controls.Add(this.dpFlightTimeFROM);
            this.Controls.Add(this.dgvLogBook);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtIDLogBook);
            this.Controls.Add(this.cbAirportFrom);
            this.Controls.Add(this.cbAirportTo);
            this.Controls.Add(this.txtFlightNumber);
            this.Controls.Add(this.dpFlightTimeStop);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dpFlightTimeStart);
            this.Controls.Add(this.btnFlightSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbAircraft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFlightsReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flights Review";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbAircraft;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIDLogBook;
        private System.Windows.Forms.ComboBox cbAirportFrom;
        private System.Windows.Forms.ComboBox cbAirportTo;
        private System.Windows.Forms.TextBox txtFlightNumber;
        private System.Windows.Forms.DateTimePicker dpFlightTimeStop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dpFlightTimeStart;
        private System.Windows.Forms.Button btnFlightSearch;
        private System.Windows.Forms.DataGridView dgvLogBook;
        private System.Windows.Forms.DateTimePicker dpFlightTimeTO;
        private System.Windows.Forms.DateTimePicker dpFlightTimeFROM;
        private Label label1;
        private Label label2;
        private Button btnUpdate;
        private Button btnCancel;
        private Button button1;
        private Button button2;

        public ComboBox CbAircraft { get => cbAircraft; set => cbAircraft = value; }
        public DateTimePicker DpFlightTimeTO { get => dpFlightTimeTO; set => dpFlightTimeTO = value; }
        public DateTimePicker DpFlightTimeFROM { get => dpFlightTimeFROM; set => dpFlightTimeFROM = value; }
        public ComboBox CbAircraft1 { get => cbAircraft; set => cbAircraft = value; }
        public TextBox TxtDuration { get => txtDuration; set => txtDuration = value; }
        public TextBox TxtIDLogBook { get => txtIDLogBook; set => txtIDLogBook = value; }
        public ComboBox CbAirportFrom { get => cbAirportFrom; set => cbAirportFrom = value; }
        public ComboBox CbAirportTo { get => cbAirportTo; set => cbAirportTo = value; }
        public TextBox TxtFlightNumber { get => txtFlightNumber; set => txtFlightNumber = value; }
        public DateTimePicker DpFlightTimeStop { get => dpFlightTimeStop; set => dpFlightTimeStop = value; }
        public DateTimePicker DpFlightTimeStart { get => dpFlightTimeStart; set => dpFlightTimeStart = value; }
        public DataGridView DgvLogBook { get => dgvLogBook; set => dgvLogBook = value; }
        public Button BtnUpdate { get => btnUpdate; set => btnUpdate = value; }
        public Button BtnCancel { get => btnCancel; set => btnCancel = value; }
    }
}