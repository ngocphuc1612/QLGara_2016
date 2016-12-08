namespace QLGara
{
    partial class FormCTPhieuNhap
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
            this.pnlCTPhieuNhap = new System.Windows.Forms.Panel();
            this.gwCTPhieuNhap = new System.Windows.Forms.DataGridView();
            this.CTPN_MAPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTPN_MAVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTPN_SLNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTPN_TONGPHIEUNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCTPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwCTPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCTPhieuNhap
            // 
            this.pnlCTPhieuNhap.Controls.Add(this.gwCTPhieuNhap);
            this.pnlCTPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCTPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.pnlCTPhieuNhap.Name = "pnlCTPhieuNhap";
            this.pnlCTPhieuNhap.Size = new System.Drawing.Size(757, 261);
            this.pnlCTPhieuNhap.TabIndex = 0;
            // 
            // gwCTPhieuNhap
            // 
            this.gwCTPhieuNhap.AllowUserToAddRows = false;
            this.gwCTPhieuNhap.AllowUserToDeleteRows = false;
            this.gwCTPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gwCTPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwCTPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CTPN_MAPN,
            this.CTPN_MAVT,
            this.CTPN_SLNHAP,
            this.CTPN_TONGPHIEUNHAP});
            this.gwCTPhieuNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.gwCTPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.gwCTPhieuNhap.Name = "gwCTPhieuNhap";
            this.gwCTPhieuNhap.ReadOnly = true;
            this.gwCTPhieuNhap.Size = new System.Drawing.Size(757, 150);
            this.gwCTPhieuNhap.TabIndex = 0;
            // 
            // CTPN_MAPN
            // 
            this.CTPN_MAPN.DataPropertyName = "MAPN";
            this.CTPN_MAPN.HeaderText = "Mã Phiếu Nhập";
            this.CTPN_MAPN.Name = "CTPN_MAPN";
            this.CTPN_MAPN.ReadOnly = true;
            // 
            // CTPN_MAVT
            // 
            this.CTPN_MAVT.DataPropertyName = "MAVT";
            this.CTPN_MAVT.HeaderText = "Mã Vật Tư";
            this.CTPN_MAVT.Name = "CTPN_MAVT";
            this.CTPN_MAVT.ReadOnly = true;
            // 
            // CTPN_SLNHAP
            // 
            this.CTPN_SLNHAP.DataPropertyName = "SLNHAP";
            dataGridViewCellStyle1.Format = "N0";
            this.CTPN_SLNHAP.DefaultCellStyle = dataGridViewCellStyle1;
            this.CTPN_SLNHAP.HeaderText = "Số Lượng";
            this.CTPN_SLNHAP.Name = "CTPN_SLNHAP";
            this.CTPN_SLNHAP.ReadOnly = true;
            // 
            // CTPN_TONGPHIEUNHAP
            // 
            this.CTPN_TONGPHIEUNHAP.DataPropertyName = "TONGPHIEUNHAP";
            dataGridViewCellStyle2.Format = "N0";
            this.CTPN_TONGPHIEUNHAP.DefaultCellStyle = dataGridViewCellStyle2;
            this.CTPN_TONGPHIEUNHAP.HeaderText = "Tổng Tiền Nhập";
            this.CTPN_TONGPHIEUNHAP.Name = "CTPN_TONGPHIEUNHAP";
            this.CTPN_TONGPHIEUNHAP.ReadOnly = true;
            // 
            // FormCTPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 261);
            this.Controls.Add(this.pnlCTPhieuNhap);
            this.Name = "FormCTPhieuNhap";
            this.Text = "FormCTPhieuNhap";
            this.pnlCTPhieuNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gwCTPhieuNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCTPhieuNhap;
        private System.Windows.Forms.DataGridView gwCTPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTPN_MAPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTPN_MAVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTPN_SLNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTPN_TONGPHIEUNHAP;
    }
}