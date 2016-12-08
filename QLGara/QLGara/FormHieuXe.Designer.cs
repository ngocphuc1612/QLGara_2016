namespace QLGara
{
    partial class FormHieuXe
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
            this.pnlHieuXe = new System.Windows.Forms.Panel();
            this.gwHieuXe = new System.Windows.Forms.DataGridView();
            this.HX_MAHX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HX_TENHX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHieuXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwHieuXe)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHieuXe
            // 
            this.pnlHieuXe.Controls.Add(this.gwHieuXe);
            this.pnlHieuXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHieuXe.Location = new System.Drawing.Point(0, 0);
            this.pnlHieuXe.Name = "pnlHieuXe";
            this.pnlHieuXe.Size = new System.Drawing.Size(594, 363);
            this.pnlHieuXe.TabIndex = 0;
            // 
            // gwHieuXe
            // 
            this.gwHieuXe.AllowUserToAddRows = false;
            this.gwHieuXe.AllowUserToDeleteRows = false;
            this.gwHieuXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gwHieuXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwHieuXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HX_MAHX,
            this.HX_TENHX});
            this.gwHieuXe.Dock = System.Windows.Forms.DockStyle.Top;
            this.gwHieuXe.Location = new System.Drawing.Point(0, 0);
            this.gwHieuXe.Name = "gwHieuXe";
            this.gwHieuXe.ReadOnly = true;
            this.gwHieuXe.Size = new System.Drawing.Size(594, 191);
            this.gwHieuXe.TabIndex = 0;
            // 
            // HX_MAHX
            // 
            this.HX_MAHX.DataPropertyName = "MAHX";
            this.HX_MAHX.HeaderText = "Mã Hiệu Xe";
            this.HX_MAHX.Name = "HX_MAHX";
            this.HX_MAHX.ReadOnly = true;
            // 
            // HX_TENHX
            // 
            this.HX_TENHX.DataPropertyName = "TENHX";
            this.HX_TENHX.HeaderText = "Tên Hiệu Xe";
            this.HX_TENHX.Name = "HX_TENHX";
            this.HX_TENHX.ReadOnly = true;
            // 
            // FormHieuXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 363);
            this.Controls.Add(this.pnlHieuXe);
            this.Name = "FormHieuXe";
            this.Text = "FormHieuXe";
            this.pnlHieuXe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gwHieuXe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHieuXe;
        private System.Windows.Forms.DataGridView gwHieuXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn HX_MAHX;
        private System.Windows.Forms.DataGridViewTextBoxColumn HX_TENHX;
    }
}