namespace QLGara
{
    partial class FormPhieuTT
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
            this.pnlPhieuTT = new System.Windows.Forms.Panel();
            this.gwPhieuTT = new System.Windows.Forms.DataGridView();
            this.PTT_MAPTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTT_MAPSC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTT_NGAYTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTT_TONGTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPhieuTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwPhieuTT)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPhieuTT
            // 
            this.pnlPhieuTT.Controls.Add(this.gwPhieuTT);
            this.pnlPhieuTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPhieuTT.Location = new System.Drawing.Point(0, 0);
            this.pnlPhieuTT.Name = "pnlPhieuTT";
            this.pnlPhieuTT.Size = new System.Drawing.Size(628, 345);
            this.pnlPhieuTT.TabIndex = 0;
            // 
            // gwPhieuTT
            // 
            this.gwPhieuTT.AllowUserToAddRows = false;
            this.gwPhieuTT.AllowUserToDeleteRows = false;
            this.gwPhieuTT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gwPhieuTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwPhieuTT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PTT_MAPTT,
            this.PTT_MAPSC,
            this.PTT_NGAYTT,
            this.PTT_TONGTT});
            this.gwPhieuTT.Dock = System.Windows.Forms.DockStyle.Top;
            this.gwPhieuTT.Location = new System.Drawing.Point(0, 0);
            this.gwPhieuTT.Name = "gwPhieuTT";
            this.gwPhieuTT.ReadOnly = true;
            this.gwPhieuTT.Size = new System.Drawing.Size(628, 195);
            this.gwPhieuTT.TabIndex = 0;
            // 
            // PTT_MAPTT
            // 
            this.PTT_MAPTT.DataPropertyName = "MAPTT";
            this.PTT_MAPTT.HeaderText = "Mã PTT";
            this.PTT_MAPTT.Name = "PTT_MAPTT";
            this.PTT_MAPTT.ReadOnly = true;
            // 
            // PTT_MAPSC
            // 
            this.PTT_MAPSC.DataPropertyName = "MAPSC";
            this.PTT_MAPSC.HeaderText = "Mã PSC";
            this.PTT_MAPSC.Name = "PTT_MAPSC";
            this.PTT_MAPSC.ReadOnly = true;
            // 
            // PTT_NGAYTT
            // 
            this.PTT_NGAYTT.DataPropertyName = "NGAYTT";
            this.PTT_NGAYTT.HeaderText = "Ngày TT";
            this.PTT_NGAYTT.Name = "PTT_NGAYTT";
            this.PTT_NGAYTT.ReadOnly = true;
            // 
            // PTT_TONGTT
            // 
            this.PTT_TONGTT.DataPropertyName = "TONGTT";
            dataGridViewCellStyle1.Format = "N0";
            this.PTT_TONGTT.DefaultCellStyle = dataGridViewCellStyle1;
            this.PTT_TONGTT.HeaderText = "Tổng tiền";
            this.PTT_TONGTT.Name = "PTT_TONGTT";
            this.PTT_TONGTT.ReadOnly = true;
            // 
            // FormPhieuTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 345);
            this.Controls.Add(this.pnlPhieuTT);
            this.Name = "FormPhieuTT";
            this.Text = "FormPhieuTT";
            this.pnlPhieuTT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gwPhieuTT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPhieuTT;
        private System.Windows.Forms.DataGridView gwPhieuTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTT_MAPTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTT_MAPSC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTT_NGAYTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTT_TONGTT;
    }
}