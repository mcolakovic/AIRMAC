using System.Windows.Forms;

namespace KorisnickiInterfejs.Forms
{
    partial class FrmUnserviceableParts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUnserviceableParts));
            this.dgvUnserviceableParts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnserviceableParts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUnserviceableParts
            // 
            this.dgvUnserviceableParts.AllowUserToAddRows = false;
            this.dgvUnserviceableParts.AllowUserToDeleteRows = false;
            this.dgvUnserviceableParts.AllowUserToResizeColumns = false;
            this.dgvUnserviceableParts.AllowUserToResizeRows = false;
            this.dgvUnserviceableParts.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnserviceableParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUnserviceableParts.ColumnHeadersHeight = 35;
            this.dgvUnserviceableParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUnserviceableParts.Location = new System.Drawing.Point(12, 12);
            this.dgvUnserviceableParts.MultiSelect = false;
            this.dgvUnserviceableParts.Name = "dgvUnserviceableParts";
            this.dgvUnserviceableParts.ReadOnly = true;
            this.dgvUnserviceableParts.RowHeadersVisible = false;
            this.dgvUnserviceableParts.Size = new System.Drawing.Size(649, 321);
            this.dgvUnserviceableParts.TabIndex = 50;
            this.dgvUnserviceableParts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnserviceableParts_CellDoubleClick);
            // 
            // FrmUnserviceableParts
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(673, 345);
            this.Controls.Add(this.dgvUnserviceableParts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUnserviceableParts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unserviceable Parts";
            this.Shown += new System.EventHandler(this.FrmUnserviceableParts_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnserviceableParts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUnserviceableParts;

        public DataGridView DgvUnserviceableParts { get => dgvUnserviceableParts; set => dgvUnserviceableParts = value; }
    }
}