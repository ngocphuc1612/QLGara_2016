namespace QLGara
{
    partial class FormPhieuNhap
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
            this.pnlPhieuNhap = new System.Windows.Forms.Panel();
            this.gwPhieuNhap = new System.Windows.Forms.DataGridView();
            this.PN_MAPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PN_NGAYNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PN_TONGTIENNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPhieuNhap
            // 
            this.pnlPhieuNhap.Controls.Add(this.gwPhieuNhap);
            this.pnlPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.pnlPhieuNhap.Name = "pnlPhieuNhap";
            this.pnlPhieuNhap.Size = new System.Drawing.Size(551, 261);
            this.pnlPhieuNhap.TabIndex = 0;
            // 
            // gwPhieuNhap
            // 
            this.gwPhieuNhap.AllowUserToAddRows = false;
            this.gwPhieuNhap.AllowUserToDeleteRows = false;
            this.gwPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gwPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PN_MAPN,
            this.PN_NGAYNHAP,
            this.PN_TONGTIENNHAP});
            this.gwPhieuNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.gwPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.gwPhieuNhap.Name = "gwPhieuNhap";
            this.gwPhieuNhap.ReadOnly = true;
            this.gwPhieuNhap.Size = new System.Drawing.Size(551, 150);
            this.gwPhieuNhap.TabIndex = 0;
            // 
            // PN_MAPN
            // 
            this.PN_MAPN.DataPropertyName = "MAPN";
            this.PN_MAPN.HeaderText = "Mã Phiếu Nhập";
            this.PN_MAPN.Name = "PN_MAPN";
            this.PN_MAPN.ReadOnly = true;
            // 
            // PN_NGAYNHAP
            // 
            this.PN_NGAYNHAP.DataPropertyName = "NGAYNHAP";
            this.PN_NGAYNHAP.HeaderText = "Ngày Nhập";
            this.PN_NGAYNHAP.Name = "PN_NGAYNHAP";
            this.PN_NGAYNHAP.ReadOnly = true;
            // 
            // PN_TONGTIENNHAP
            // 
            this.PN_TONGTIENNHAP.DataPropertyName = "TONGTIENNHAP";
            dataGridViewCellStyle1.Format = "N0";
            this.PN_TONGTIENNHAP.DefaultCellStyle = dataGridViewCellStyle1;
            this.PN_TONGTIENNHAP.HeaderText = "Tổng Tiền";
            this.PN_TONGTIENNHAP.Name = "PN_TONGTIENNHAP";
            this.PN_TONGTIENNHAP.ReadOnly = true;
            // 
            // FormPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 261);
            this.Controls.Add(this.pnlPhieuNhap);
            this.Name = "FormPhieuNhap";
            this.Text = "FormPhieuNhap";
            this.pnlPhieuNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gwPhieuNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPhieuNhap;
        private System.Windows.Forms.DataGridView gwPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn PN_MAPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PN_NGAYNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn PN_TONGTIENNHAP;
    }
}