using System.Windows.Forms;

namespace KorisnickiInterfejs.Forms
{
    partial class FrmRotableParts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRotableParts));
            this.btnSearchForItem = new System.Windows.Forms.Button();
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dpDateOfEntry = new System.Windows.Forms.DateTimePicker();
            this.txtHoursOperationalLimit = new System.Windows.Forms.TextBox();
            this.txtCyclesOperationalLimit = new System.Windows.Forms.TextBox();
            this.txtDaysOperationalLimit = new System.Windows.Forms.TextBox();
            this.txtStorageLimit = new System.Windows.Forms.TextBox();
            this.txtTimeSinceNew = new System.Windows.Forms.TextBox();
            this.txtCyclesSinceNew = new System.Windows.Forms.TextBox();
            this.txtDaysSinceNew = new System.Windows.Forms.TextBox();
            this.txtTimeSinceOverhaul = new System.Windows.Forms.TextBox();
            this.txtCyclesSinceOverhaul = new System.Windows.Forms.TextBox();
            this.txtDaysSinceOverhaul = new System.Windows.Forms.TextBox();
            this.btnAddRotablePartsItem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearchForItem
            // 
            this.btnSearchForItem.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchForItem.Image = global::KorisnickiInterfejs.Properties.Resources.Find;
            this.btnSearchForItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchForItem.Location = new System.Drawing.Point(417, 23);
            this.btnSearchForItem.Name = "btnSearchForItem";
            this.btnSearchForItem.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnSearchForItem.Size = new System.Drawing.Size(146, 30);
            this.btnSearchForItem.TabIndex = 0;
            this.btnSearchForItem.Text = "  Search for Item";
            this.btnSearchForItem.UseVisualStyleBackColor = true;
            this.btnSearchForItem.Click += new System.EventHandler(this.btnSearchForItem_Click);
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.Location = new System.Drawing.Point(116, 14);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Size = new System.Drawing.Size(218, 20);
            this.txtPartNumber.TabIndex = 1;
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(116, 40);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(218, 20);
            this.txtSerialNumber.TabIndex = 2;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(116, 66);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(447, 96);
            this.rtbDescription.TabIndex = 3;
            this.rtbDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Part Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Serial Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // dpDateOfEntry
            // 
            this.dpDateOfEntry.Cursor = System.Windows.Forms.Cursors.Default;
            this.dpDateOfEntry.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDateOfEntry.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpDateOfEntry.Location = new System.Drawing.Point(116, 169);
            this.dpDateOfEntry.Name = "dpDateOfEntry";
            this.dpDateOfEntry.ShowUpDown = true;
            this.dpDateOfEntry.Size = new System.Drawing.Size(166, 23);
            this.dpDateOfEntry.TabIndex = 8;
            this.dpDateOfEntry.Value = new System.DateTime(2023, 1, 8, 0, 0, 0, 0);
            // 
            // txtHoursOperationalLimit
            // 
            this.txtHoursOperationalLimit.Location = new System.Drawing.Point(182, 204);
            this.txtHoursOperationalLimit.Name = "txtHoursOperationalLimit";
            this.txtHoursOperationalLimit.Size = new System.Drawing.Size(100, 20);
            this.txtHoursOperationalLimit.TabIndex = 10;
            // 
            // txtCyclesOperationalLimit
            // 
            this.txtCyclesOperationalLimit.Location = new System.Drawing.Point(182, 230);
            this.txtCyclesOperationalLimit.Name = "txtCyclesOperationalLimit";
            this.txtCyclesOperationalLimit.Size = new System.Drawing.Size(100, 20);
            this.txtCyclesOperationalLimit.TabIndex = 11;
            // 
            // txtDaysOperationalLimit
            // 
            this.txtDaysOperationalLimit.Location = new System.Drawing.Point(182, 256);
            this.txtDaysOperationalLimit.Name = "txtDaysOperationalLimit";
            this.txtDaysOperationalLimit.Size = new System.Drawing.Size(100, 20);
            this.txtDaysOperationalLimit.TabIndex = 12;
            // 
            // txtStorageLimit
            // 
            this.txtStorageLimit.Location = new System.Drawing.Point(182, 282);
            this.txtStorageLimit.Name = "txtStorageLimit";
            this.txtStorageLimit.Size = new System.Drawing.Size(100, 20);
            this.txtStorageLimit.TabIndex = 13;
            // 
            // txtTimeSinceNew
            // 
            this.txtTimeSinceNew.Location = new System.Drawing.Point(182, 307);
            this.txtTimeSinceNew.Name = "txtTimeSinceNew";
            this.txtTimeSinceNew.Size = new System.Drawing.Size(100, 20);
            this.txtTimeSinceNew.TabIndex = 14;
            // 
            // txtCyclesSinceNew
            // 
            this.txtCyclesSinceNew.Location = new System.Drawing.Point(182, 332);
            this.txtCyclesSinceNew.Name = "txtCyclesSinceNew";
            this.txtCyclesSinceNew.Size = new System.Drawing.Size(100, 20);
            this.txtCyclesSinceNew.TabIndex = 15;
            // 
            // txtDaysSinceNew
            // 
            this.txtDaysSinceNew.Location = new System.Drawing.Point(182, 358);
            this.txtDaysSinceNew.Name = "txtDaysSinceNew";
            this.txtDaysSinceNew.Size = new System.Drawing.Size(100, 20);
            this.txtDaysSinceNew.TabIndex = 16;
            // 
            // txtTimeSinceOverhaul
            // 
            this.txtTimeSinceOverhaul.Location = new System.Drawing.Point(463, 307);
            this.txtTimeSinceOverhaul.Name = "txtTimeSinceOverhaul";
            this.txtTimeSinceOverhaul.Size = new System.Drawing.Size(100, 20);
            this.txtTimeSinceOverhaul.TabIndex = 17;
            // 
            // txtCyclesSinceOverhaul
            // 
            this.txtCyclesSinceOverhaul.Location = new System.Drawing.Point(463, 333);
            this.txtCyclesSinceOverhaul.Name = "txtCyclesSinceOverhaul";
            this.txtCyclesSinceOverhaul.Size = new System.Drawing.Size(100, 20);
            this.txtCyclesSinceOverhaul.TabIndex = 18;
            // 
            // txtDaysSinceOverhaul
            // 
            this.txtDaysSinceOverhaul.Location = new System.Drawing.Point(463, 358);
            this.txtDaysSinceOverhaul.Name = "txtDaysSinceOverhaul";
            this.txtDaysSinceOverhaul.Size = new System.Drawing.Size(100, 20);
            this.txtDaysSinceOverhaul.TabIndex = 19;
            // 
            // btnAddRotablePartsItem
            // 
            this.btnAddRotablePartsItem.Enabled = false;
            this.btnAddRotablePartsItem.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRotablePartsItem.Image = global::KorisnickiInterfejs.Properties.Resources.Add;
            this.btnAddRotablePartsItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRotablePartsItem.Location = new System.Drawing.Point(207, 405);
            this.btnAddRotablePartsItem.Name = "btnAddRotablePartsItem";
            this.btnAddRotablePartsItem.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnAddRotablePartsItem.Size = new System.Drawing.Size(196, 33);
            this.btnAddRotablePartsItem.TabIndex = 20;
            this.btnAddRotablePartsItem.Text = "   Add Rotable Parts Item";
            this.btnAddRotablePartsItem.UseVisualStyleBackColor = true;
            this.btnAddRotablePartsItem.Click += new System.EventHandler(this.btnAddRotablePartsItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Date Of Entry";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Hours Operational Limit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Cycles Operational Limit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Days Operational Limit";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "Storage Limit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "Time Since New";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 15);
            this.label11.TabIndex = 28;
            this.label11.Text = "Cycles Since New";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 360);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 15);
            this.label12.TabIndex = 29;
            this.label12.Text = "Days Since New";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(298, 309);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 15);
            this.label13.TabIndex = 30;
            this.label13.Text = "Time Since Overhaul";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(298, 334);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 15);
            this.label14.TabIndex = 31;
            this.label14.Text = "Cycles Since Overhaul";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(298, 360);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 15);
            this.label15.TabIndex = 32;
            this.label15.Text = "Days Since Overhaul";
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::KorisnickiInterfejs.Properties.Resources.Cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(456, 405);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnCancel.Size = new System.Drawing.Size(107, 33);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = " Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmRotableParts
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.btnCancel);
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
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddRotablePartsItem);
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
            this.Controls.Add(this.dpDateOfEntry);
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
            this.Name = "FrmRotableParts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rotable Part Card";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchForItem;
        private System.Windows.Forms.TextBox txtPartNumber;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dpDateOfEntry;
        private System.Windows.Forms.TextBox txtHoursOperationalLimit;
        private System.Windows.Forms.TextBox txtCyclesOperationalLimit;
        private System.Windows.Forms.TextBox txtDaysOperationalLimit;
        private System.Windows.Forms.TextBox txtStorageLimit;
        private System.Windows.Forms.TextBox txtTimeSinceNew;
        private System.Windows.Forms.TextBox txtCyclesSinceNew;
        private System.Windows.Forms.TextBox txtDaysSinceNew;
        private System.Windows.Forms.TextBox txtTimeSinceOverhaul;
        private System.Windows.Forms.TextBox txtCyclesSinceOverhaul;
        private System.Windows.Forms.TextBox txtDaysSinceOverhaul;
        private System.Windows.Forms.Button btnAddRotablePartsItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private Button btnCancel;

        public TextBox TxtPartNumber { get => txtPartNumber; set => txtPartNumber = value; }
        public TextBox TxtSerialNumber { get => txtSerialNumber; set => txtSerialNumber = value; }
        public RichTextBox RtbDescription { get => rtbDescription; set => rtbDescription = value; }
        public DateTimePicker DpDateOfEntry { get => dpDateOfEntry; set => dpDateOfEntry = value; }
        public TextBox TxtHoursOperationalLimit { get => txtHoursOperationalLimit; set => txtHoursOperationalLimit = value; }
        public TextBox TxtCyclesOperationalLimit { get => txtCyclesOperationalLimit; set => txtCyclesOperationalLimit = value; }
        public TextBox TxtDaysOperationalLimit { get => txtDaysOperationalLimit; set => txtDaysOperationalLimit = value; }
        public TextBox TxtStorageLimit { get => txtStorageLimit; set => txtStorageLimit = value; }
        public TextBox TxtTimeSinceNew { get => txtTimeSinceNew; set => txtTimeSinceNew = value; }
        public TextBox TxtCyclesSinceNew { get => txtCyclesSinceNew; set => txtCyclesSinceNew = value; }
        public TextBox TxtDaysSinceNew { get => txtDaysSinceNew; set => txtDaysSinceNew = value; }
        public TextBox TxtTimeSinceOverhaul { get => txtTimeSinceOverhaul; set => txtTimeSinceOverhaul = value; }
        public TextBox TxtCyclesSinceOverhaul { get => txtCyclesSinceOverhaul; set => txtCyclesSinceOverhaul = value; }
        public TextBox TxtDaysSinceOverhaul { get => txtDaysSinceOverhaul; set => txtDaysSinceOverhaul = value; }
        public Button BtnAddRotablePartsItem { get => btnAddRotablePartsItem; set => btnAddRotablePartsItem = value; }
        public Button BtnCancel { get => btnCancel; set => btnCancel = value; }
        public Button BtnSearchForItem { get => btnSearchForItem; set => btnSearchForItem = value; }
    }
}