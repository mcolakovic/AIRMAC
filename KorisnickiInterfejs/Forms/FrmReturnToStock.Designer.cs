using System.Windows.Forms;

namespace KorisnickiInterfejs.Forms
{
    partial class FrmReturnToStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReturnToStock));
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStorageLimit = new System.Windows.Forms.TextBox();
            this.txtDaysOperationalLimit = new System.Windows.Forms.TextBox();
            this.txtCyclesOperationalLimit = new System.Windows.Forms.TextBox();
            this.txtHoursOperationalLimit = new System.Windows.Forms.TextBox();
            this.gbLimit = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rbTested = new System.Windows.Forms.RadioButton();
            this.rbNewOperationalLimit = new System.Windows.Forms.RadioButton();
            this.rbOverhaul = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbWorkOrderDescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWorkOrder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.btnSearchForItem = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.rtbResultOfInspection = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dpDateOfEntry = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReturnToStock = new System.Windows.Forms.Button();
            this.gbLimit.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 15);
            this.label8.TabIndex = 126;
            this.label8.Text = "Days Operational Limit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 15);
            this.label7.TabIndex = 125;
            this.label7.Text = "Cycles Operational Limit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 15);
            this.label6.TabIndex = 124;
            this.label6.Text = "Hours Operational Limit";
            // 
            // txtStorageLimit
            // 
            this.txtStorageLimit.BackColor = System.Drawing.SystemColors.Info;
            this.txtStorageLimit.Location = new System.Drawing.Point(187, 110);
            this.txtStorageLimit.Name = "txtStorageLimit";
            this.txtStorageLimit.ReadOnly = true;
            this.txtStorageLimit.Size = new System.Drawing.Size(100, 23);
            this.txtStorageLimit.TabIndex = 123;
            // 
            // txtDaysOperationalLimit
            // 
            this.txtDaysOperationalLimit.BackColor = System.Drawing.SystemColors.Info;
            this.txtDaysOperationalLimit.Location = new System.Drawing.Point(187, 81);
            this.txtDaysOperationalLimit.Name = "txtDaysOperationalLimit";
            this.txtDaysOperationalLimit.ReadOnly = true;
            this.txtDaysOperationalLimit.Size = new System.Drawing.Size(100, 23);
            this.txtDaysOperationalLimit.TabIndex = 122;
            // 
            // txtCyclesOperationalLimit
            // 
            this.txtCyclesOperationalLimit.BackColor = System.Drawing.SystemColors.Info;
            this.txtCyclesOperationalLimit.Location = new System.Drawing.Point(187, 52);
            this.txtCyclesOperationalLimit.Name = "txtCyclesOperationalLimit";
            this.txtCyclesOperationalLimit.ReadOnly = true;
            this.txtCyclesOperationalLimit.Size = new System.Drawing.Size(100, 23);
            this.txtCyclesOperationalLimit.TabIndex = 121;
            // 
            // txtHoursOperationalLimit
            // 
            this.txtHoursOperationalLimit.BackColor = System.Drawing.SystemColors.Info;
            this.txtHoursOperationalLimit.Location = new System.Drawing.Point(187, 26);
            this.txtHoursOperationalLimit.Name = "txtHoursOperationalLimit";
            this.txtHoursOperationalLimit.ReadOnly = true;
            this.txtHoursOperationalLimit.Size = new System.Drawing.Size(100, 23);
            this.txtHoursOperationalLimit.TabIndex = 120;
            // 
            // gbLimit
            // 
            this.gbLimit.Controls.Add(this.label9);
            this.gbLimit.Controls.Add(this.label8);
            this.gbLimit.Controls.Add(this.label7);
            this.gbLimit.Controls.Add(this.label6);
            this.gbLimit.Controls.Add(this.txtStorageLimit);
            this.gbLimit.Controls.Add(this.txtDaysOperationalLimit);
            this.gbLimit.Controls.Add(this.txtCyclesOperationalLimit);
            this.gbLimit.Controls.Add(this.txtHoursOperationalLimit);
            this.gbLimit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLimit.Location = new System.Drawing.Point(274, 263);
            this.gbLimit.Name = "gbLimit";
            this.gbLimit.Size = new System.Drawing.Size(306, 146);
            this.gbLimit.TabIndex = 151;
            this.gbLimit.TabStop = false;
            this.gbLimit.Text = "Limits";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 15);
            this.label9.TabIndex = 155;
            this.label9.Text = "Storage Limit";
            // 
            // rbTested
            // 
            this.rbTested.AutoSize = true;
            this.rbTested.Checked = true;
            this.rbTested.Enabled = false;
            this.rbTested.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTested.Location = new System.Drawing.Point(18, 360);
            this.rbTested.Name = "rbTested";
            this.rbTested.Size = new System.Drawing.Size(67, 19);
            this.rbTested.TabIndex = 150;
            this.rbTested.TabStop = true;
            this.rbTested.Text = "Tested";
            this.rbTested.UseVisualStyleBackColor = true;
            // 
            // rbNewOperationalLimit
            // 
            this.rbNewOperationalLimit.AutoSize = true;
            this.rbNewOperationalLimit.Enabled = false;
            this.rbNewOperationalLimit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNewOperationalLimit.Location = new System.Drawing.Point(18, 284);
            this.rbNewOperationalLimit.Name = "rbNewOperationalLimit";
            this.rbNewOperationalLimit.Size = new System.Drawing.Size(172, 19);
            this.rbNewOperationalLimit.TabIndex = 149;
            this.rbNewOperationalLimit.Text = "New Operational Limit";
            this.rbNewOperationalLimit.UseVisualStyleBackColor = true;
            // 
            // rbOverhaul
            // 
            this.rbOverhaul.AutoSize = true;
            this.rbOverhaul.Enabled = false;
            this.rbOverhaul.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOverhaul.Location = new System.Drawing.Point(18, 322);
            this.rbOverhaul.Name = "rbOverhaul";
            this.rbOverhaul.Size = new System.Drawing.Size(81, 19);
            this.rbOverhaul.TabIndex = 148;
            this.rbOverhaul.Text = "Overhaul";
            this.rbOverhaul.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 15);
            this.label5.TabIndex = 147;
            this.label5.Text = "Work Order Description";
            // 
            // rtbWorkOrderDescription
            // 
            this.rtbWorkOrderDescription.BackColor = System.Drawing.SystemColors.Info;
            this.rtbWorkOrderDescription.Location = new System.Drawing.Point(182, 197);
            this.rtbWorkOrderDescription.Name = "rtbWorkOrderDescription";
            this.rtbWorkOrderDescription.ReadOnly = true;
            this.rtbWorkOrderDescription.Size = new System.Drawing.Size(398, 60);
            this.rtbWorkOrderDescription.TabIndex = 146;
            this.rtbWorkOrderDescription.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 145;
            this.label4.Text = "Work Order";
            // 
            // txtWorkOrder
            // 
            this.txtWorkOrder.BackColor = System.Drawing.SystemColors.Info;
            this.txtWorkOrder.Location = new System.Drawing.Point(126, 171);
            this.txtWorkOrder.Name = "txtWorkOrder";
            this.txtWorkOrder.ReadOnly = true;
            this.txtWorkOrder.Size = new System.Drawing.Size(454, 20);
            this.txtWorkOrder.TabIndex = 144;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 142;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 141;
            this.label2.Text = "Serial Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 140;
            this.label1.Text = "Part Number";
            // 
            // rtbDescription
            // 
            this.rtbDescription.BackColor = System.Drawing.SystemColors.Info;
            this.rtbDescription.Location = new System.Drawing.Point(126, 67);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(454, 96);
            this.rtbDescription.TabIndex = 139;
            this.rtbDescription.Text = "";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.BackColor = System.Drawing.SystemColors.Info;
            this.txtSerialNumber.Location = new System.Drawing.Point(126, 41);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.ReadOnly = true;
            this.txtSerialNumber.Size = new System.Drawing.Size(218, 20);
            this.txtSerialNumber.TabIndex = 138;
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.BackColor = System.Drawing.SystemColors.Info;
            this.txtPartNumber.Location = new System.Drawing.Point(126, 15);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.ReadOnly = true;
            this.txtPartNumber.Size = new System.Drawing.Size(218, 20);
            this.txtPartNumber.TabIndex = 137;
            // 
            // btnSearchForItem
            // 
            this.btnSearchForItem.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchForItem.Image = global::KorisnickiInterfejs.Properties.Resources.Find;
            this.btnSearchForItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchForItem.Location = new System.Drawing.Point(434, 28);
            this.btnSearchForItem.Name = "btnSearchForItem";
            this.btnSearchForItem.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnSearchForItem.Size = new System.Drawing.Size(146, 33);
            this.btnSearchForItem.TabIndex = 136;
            this.btnSearchForItem.Text = "  Search for Item";
            this.btnSearchForItem.UseVisualStyleBackColor = true;
            this.btnSearchForItem.Click += new System.EventHandler(this.btnSearchForItem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 417);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 15);
            this.label10.TabIndex = 153;
            this.label10.Text = "Result of Inspection";
            // 
            // rtbResultOfInspection
            // 
            this.rtbResultOfInspection.BackColor = System.Drawing.SystemColors.Info;
            this.rtbResultOfInspection.Location = new System.Drawing.Point(182, 415);
            this.rtbResultOfInspection.Name = "rtbResultOfInspection";
            this.rtbResultOfInspection.ReadOnly = true;
            this.rtbResultOfInspection.Size = new System.Drawing.Size(398, 83);
            this.rtbResultOfInspection.TabIndex = 152;
            this.rtbResultOfInspection.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 510);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 15);
            this.label11.TabIndex = 155;
            this.label11.Text = "Date Of Entry";
            // 
            // dpDateOfEntry
            // 
            this.dpDateOfEntry.Cursor = System.Windows.Forms.Cursors.Default;
            this.dpDateOfEntry.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDateOfEntry.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpDateOfEntry.Location = new System.Drawing.Point(182, 510);
            this.dpDateOfEntry.Name = "dpDateOfEntry";
            this.dpDateOfEntry.ShowUpDown = true;
            this.dpDateOfEntry.Size = new System.Drawing.Size(128, 23);
            this.dpDateOfEntry.TabIndex = 154;
            this.dpDateOfEntry.Value = new System.DateTime(2023, 1, 8, 0, 0, 0, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::KorisnickiInterfejs.Properties.Resources.Cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(473, 510);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnCancel.Size = new System.Drawing.Size(107, 33);
            this.btnCancel.TabIndex = 156;
            this.btnCancel.Text = " Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReturnToStock
            // 
            this.btnReturnToStock.Enabled = false;
            this.btnReturnToStock.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToStock.Image = global::KorisnickiInterfejs.Properties.Resources.Move;
            this.btnReturnToStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnToStock.Location = new System.Drawing.Point(335, 510);
            this.btnReturnToStock.Name = "btnReturnToStock";
            this.btnReturnToStock.Size = new System.Drawing.Size(124, 33);
            this.btnReturnToStock.TabIndex = 157;
            this.btnReturnToStock.Text = "  Send to Stock";
            this.btnReturnToStock.UseVisualStyleBackColor = true;
            this.btnReturnToStock.Click += new System.EventHandler(this.btnReturnToStock_Click);
            // 
            // FrmReturnToStock
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(592, 554);
            this.Controls.Add(this.btnReturnToStock);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dpDateOfEntry);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rtbResultOfInspection);
            this.Controls.Add(this.gbLimit);
            this.Controls.Add(this.rbTested);
            this.Controls.Add(this.rbNewOperationalLimit);
            this.Controls.Add(this.rbOverhaul);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtbWorkOrderDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWorkOrder);
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
            this.Name = "FrmReturnToStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return to Stock";
            this.gbLimit.ResumeLayout(false);
            this.gbLimit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStorageLimit;
        private System.Windows.Forms.TextBox txtDaysOperationalLimit;
        private System.Windows.Forms.TextBox txtCyclesOperationalLimit;
        private System.Windows.Forms.TextBox txtHoursOperationalLimit;
        private System.Windows.Forms.GroupBox gbLimit;
        private System.Windows.Forms.RadioButton rbTested;
        private System.Windows.Forms.RadioButton rbNewOperationalLimit;
        private System.Windows.Forms.RadioButton rbOverhaul;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbWorkOrderDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWorkOrder;
        private System.Windows.Forms.Button btnSendToStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.TextBox txtPartNumber;
        private System.Windows.Forms.Button btnSearchForItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtbResultOfInspection;
        private Label label11;
        private DateTimePicker dpDateOfEntry;
        private Button btnCancel;
        private Button btnReturnToStock;

        public TextBox TxtStorageLimit { get => txtStorageLimit; set => txtStorageLimit = value; }
        public TextBox TxtDaysOperationalLimit { get => txtDaysOperationalLimit; set => txtDaysOperationalLimit = value; }
        public TextBox TxtCyclesOperationalLimit { get => txtCyclesOperationalLimit; set => txtCyclesOperationalLimit = value; }
        public TextBox TxtHoursOperationalLimit { get => txtHoursOperationalLimit; set => txtHoursOperationalLimit = value; }
        public RadioButton RbTested { get => rbTested; set => rbTested = value; }
        public RadioButton RbNewOperationalLimit { get => rbNewOperationalLimit; set => rbNewOperationalLimit = value; }
        public RadioButton RbOverhaul { get => rbOverhaul; set => rbOverhaul = value; }
        public RichTextBox RtbWorkOrderDescription { get => rtbWorkOrderDescription; set => rtbWorkOrderDescription = value; }
        public TextBox TxtWorkOrder { get => txtWorkOrder; set => txtWorkOrder = value; }
        public RichTextBox RtbDescription { get => rtbDescription; set => rtbDescription = value; }
        public TextBox TxtSerialNumber { get => txtSerialNumber; set => txtSerialNumber = value; }
        public TextBox TxtPartNumber { get => txtPartNumber; set => txtPartNumber = value; }
        public Button BtnSearchForItem { get => btnSearchForItem; set => btnSearchForItem = value; }
        public RichTextBox RtbResultOfInspection { get => rtbResultOfInspection; set => rtbResultOfInspection = value; }
        public DateTimePicker DpDateOfEntry { get => dpDateOfEntry; set => dpDateOfEntry = value; }
        public Button BtnCancel { get => btnCancel; set => btnCancel = value; }
        public Button BtnSendToStock { get => btnSendToStock; set => btnSendToStock = value; }
        public Button BtnReturnToStock { get => btnReturnToStock; set => btnReturnToStock = value; }
    }
}