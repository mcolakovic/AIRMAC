using System.Windows.Forms;

namespace KorisnickiInterfejs.Forms
{
    partial class FrmServiceInspenction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServiceInspenction));
            this.label5 = new System.Windows.Forms.Label();
            this.rtbWorkOrderDescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWorkOrder = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.btnSearchForItem = new System.Windows.Forms.Button();
            this.rbOverhaul = new System.Windows.Forms.RadioButton();
            this.rbNewOperationalLimit = new System.Windows.Forms.RadioButton();
            this.rbTested = new System.Windows.Forms.RadioButton();
            this.gbLimit = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStorageLimit = new System.Windows.Forms.TextBox();
            this.txtDaysOperationalLimit = new System.Windows.Forms.TextBox();
            this.txtCyclesOperationalLimit = new System.Windows.Forms.TextBox();
            this.txtHoursOperationalLimit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rtbResultOfInspection = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbLimit.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 15);
            this.label5.TabIndex = 129;
            this.label5.Text = "Work Order Description";
            // 
            // rtbWorkOrderDescription
            // 
            this.rtbWorkOrderDescription.BackColor = System.Drawing.SystemColors.Info;
            this.rtbWorkOrderDescription.Location = new System.Drawing.Point(176, 207);
            this.rtbWorkOrderDescription.Name = "rtbWorkOrderDescription";
            this.rtbWorkOrderDescription.ReadOnly = true;
            this.rtbWorkOrderDescription.Size = new System.Drawing.Size(398, 60);
            this.rtbWorkOrderDescription.TabIndex = 128;
            this.rtbWorkOrderDescription.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 127;
            this.label4.Text = "Work Order";
            // 
            // txtWorkOrder
            // 
            this.txtWorkOrder.BackColor = System.Drawing.SystemColors.Info;
            this.txtWorkOrder.Location = new System.Drawing.Point(120, 169);
            this.txtWorkOrder.Name = "txtWorkOrder";
            this.txtWorkOrder.ReadOnly = true;
            this.txtWorkOrder.Size = new System.Drawing.Size(454, 20);
            this.txtWorkOrder.TabIndex = 126;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Image = global::KorisnickiInterfejs.Properties.Resources.Confirm;
            this.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirm.Location = new System.Drawing.Point(223, 548);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnConfirm.Size = new System.Drawing.Size(129, 32);
            this.btnConfirm.TabIndex = 115;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 104;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 103;
            this.label2.Text = "Serial Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 102;
            this.label1.Text = "Part Number";
            // 
            // rtbDescription
            // 
            this.rtbDescription.BackColor = System.Drawing.SystemColors.Info;
            this.rtbDescription.Location = new System.Drawing.Point(120, 65);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(454, 96);
            this.rtbDescription.TabIndex = 101;
            this.rtbDescription.Text = "";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.BackColor = System.Drawing.SystemColors.Info;
            this.txtSerialNumber.Location = new System.Drawing.Point(120, 39);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.ReadOnly = true;
            this.txtSerialNumber.Size = new System.Drawing.Size(218, 20);
            this.txtSerialNumber.TabIndex = 100;
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.BackColor = System.Drawing.SystemColors.Info;
            this.txtPartNumber.Location = new System.Drawing.Point(120, 13);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.ReadOnly = true;
            this.txtPartNumber.Size = new System.Drawing.Size(218, 20);
            this.txtPartNumber.TabIndex = 99;
            // 
            // btnSearchForItem
            // 
            this.btnSearchForItem.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchForItem.Image = global::KorisnickiInterfejs.Properties.Resources.Find;
            this.btnSearchForItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchForItem.Location = new System.Drawing.Point(428, 26);
            this.btnSearchForItem.Name = "btnSearchForItem";
            this.btnSearchForItem.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnSearchForItem.Size = new System.Drawing.Size(146, 33);
            this.btnSearchForItem.TabIndex = 98;
            this.btnSearchForItem.Text = "  Search for Item";
            this.btnSearchForItem.UseVisualStyleBackColor = true;
            this.btnSearchForItem.Click += new System.EventHandler(this.btnSearchForItem_Click);
            // 
            // rbOverhaul
            // 
            this.rbOverhaul.AutoSize = true;
            this.rbOverhaul.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOverhaul.Location = new System.Drawing.Point(12, 320);
            this.rbOverhaul.Name = "rbOverhaul";
            this.rbOverhaul.Size = new System.Drawing.Size(81, 19);
            this.rbOverhaul.TabIndex = 130;
            this.rbOverhaul.Text = "Overhaul";
            this.rbOverhaul.UseVisualStyleBackColor = true;
            this.rbOverhaul.CheckedChanged += new System.EventHandler(this.rbOverhaul_CheckedChanged);
            // 
            // rbNewOperationalLimit
            // 
            this.rbNewOperationalLimit.AutoSize = true;
            this.rbNewOperationalLimit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNewOperationalLimit.Location = new System.Drawing.Point(12, 282);
            this.rbNewOperationalLimit.Name = "rbNewOperationalLimit";
            this.rbNewOperationalLimit.Size = new System.Drawing.Size(172, 19);
            this.rbNewOperationalLimit.TabIndex = 131;
            this.rbNewOperationalLimit.Text = "New Operational Limit";
            this.rbNewOperationalLimit.UseVisualStyleBackColor = true;
            this.rbNewOperationalLimit.CheckedChanged += new System.EventHandler(this.rbNewOperationalLimit_CheckedChanged);
            // 
            // rbTested
            // 
            this.rbTested.AutoSize = true;
            this.rbTested.Checked = true;
            this.rbTested.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTested.Location = new System.Drawing.Point(12, 358);
            this.rbTested.Name = "rbTested";
            this.rbTested.Size = new System.Drawing.Size(67, 19);
            this.rbTested.TabIndex = 132;
            this.rbTested.TabStop = true;
            this.rbTested.Text = "Tested";
            this.rbTested.UseVisualStyleBackColor = true;
            this.rbTested.CheckedChanged += new System.EventHandler(this.rbTested_CheckedChanged);
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
            this.gbLimit.Enabled = false;
            this.gbLimit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLimit.Location = new System.Drawing.Point(275, 282);
            this.gbLimit.Name = "gbLimit";
            this.gbLimit.Size = new System.Drawing.Size(299, 136);
            this.gbLimit.TabIndex = 133;
            this.gbLimit.TabStop = false;
            this.gbLimit.Text = "Limits";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 15);
            this.label9.TabIndex = 127;
            this.label9.Text = "Storage Limit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 15);
            this.label8.TabIndex = 126;
            this.label8.Text = "Days Operational Limit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 15);
            this.label7.TabIndex = 125;
            this.label7.Text = "Cycles Operational Limit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 15);
            this.label6.TabIndex = 124;
            this.label6.Text = "Hours Operational Limit";
            // 
            // txtStorageLimit
            // 
            this.txtStorageLimit.BackColor = System.Drawing.SystemColors.Window;
            this.txtStorageLimit.Location = new System.Drawing.Point(184, 101);
            this.txtStorageLimit.Name = "txtStorageLimit";
            this.txtStorageLimit.Size = new System.Drawing.Size(100, 23);
            this.txtStorageLimit.TabIndex = 123;
            // 
            // txtDaysOperationalLimit
            // 
            this.txtDaysOperationalLimit.BackColor = System.Drawing.SystemColors.Window;
            this.txtDaysOperationalLimit.Location = new System.Drawing.Point(184, 75);
            this.txtDaysOperationalLimit.Name = "txtDaysOperationalLimit";
            this.txtDaysOperationalLimit.Size = new System.Drawing.Size(100, 23);
            this.txtDaysOperationalLimit.TabIndex = 122;
            // 
            // txtCyclesOperationalLimit
            // 
            this.txtCyclesOperationalLimit.BackColor = System.Drawing.SystemColors.Window;
            this.txtCyclesOperationalLimit.Location = new System.Drawing.Point(184, 49);
            this.txtCyclesOperationalLimit.Name = "txtCyclesOperationalLimit";
            this.txtCyclesOperationalLimit.Size = new System.Drawing.Size(100, 23);
            this.txtCyclesOperationalLimit.TabIndex = 121;
            // 
            // txtHoursOperationalLimit
            // 
            this.txtHoursOperationalLimit.BackColor = System.Drawing.SystemColors.Window;
            this.txtHoursOperationalLimit.Location = new System.Drawing.Point(184, 23);
            this.txtHoursOperationalLimit.Name = "txtHoursOperationalLimit";
            this.txtHoursOperationalLimit.Size = new System.Drawing.Size(100, 23);
            this.txtHoursOperationalLimit.TabIndex = 120;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 437);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 15);
            this.label10.TabIndex = 135;
            this.label10.Text = "Result of Inspection";
            // 
            // rtbResultOfInspection
            // 
            this.rtbResultOfInspection.BackColor = System.Drawing.SystemColors.Window;
            this.rtbResultOfInspection.Location = new System.Drawing.Point(176, 435);
            this.rtbResultOfInspection.Name = "rtbResultOfInspection";
            this.rtbResultOfInspection.Size = new System.Drawing.Size(398, 83);
            this.rtbResultOfInspection.TabIndex = 134;
            this.rtbResultOfInspection.Text = "";
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::KorisnickiInterfejs.Properties.Resources.Cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(467, 548);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnCancel.Size = new System.Drawing.Size(107, 33);
            this.btnCancel.TabIndex = 136;
            this.btnCancel.Text = " Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmServiceInspenction
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(586, 592);
            this.Controls.Add(this.btnCancel);
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
            this.Controls.Add(this.btnConfirm);
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
            this.Name = "FrmServiceInspenction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Inspection";
            this.gbLimit.ResumeLayout(false);
            this.gbLimit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbWorkOrderDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWorkOrder;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.TextBox txtPartNumber;
        private System.Windows.Forms.Button btnSearchForItem;
        private System.Windows.Forms.RadioButton rbOverhaul;
        private System.Windows.Forms.RadioButton rbNewOperationalLimit;
        private System.Windows.Forms.RadioButton rbTested;
        private System.Windows.Forms.GroupBox gbLimit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStorageLimit;
        private System.Windows.Forms.TextBox txtDaysOperationalLimit;
        private System.Windows.Forms.TextBox txtCyclesOperationalLimit;
        private System.Windows.Forms.TextBox txtHoursOperationalLimit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtbResultOfInspection;
        private Button btnCancel;

        public RadioButton RbOverhaul { get => rbOverhaul; set => rbOverhaul = value; }
        public RadioButton RbNewOperationalLimit { get => rbNewOperationalLimit; set => rbNewOperationalLimit = value; }
        public RadioButton RbTested { get => rbTested; set => rbTested = value; }
        public TextBox TxtStorageLimit { get => txtStorageLimit; set => txtStorageLimit = value; }
        public TextBox TxtDaysOperationalLimit { get => txtDaysOperationalLimit; set => txtDaysOperationalLimit = value; }
        public TextBox TxtCyclesOperationalLimit { get => txtCyclesOperationalLimit; set => txtCyclesOperationalLimit = value; }
        public TextBox TxtHoursOperationalLimit { get => txtHoursOperationalLimit; set => txtHoursOperationalLimit = value; }
        public RichTextBox RtbDescription { get => rtbDescription; set => rtbDescription = value; }
        public TextBox TxtSerialNumber { get => txtSerialNumber; set => txtSerialNumber = value; }
        public TextBox TxtPartNumber { get => txtPartNumber; set => txtPartNumber = value; }
        public RichTextBox RtbWorkOrderDescription { get => rtbWorkOrderDescription; set => rtbWorkOrderDescription = value; }
        public TextBox TxtWorkOrder { get => txtWorkOrder; set => txtWorkOrder = value; }
        public GroupBox GbLimit { get => gbLimit; set => gbLimit = value; }
        public RichTextBox RtbResultOfInspection { get => rtbResultOfInspection; set => rtbResultOfInspection = value; }
        public Button BtnCancel { get => btnCancel; set => btnCancel = value; }
        public Button BtnSearchForItem { get => btnSearchForItem; set => btnSearchForItem = value; }
        public Button BtnConfirm { get => btnConfirm; set => btnConfirm = value; }
    }
}