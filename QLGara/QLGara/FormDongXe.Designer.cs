namespace QLGara
{
    partial class FormDongXe
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
            this.pnlDongXe = new System.Windows.Forms.Panel();
            this.gwDongXe = new System.Windows.Forms.DataGridView();
            this.DX_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DX_HX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DX_SOCUA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DX_SOGHE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DX_HOPSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DX_DANDONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DX_NHIENLIEU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DX_KIEUDANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDongXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwDongXe)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDongXe
            // 
            this.pnlDongXe.Controls.Add(this.gwDongXe);
            this.pnlDongXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDongXe.Location = new System.Drawing.Point(0, 0);
            this.pnlDongXe.Name = "pnlDongXe";
            this.pnlDongXe.Size = new System.Drawing.Size(657, 296);
            this.pnlDongXe.TabIndex = 0;
            // 
            // gwDongXe
            // 
            this.gwDongXe.AllowUserToAddRows = false;
            this.gwDongXe.AllowUserToDeleteRows = false;
            this.gwDongXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gwDongXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwDongXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DX_ID,
            this.DX_HX,
            this.DX_SOCUA,
            this.DX_SOGHE,
            this.DX_HOPSO,
            this.DX_DANDONG,
            this.DX_NHIENLIEU,
            this.DX_KIEUDANG});
            this.gwDongXe.Dock = System.Windows.Forms.DockStyle.Top;
            this.gwDongXe.Location = new System.Drawing.Point(0, 0);
            this.gwDongXe.Name = "gwDongXe";
            this.gwDongXe.ReadOnly = true;
            this.gwDongXe.Size = new System.Drawing.Size(657, 174);
            this.gwDongXe.TabIndex = 0;
            // 
            // DX_ID
            // 
            this.DX_ID.DataPropertyName = "DONGXE_ID";
            this.DX_ID.HeaderText = "ID";
            this.DX_ID.Name = "DX_ID";
            this.DX_ID.ReadOnly = true;
            // 
            // DX_HX
            // 
            this.DX_HX.DataPropertyName = "HIEU_XE";
            this.DX_HX.HeaderText = "Hiệu Xe";
            this.DX_HX.Name = "DX_HX";
            this.DX_HX.ReadOnly = true;
            // 
            // DX_SOCUA
            // 
            this.DX_SOCUA.DataPropertyName = "SO_CUA";
            this.DX_SOCUA.HeaderText = "Số cửa";
            this.DX_SOCUA.Name = "DX_SOCUA";
            this.DX_SOCUA.ReadOnly = true;
            // 
            // DX_SOGHE
            // 
            this.DX_SOGHE.DataPropertyName = "SO_GHE";
            this.DX_SOGHE.HeaderText = "Số ghế";
            this.DX_SOGHE.Name = "DX_SOGHE";
            this.DX_SOGHE.ReadOnly = true;
            // 
            // DX_HOPSO
            // 
            this.DX_HOPSO.DataPropertyName = "HOP_SO";
            this.DX_HOPSO.HeaderText = "Hộp số";
            this.DX_HOPSO.Name = "DX_HOPSO";
            this.DX_HOPSO.ReadOnly = true;
            // 
            // DX_DANDONG
            // 
            this.DX_DANDONG.DataPropertyName = "DAN_DONG";
            this.DX_DANDONG.HeaderText = "Dẫn động";
            this.DX_DANDONG.Name = "DX_DANDONG";
            this.DX_DANDONG.ReadOnly = true;
            // 
            // DX_NHIENLIEU
            // 
            this.DX_NHIENLIEU.DataPropertyName = "NHIEN_LIEU";
            this.DX_NHIENLIEU.HeaderText = "Nhiên liệu";
            this.DX_NHIENLIEU.Name = "DX_NHIENLIEU";
            this.DX_NHIENLIEU.ReadOnly = true;
            // 
            // DX_KIEUDANG
            // 
            this.DX_KIEUDANG.DataPropertyName = "KIEU_DANG";
            this.DX_KIEUDANG.HeaderText = "Kiểu dáng";
            this.DX_KIEUDANG.Name = "DX_KIEUDANG";
            this.DX_KIEUDANG.ReadOnly = true;
            // 
            // FormDongXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 296);
            this.Controls.Add(this.pnlDongXe);
            this.Name = "FormDongXe";
            this.Text = "FormDongXe";
            this.pnlDongXe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gwDongXe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDongXe;
        private System.Windows.Forms.DataGridView gwDongXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn DX_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DX_HX;
        private System.Windows.Forms.DataGridViewTextBoxColumn DX_SOCUA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DX_SOGHE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DX_HOPSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DX_DANDONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DX_NHIENLIEU;
        private System.Windows.Forms.DataGridViewTextBoxColumn DX_KIEUDANG;
    }
}