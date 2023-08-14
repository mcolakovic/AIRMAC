using System.Windows.Forms;

namespace KorisnickiInterfejs.Forms
{
    partial class FrmRotablePartHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRotablePartHistory));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.btnCardHistory = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.dgvCardHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "Serial Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "Part Number";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(117, 35);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(218, 20);
            this.txtSerialNumber.TabIndex = 41;
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.Location = new System.Drawing.Point(117, 9);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Size = new System.Drawing.Size(218, 20);
            this.txtPartNumber.TabIndex = 40;
            // 
            // btnCardHistory
            // 
            this.btnCardHistory.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCardHistory.Image = global::KorisnickiInterfejs.Properties.Resources.Find;
            this.btnCardHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCardHistory.Location = new System.Drawing.Point(568, 22);
            this.btnCardHistory.Name = "btnCardHistory";
            this.btnCardHistory.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnCardHistory.Size = new System.Drawing.Size(127, 30);
            this.btnCardHistory.TabIndex = 39;
            this.btnCardHistory.Text = "  Card History";
            this.btnCardHistory.UseVisualStyleBackColor = true;
            this.btnCardHistory.Click += new System.EventHandler(this.btnCardHistory_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "Description";
            // 
            // rtbDescription
            // 
            this.rtbDescription.BackColor = System.Drawing.SystemColors.Info;
            this.rtbDescription.Location = new System.Drawing.Point(117, 61);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(578, 96);
            this.rtbDescription.TabIndex = 44;
            this.rtbDescription.Text = "";
            // 
            // dgvCardHistory
            // 
            this.dgvCardHistory.AllowUserToAddRows = false;
            this.dgvCardHistory.AllowUserToDeleteRows = false;
            this.dgvCardHistory.AllowUserToResizeColumns = false;
            this.dgvCardHistory.AllowUserToResizeRows = false;
            this.dgvCardHistory.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCardHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCardHistory.ColumnHeadersHeight = 35;
            this.dgvCardHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCardHistory.Location = new System.Drawing.Point(9, 163);
            this.dgvCardHistory.MultiSelect = false;
            this.dgvCardHistory.Name = "dgvCardHistory";
            this.dgvCardHistory.ReadOnly = true;
            this.dgvCardHistory.RowHeadersVisible = false;
            this.dgvCardHistory.Size = new System.Drawing.Size(686, 282);
            this.dgvCardHistory.TabIndex = 50;
            // 
            // FrmRotablePartHistory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.dgvCardHistory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSerialNumber);
            this.Controls.Add(this.txtPartNumber);
            this.Controls.Add(this.btnCardHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRotablePartHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rotable Part History";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.TextBox txtPartNumber;
        private System.Windows.Forms.Button btnCardHistory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.DataGridView dgvCardHistory;

        public TextBox TxtSerialNumber { get => txtSerialNumber; set => txtSerialNumber = value; }
        public TextBox TxtPartNumber { get => txtPartNumber; set => txtPartNumber = value; }
        public RichTextBox RtbDescription { get => rtbDescription; set => rtbDescription = value; }
        public DataGridView DgvCardHistory { get => dgvCardHistory; set => dgvCardHistory = value; }
    }
}