namespace QLGara
{
    partial class FormPhieuSC
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
            this.pnlPhieuSC = new System.Windows.Forms.Panel();
            this.gwPhieuSC = new System.Windows.Forms.DataGridView();
            this.PSC_MAPSC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSC_BIENSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSC_USERID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSC_NGAYSC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSC_MATC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSC_TONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPhieuSC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwPhieuSC)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPhieuSC
            // 
            this.pnlPhieuSC.Controls.Add(this.gwPhieuSC);
            this.pnlPhieuSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPhieuSC.Location = new System.Drawing.Point(0, 0);
            this.pnlPhieuSC.Name = "pnlPhieuSC";
            this.pnlPhieuSC.Size = new System.Drawing.Size(627, 302);
            this.pnlPhieuSC.TabIndex = 0;
            // 
            // gwPhieuSC
            // 
            this.gwPhieuSC.AllowUserToAddRows = false;
            this.gwPhieuSC.AllowUserToDeleteRows = false;
            this.gwPhieuSC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gwPhieuSC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwPhieuSC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PSC_MAPSC,
            this.PSC_BIENSO,
            this.PSC_USERID,
            this.PSC_NGAYSC,
            this.PSC_MATC,
            this.PSC_TONG});
            this.gwPhieuSC.Dock = System.Windows.Forms.DockStyle.Top;
            this.gwPhieuSC.Location = new System.Drawing.Point(0, 0);
            this.gwPhieuSC.Name = "gwPhieuSC";
            this.gwPhieuSC.ReadOnly = true;
            this.gwPhieuSC.Size = new System.Drawing.Size(627, 150);
            this.gwPhieuSC.TabIndex = 0;
            // 
            // PSC_MAPSC
            // 
            this.PSC_MAPSC.DataPropertyName = "MAPSC";
            this.PSC_MAPSC.HeaderText = "Mã PSC";
            this.PSC_MAPSC.Name = "PSC_MAPSC";
            this.PSC_MAPSC.ReadOnly = true;
            // 
            // PSC_BIENSO
            // 
            this.PSC_BIENSO.DataPropertyName = "BIENSO";
            this.PSC_BIENSO.HeaderText = "Biển số";
            this.PSC_BIENSO.Name = "PSC_BIENSO";
            this.PSC_BIENSO.ReadOnly = true;
            // 
            // PSC_USERID
            // 
            this.PSC_USERID.DataPropertyName = "USER_ID";
            this.PSC_USERID.HeaderText = "ID Chủ";
            this.PSC_USERID.Name = "PSC_USERID";
            this.PSC_USERID.ReadOnly = true;
            // 
            // PSC_NGAYSC
            // 
            this.PSC_NGAYSC.DataPropertyName = "NGAYSC";
            this.PSC_NGAYSC.HeaderText = "Ngày SC";
            this.PSC_NGAYSC.Name = "PSC_NGAYSC";
            this.PSC_NGAYSC.ReadOnly = true;
            // 
            // PSC_MATC
            // 
            this.PSC_MATC.DataPropertyName = "MATC";
            this.PSC_MATC.HeaderText = "Mã Tiền Công";
            this.PSC_MATC.Name = "PSC_MATC";
            this.PSC_MATC.ReadOnly = true;
            // 
            // PSC_TONG
            // 
            this.PSC_TONG.DataPropertyName = "TONGTT";
            this.PSC_TONG.HeaderText = "Tổng tiền";
            this.PSC_TONG.Name = "PSC_TONG";
            this.PSC_TONG.ReadOnly = true;
            // 
            // FormPhieuSC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 302);
            this.Controls.Add(this.pnlPhieuSC);
            this.Name = "FormPhieuSC";
            this.Text = "FormPhieuSC";
            this.pnlPhieuSC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gwPhieuSC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPhieuSC;
        private System.Windows.Forms.DataGridView gwPhieuSC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSC_MAPSC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSC_BIENSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSC_USERID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSC_NGAYSC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSC_MATC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSC_TONG;
    }
}