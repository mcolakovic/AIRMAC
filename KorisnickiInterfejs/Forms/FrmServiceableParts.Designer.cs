using System.Windows.Forms;

namespace KorisnickiInterfejs.Forms
{
    partial class FrmServiceableParts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServiceableParts));
            this.dgvServiceableParts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceableParts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServiceableParts
            // 
            this.dgvServiceableParts.AllowUserToAddRows = false;
            this.dgvServiceableParts.AllowUserToDeleteRows = false;
            this.dgvServiceableParts.AllowUserToResizeColumns = false;
            this.dgvServiceableParts.AllowUserToResizeRows = false;
            this.dgvServiceableParts.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServiceableParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvServiceableParts.ColumnHeadersHeight = 35;
            this.dgvServiceableParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvServiceableParts.Location = new System.Drawing.Point(12, 12);
            this.dgvServiceableParts.MultiSelect = false;
            this.dgvServiceableParts.Name = "dgvServiceableParts";
            this.dgvServiceableParts.ReadOnly = true;
            this.dgvServiceableParts.RowHeadersVisible = false;
            this.dgvServiceableParts.Size = new System.Drawing.Size(649, 321);
            this.dgvServiceableParts.TabIndex = 51;
            this.dgvServiceableParts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceableParts_CellDoubleClick);
            // 
            // FrmServiceableParts
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(675, 344);
            this.Controls.Add(this.dgvServiceableParts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmServiceableParts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serviceable Parts";
            this.Shown += new System.EventHandler(this.FrmServiceableParts_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceableParts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServiceableParts;

        public DataGridView DgvServiceableParts { get => dgvServiceableParts; set => dgvServiceableParts = value; }
    }
}