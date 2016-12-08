namespace QLGara
{
    partial class FormXe
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
            this.pnlXe = new System.Windows.Forms.Panel();
            this.gwXe = new System.Windows.Forms.DataGridView();
            this.Xe_BIENSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xe_USERID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xe_NGAYTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xe_ID_DX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xe_MAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xe_MOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xe_MAUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xe_NAMXX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xe_XUATXU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwXe)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlXe
            // 
            this.pnlXe.Controls.Add(this.gwXe);
            this.pnlXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlXe.Location = new System.Drawing.Point(0, 0);
            this.pnlXe.Name = "pnlXe";
            this.pnlXe.Size = new System.Drawing.Size(603, 376);
            this.pnlXe.TabIndex = 0;
            // 
            // gwXe
            // 
            this.gwXe.AllowUserToAddRows = false;
            this.gwXe.AllowUserToDeleteRows = false;
            this.gwXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gwXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Xe_BIENSO,
            this.Xe_USERID,
            this.Xe_NGAYTN,
            this.Xe_ID_DX,
            this.Xe_MAU,
            this.Xe_MOTA,
            this.Xe_MAUNT,
            this.Xe_NAMXX,
            this.Xe_XUATXU});
            this.gwXe.Dock = System.Windows.Forms.DockStyle.Top;
            this.gwXe.Location = new System.Drawing.Point(0, 0);
            this.gwXe.Name = "gwXe";
            this.gwXe.ReadOnly = true;
            this.gwXe.Size = new System.Drawing.Size(603, 208);
            this.gwXe.TabIndex = 0;
            // 
            // Xe_BIENSO
            // 
            this.Xe_BIENSO.DataPropertyName = "BIENSO";
            this.Xe_BIENSO.HeaderText = "Biển số";
            this.Xe_BIENSO.Name = "Xe_BIENSO";
            this.Xe_BIENSO.ReadOnly = true;
            // 
            // Xe_USERID
            // 
            this.Xe_USERID.DataPropertyName = "USER_ID";
            this.Xe_USERID.HeaderText = "ID chủ xe";
            this.Xe_USERID.Name = "Xe_USERID";
            this.Xe_USERID.ReadOnly = true;
            // 
            // Xe_NGAYTN
            // 
            this.Xe_NGAYTN.DataPropertyName = "NGAYTN";
            this.Xe_NGAYTN.HeaderText = "Ngày nhận";
            this.Xe_NGAYTN.Name = "Xe_NGAYTN";
            this.Xe_NGAYTN.ReadOnly = true;
            // 
            // Xe_ID_DX
            // 
            this.Xe_ID_DX.DataPropertyName = "DONGXE_ID";
            this.Xe_ID_DX.HeaderText = "Dòng xe";
            this.Xe_ID_DX.Name = "Xe_ID_DX";
            this.Xe_ID_DX.ReadOnly = true;
            // 
            // Xe_MAU
            // 
            this.Xe_MAU.DataPropertyName = "MAU_XE";
            this.Xe_MAU.HeaderText = "Màu";
            this.Xe_MAU.Name = "Xe_MAU";
            this.Xe_MAU.ReadOnly = true;
            // 
            // Xe_MOTA
            // 
            this.Xe_MOTA.DataPropertyName = "MOTA";
            this.Xe_MOTA.HeaderText = "Mô tả";
            this.Xe_MOTA.Name = "Xe_MOTA";
            this.Xe_MOTA.ReadOnly = true;
            // 
            // Xe_MAUNT
            // 
            this.Xe_MAUNT.DataPropertyName = "MAU_NOI_THAT";
            this.Xe_MAUNT.HeaderText = "Màu trong xe";
            this.Xe_MAUNT.Name = "Xe_MAUNT";
            this.Xe_MAUNT.ReadOnly = true;
            // 
            // Xe_NAMXX
            // 
            this.Xe_NAMXX.DataPropertyName = "NAM_XUAT_XU";
            this.Xe_NAMXX.HeaderText = "Năm sản xuất";
            this.Xe_NAMXX.Name = "Xe_NAMXX";
            this.Xe_NAMXX.ReadOnly = true;
            // 
            // Xe_XUATXU
            // 
            this.Xe_XUATXU.DataPropertyName = "XUAT_XU";
            this.Xe_XUATXU.HeaderText = "Xuất xứ";
            this.Xe_XUATXU.Name = "Xe_XUATXU";
            this.Xe_XUATXU.ReadOnly = true;
            // 
            // FormXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 376);
            this.Controls.Add(this.pnlXe);
            this.Name = "FormXe";
            this.Text = "FormXe";
            this.pnlXe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gwXe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlXe;
        private System.Windows.Forms.DataGridView gwXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xe_BIENSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xe_USERID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xe_NGAYTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xe_ID_DX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xe_MAU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xe_MOTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xe_MAUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xe_NAMXX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xe_XUATXU;
    }
}