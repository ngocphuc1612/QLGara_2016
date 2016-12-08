namespace QLGara
{
    partial class FormKhachHang
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
            this.pnlKhachHang = new System.Windows.Forms.Panel();
            this.gwKhachHang = new System.Windows.Forms.DataGridView();
            this.KH_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KH_TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KH_SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KH_EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KH_DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KH_NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KH_GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KH_CONGNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlKhachHang
            // 
            this.pnlKhachHang.Controls.Add(this.gwKhachHang);
            this.pnlKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKhachHang.Location = new System.Drawing.Point(0, 0);
            this.pnlKhachHang.Name = "pnlKhachHang";
            this.pnlKhachHang.Size = new System.Drawing.Size(628, 261);
            this.pnlKhachHang.TabIndex = 0;
            // 
            // gwKhachHang
            // 
            this.gwKhachHang.AllowUserToAddRows = false;
            this.gwKhachHang.AllowUserToDeleteRows = false;
            this.gwKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gwKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KH_ID,
            this.KH_TEN,
            this.KH_SDT,
            this.KH_EMAIL,
            this.KH_DIACHI,
            this.KH_NGAYSINH,
            this.KH_GIOITINH,
            this.KH_CONGNO});
            this.gwKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.gwKhachHang.Location = new System.Drawing.Point(0, 0);
            this.gwKhachHang.Name = "gwKhachHang";
            this.gwKhachHang.ReadOnly = true;
            this.gwKhachHang.Size = new System.Drawing.Size(628, 150);
            this.gwKhachHang.TabIndex = 0;
            // 
            // KH_ID
            // 
            this.KH_ID.DataPropertyName = "KH_ID";
            this.KH_ID.HeaderText = "ID Khách hàng";
            this.KH_ID.Name = "KH_ID";
            this.KH_ID.ReadOnly = true;
            // 
            // KH_TEN
            // 
            this.KH_TEN.DataPropertyName = "KH_TEN";
            this.KH_TEN.HeaderText = "Tên KH";
            this.KH_TEN.Name = "KH_TEN";
            this.KH_TEN.ReadOnly = true;
            // 
            // KH_SDT
            // 
            this.KH_SDT.DataPropertyName = "KH_SDT";
            this.KH_SDT.HeaderText = "SDT";
            this.KH_SDT.Name = "KH_SDT";
            this.KH_SDT.ReadOnly = true;
            // 
            // KH_EMAIL
            // 
            this.KH_EMAIL.DataPropertyName = "KH_EMAIL";
            this.KH_EMAIL.HeaderText = "Email";
            this.KH_EMAIL.Name = "KH_EMAIL";
            this.KH_EMAIL.ReadOnly = true;
            // 
            // KH_DIACHI
            // 
            this.KH_DIACHI.DataPropertyName = "KH_DIACHI";
            this.KH_DIACHI.HeaderText = "Địa chỉ";
            this.KH_DIACHI.Name = "KH_DIACHI";
            this.KH_DIACHI.ReadOnly = true;
            // 
            // KH_NGAYSINH
            // 
            this.KH_NGAYSINH.DataPropertyName = "KH_NGAYSINH";
            this.KH_NGAYSINH.HeaderText = "Ngày sinh";
            this.KH_NGAYSINH.Name = "KH_NGAYSINH";
            this.KH_NGAYSINH.ReadOnly = true;
            // 
            // KH_GIOITINH
            // 
            this.KH_GIOITINH.DataPropertyName = "KH_GIOITINH";
            this.KH_GIOITINH.HeaderText = "Giới tính";
            this.KH_GIOITINH.Name = "KH_GIOITINH";
            this.KH_GIOITINH.ReadOnly = true;
            // 
            // KH_CONGNO
            // 
            this.KH_CONGNO.DataPropertyName = "KH_CONGNO";
            dataGridViewCellStyle1.Format = "N0";
            this.KH_CONGNO.DefaultCellStyle = dataGridViewCellStyle1;
            this.KH_CONGNO.HeaderText = "Công nợ";
            this.KH_CONGNO.Name = "KH_CONGNO";
            this.KH_CONGNO.ReadOnly = true;
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 261);
            this.Controls.Add(this.pnlKhachHang);
            this.Name = "FormKhachHang";
            this.Text = "FormKhachHang";
            this.pnlKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gwKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlKhachHang;
        private System.Windows.Forms.DataGridView gwKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH_TEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH_SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH_EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH_DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH_NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH_GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH_CONGNO;
    }
}