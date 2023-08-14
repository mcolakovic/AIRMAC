using System.Windows.Forms;

namespace KorisnickiInterfejs.Forms
{
    partial class FrmRemainingCycles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRemainingCycles));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dpLastUpdate = new System.Windows.Forms.DateTimePicker();
            this.txtAlert = new System.Windows.Forms.TextBox();
            this.txtUtilisation = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLastACCycles = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbAircraft = new System.Windows.Forms.GroupBox();
            this.cbAirport = new System.Windows.Forms.ComboBox();
            this.txtLastACHours = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbAircraft = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dgvRemainingCycles = new System.Windows.Forms.DataGridView();
            this.gbAircraft.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemainingCycles)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "AC Total Hours:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Last Update:";
            // 
            // dpLastUpdate
            // 
            this.dpLastUpdate.Cursor = System.Windows.Forms.Cursors.No;
            this.dpLastUpdate.Enabled = false;
            this.dpLastUpdate.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpLastUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpLastUpdate.Location = new System.Drawing.Point(122, 78);
            this.dpLastUpdate.Name = "dpLastUpdate";
            this.dpLastUpdate.ShowUpDown = true;
            this.dpLastUpdate.Size = new System.Drawing.Size(132, 22);
            this.dpLastUpdate.TabIndex = 7;
            this.dpLastUpdate.Value = new System.DateTime(2023, 1, 8, 0, 0, 0, 0);
            // 
            // txtAlert
            // 
            this.txtAlert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlert.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlert.Location = new System.Drawing.Point(192, 252);
            this.txtAlert.Name = "txtAlert";
            this.txtAlert.Size = new System.Drawing.Size(78, 22);
            this.txtAlert.TabIndex = 83;
            // 
            // txtUtilisation
            // 
            this.txtUtilisation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUtilisation.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtilisation.Location = new System.Drawing.Point(218, 224);
            this.txtUtilisation.Name = "txtUtilisation";
            this.txtUtilisation.Size = new System.Drawing.Size(52, 22);
            this.txtUtilisation.TabIndex = 82;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.label7.Location = new System.Drawing.Point(7, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 15);
            this.label7.TabIndex = 81;
            this.label7.Text = "Alert Limit - Cycles";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 14);
            this.label6.TabIndex = 80;
            this.label6.Text = " Estimated utilisation per day";
            // 
            // txtLastACCycles
            // 
            this.txtLastACCycles.BackColor = System.Drawing.SystemColors.Info;
            this.txtLastACCycles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastACCycles.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastACCycles.Location = new System.Drawing.Point(122, 49);
            this.txtLastACCycles.Name = "txtLastACCycles";
            this.txtLastACCycles.ReadOnly = true;
            this.txtLastACCycles.Size = new System.Drawing.Size(89, 22);
            this.txtLastACCycles.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "On Airport";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "AC Total Cycles";
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
            this.gbAircraft.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAircraft.Location = new System.Drawing.Point(6, 63);
            this.gbAircraft.Name = "gbAircraft";
            this.gbAircraft.Size = new System.Drawing.Size(264, 148);
            this.gbAircraft.TabIndex = 79;
            this.gbAircraft.TabStop = false;
            this.gbAircraft.Text = "Aircraft Details";
            // 
            // cbAirport
            // 
            this.cbAirport.BackColor = System.Drawing.SystemColors.Info;
            this.cbAirport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAirport.Enabled = false;
            this.cbAirport.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAirport.FormattingEnabled = true;
            this.cbAirport.Location = new System.Drawing.Point(122, 108);
            this.cbAirport.Name = "cbAirport";
            this.cbAirport.Size = new System.Drawing.Size(132, 22);
            this.cbAirport.TabIndex = 19;
            // 
            // txtLastACHours
            // 
            this.txtLastACHours.BackColor = System.Drawing.SystemColors.Info;
            this.txtLastACHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastACHours.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastACHours.Location = new System.Drawing.Point(122, 21);
            this.txtLastACHours.Name = "txtLastACHours";
            this.txtLastACHours.ReadOnly = true;
            this.txtLastACHours.Size = new System.Drawing.Size(89, 22);
            this.txtLastACHours.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 14);
            this.label5.TabIndex = 78;
            this.label5.Text = "Aircraft:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnPrint);
            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Controls.Add(this.txtAlert);
            this.tabPage2.Controls.Add(this.txtUtilisation);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.gbAircraft);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cbAircraft);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(280, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "REPORT";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = global::KorisnickiInterfejs.Properties.Resources.Print;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(7, 388);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnPrint.Size = new System.Drawing.Size(108, 33);
            this.btnPrint.TabIndex = 85;
            this.btnPrint.Text = " Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::KorisnickiInterfejs.Properties.Resources.Find;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(162, 388);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(108, 33);
            this.btnSearch.TabIndex = 84;
            this.btnSearch.Text = " Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbAircraft
            // 
            this.cbAircraft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAircraft.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAircraft.FormattingEnabled = true;
            this.cbAircraft.Location = new System.Drawing.Point(7, 25);
            this.cbAircraft.Name = "cbAircraft";
            this.cbAircraft.Size = new System.Drawing.Size(166, 22);
            this.cbAircraft.TabIndex = 77;
            this.cbAircraft.SelectedIndexChanged += new System.EventHandler(this.cbAircraft_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(288, 469);
            this.tabControl1.TabIndex = 66;
            // 
            // dgvRemainingCycles
            // 
            this.dgvRemainingCycles.AllowUserToAddRows = false;
            this.dgvRemainingCycles.AllowUserToDeleteRows = false;
            this.dgvRemainingCycles.AllowUserToResizeColumns = false;
            this.dgvRemainingCycles.AllowUserToResizeRows = false;
            this.dgvRemainingCycles.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRemainingCycles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRemainingCycles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRemainingCycles.Location = new System.Drawing.Point(298, 29);
            this.dgvRemainingCycles.MultiSelect = false;
            this.dgvRemainingCycles.Name = "dgvRemainingCycles";
            this.dgvRemainingCycles.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRemainingCycles.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRemainingCycles.RowHeadersVisible = false;
            this.dgvRemainingCycles.Size = new System.Drawing.Size(901, 447);
            this.dgvRemainingCycles.TabIndex = 65;
            // 
            // FrmRemainingCycles
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1202, 477);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dgvRemainingCycles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRemainingCycles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remaining Cycles";
            this.gbAircraft.ResumeLayout(false);
            this.gbAircraft.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemainingCycles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpLastUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtAlert;
        private System.Windows.Forms.TextBox txtUtilisation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLastACCycles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbAircraft;
        private System.Windows.Forms.ComboBox cbAirport;
        private System.Windows.Forms.TextBox txtLastACHours;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbAircraft;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView dgvRemainingCycles;

        public DateTimePicker DpLastUpdate { get => dpLastUpdate; set => dpLastUpdate = value; }
        public TextBox TxtAlert { get => txtAlert; set => txtAlert = value; }
        public TextBox TxtUtilisation { get => txtUtilisation; set => txtUtilisation = value; }
        public TextBox TxtLastACCycles { get => txtLastACCycles; set => txtLastACCycles = value; }
        public TextBox TxtLastACHours { get => txtLastACHours; set => txtLastACHours = value; }
        public ComboBox CbAircraft { get => cbAircraft; set => cbAircraft = value; }
        public DataGridView DgvRemainingCycles { get => dgvRemainingCycles; set => dgvRemainingCycles = value; }
        public ComboBox CbAirport { get => cbAirport; set => cbAirport = value; }
    }
}