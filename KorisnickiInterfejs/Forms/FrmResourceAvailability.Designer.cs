using System.Windows.Forms;

namespace KorisnickiInterfejs.Forms
{
    partial class FrmResourceAvailability
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResourceAvailability));
            this.label5 = new System.Windows.Forms.Label();
            this.cbAircraft = new System.Windows.Forms.ComboBox();
            this.gbAircraft = new System.Windows.Forms.GroupBox();
            this.cbAirport = new System.Windows.Forms.ComboBox();
            this.txtLastACHours = new System.Windows.Forms.TextBox();
            this.txtLastACCycles = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dpLastUpdate = new System.Windows.Forms.DateTimePicker();
            this.dgvResourceAvailability = new System.Windows.Forms.DataGridView();
            this.gbAircraft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResourceAvailability)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "Aircraft:";
            // 
            // cbAircraft
            // 
            this.cbAircraft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAircraft.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAircraft.FormattingEnabled = true;
            this.cbAircraft.Location = new System.Drawing.Point(114, 45);
            this.cbAircraft.Name = "cbAircraft";
            this.cbAircraft.Size = new System.Drawing.Size(166, 23);
            this.cbAircraft.TabIndex = 31;
            this.cbAircraft.SelectedIndexChanged += new System.EventHandler(this.cbAircraft_SelectedIndexChanged);
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
            this.gbAircraft.Location = new System.Drawing.Point(310, 14);
            this.gbAircraft.Name = "gbAircraft";
            this.gbAircraft.Size = new System.Drawing.Size(478, 89);
            this.gbAircraft.TabIndex = 30;
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
            this.cbAirport.Location = new System.Drawing.Point(330, 57);
            this.cbAirport.Name = "cbAirport";
            this.cbAirport.Size = new System.Drawing.Size(132, 23);
            this.cbAirport.TabIndex = 19;
            // 
            // txtLastACHours
            // 
            this.txtLastACHours.BackColor = System.Drawing.SystemColors.Info;
            this.txtLastACHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastACHours.Location = new System.Drawing.Point(124, 26);
            this.txtLastACHours.Name = "txtLastACHours";
            this.txtLastACHours.ReadOnly = true;
            this.txtLastACHours.Size = new System.Drawing.Size(89, 23);
            this.txtLastACHours.TabIndex = 17;
            // 
            // txtLastACCycles
            // 
            this.txtLastACCycles.BackColor = System.Drawing.SystemColors.Info;
            this.txtLastACCycles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastACCycles.Location = new System.Drawing.Point(124, 55);
            this.txtLastACCycles.Name = "txtLastACCycles";
            this.txtLastACCycles.ReadOnly = true;
            this.txtLastACCycles.Size = new System.Drawing.Size(89, 23);
            this.txtLastACCycles.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 57);
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
            this.label1.Location = new System.Drawing.Point(233, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Last Update:";
            // 
            // dpLastUpdate
            // 
            this.dpLastUpdate.Cursor = System.Windows.Forms.Cursors.No;
            this.dpLastUpdate.Enabled = false;
            this.dpLastUpdate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpLastUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpLastUpdate.Location = new System.Drawing.Point(330, 28);
            this.dpLastUpdate.Name = "dpLastUpdate";
            this.dpLastUpdate.ShowUpDown = true;
            this.dpLastUpdate.Size = new System.Drawing.Size(132, 23);
            this.dpLastUpdate.TabIndex = 7;
            this.dpLastUpdate.Value = new System.DateTime(2023, 1, 8, 0, 0, 0, 0);
            // 
            // dgvResourceAvailability
            // 
            this.dgvResourceAvailability.AllowUserToAddRows = false;
            this.dgvResourceAvailability.AllowUserToDeleteRows = false;
            this.dgvResourceAvailability.AllowUserToResizeColumns = false;
            this.dgvResourceAvailability.AllowUserToResizeRows = false;
            this.dgvResourceAvailability.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResourceAvailability.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResourceAvailability.ColumnHeadersHeight = 35;
            this.dgvResourceAvailability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvResourceAvailability.Location = new System.Drawing.Point(12, 109);
            this.dgvResourceAvailability.MultiSelect = false;
            this.dgvResourceAvailability.Name = "dgvResourceAvailability";
            this.dgvResourceAvailability.ReadOnly = true;
            this.dgvResourceAvailability.RowHeadersVisible = false;
            this.dgvResourceAvailability.RowHeadersWidth = 51;
            this.dgvResourceAvailability.Size = new System.Drawing.Size(776, 393);
            this.dgvResourceAvailability.TabIndex = 51;
            this.dgvResourceAvailability.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResourceAvailability_CellDoubleClick);
            // 
            // FrmResourceAvailability
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.dgvResourceAvailability);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbAircraft);
            this.Controls.Add(this.gbAircraft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmResourceAvailability";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resource Availability";
            this.gbAircraft.ResumeLayout(false);
            this.gbAircraft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResourceAvailability)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbAircraft;
        private System.Windows.Forms.GroupBox gbAircraft;
        private System.Windows.Forms.ComboBox cbAirport;
        private System.Windows.Forms.TextBox txtLastACHours;
        private System.Windows.Forms.TextBox txtLastACCycles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpLastUpdate;
        private System.Windows.Forms.DataGridView dgvResourceAvailability;

        public ComboBox CbAircraft { get => cbAircraft; set => cbAircraft = value; }
        public GroupBox GbAircraft { get => gbAircraft; set => gbAircraft = value; }
        public ComboBox CbAirport { get => cbAirport; set => cbAirport = value; }
        public TextBox TxtLastACHours { get => txtLastACHours; set => txtLastACHours = value; }
        public TextBox TxtLastACCycles { get => txtLastACCycles; set => txtLastACCycles = value; }
        public DateTimePicker DpLastUpdate { get => dpLastUpdate; set => dpLastUpdate = value; }
        public DataGridView DgvResourceAvailability { get => dgvResourceAvailability; set => dgvResourceAvailability = value; }
    }
}