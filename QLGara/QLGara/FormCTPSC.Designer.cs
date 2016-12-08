namespace QLGara
{
    partial class FormCTPSC
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
            this.pnlCTPSC = new System.Windows.Forms.Panel();
            this.gwCTPSC = new System.Windows.Forms.DataGridView();
            this.PSC_MAPSC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSC_MAVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTPSC_SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPTSC_NOIDUNG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTPSC_DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCTPSC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwCTPSC)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCTPSC
            // 
            this.pnlCTPSC.Controls.Add(this.gwCTPSC);
            this.pnlCTPSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCTPSC.Location = new System.Drawing.Point(0, 0);
            this.pnlCTPSC.Name = "pnlCTPSC";
            this.pnlCTPSC.Size = new System.Drawing.Size(657, 261);
            this.pnlCTPSC.TabIndex = 0;
            // 
            // gwCTPSC
            // 
            this.gwCTPSC.AllowUserToAddRows = false;
            this.gwCTPSC.AllowUserToDeleteRows = false;
            this.gwCTPSC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gwCTPSC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwCTPSC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PSC_MAPSC,
            this.PSC_MAVT,
            this.CTPSC_SL,
            this.CPTSC_NOIDUNG,
            this.CTPSC_DONGIA});
            this.gwCTPSC.Dock = System.Windows.Forms.DockStyle.Top;
            this.gwCTPSC.Location = new System.Drawing.Point(0, 0);
            this.gwCTPSC.Name = "gwCTPSC";
            this.gwCTPSC.ReadOnly = true;
            this.gwCTPSC.Size = new System.Drawing.Size(657, 150);
            this.gwCTPSC.TabIndex = 0;
            // 
            // PSC_MAPSC
            // 
            this.PSC_MAPSC.DataPropertyName = "MAPSC";
            this.PSC_MAPSC.HeaderText = "Mã PSC";
            this.PSC_MAPSC.Name = "PSC_MAPSC";
            this.PSC_MAPSC.ReadOnly = true;
            // 
            // PSC_MAVT
            // 
            this.PSC_MAVT.DataPropertyName = "MAVT";
            this.PSC_MAVT.HeaderText = "Mã VT";
            this.PSC_MAVT.Name = "PSC_MAVT";
            this.PSC_MAVT.ReadOnly = true;
            // 
            // CTPSC_SL
            // 
            this.CTPSC_SL.DataPropertyName = "SOLUONG";
            dataGridViewCellStyle1.Format = "N0";
            this.CTPSC_SL.DefaultCellStyle = dataGridViewCellStyle1;
            this.CTPSC_SL.HeaderText = "Số lượng";
            this.CTPSC_SL.Name = "CTPSC_SL";
            this.CTPSC_SL.ReadOnly = true;
            // 
            // CPTSC_NOIDUNG
            // 
            this.CPTSC_NOIDUNG.DataPropertyName = "NOIDUNG";
            this.CPTSC_NOIDUNG.HeaderText = "Nội dung";
            this.CPTSC_NOIDUNG.Name = "CPTSC_NOIDUNG";
            this.CPTSC_NOIDUNG.ReadOnly = true;
            // 
            // CTPSC_DONGIA
            // 
            this.CTPSC_DONGIA.DataPropertyName = "DONGIA";
            dataGridViewCellStyle2.Format = "N0";
            this.CTPSC_DONGIA.DefaultCellStyle = dataGridViewCellStyle2;
            this.CTPSC_DONGIA.HeaderText = "Đơn giá";
            this.CTPSC_DONGIA.Name = "CTPSC_DONGIA";
            this.CTPSC_DONGIA.ReadOnly = true;
            // 
            // FormCTPSC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 261);
            this.Controls.Add(this.pnlCTPSC);
            this.Name = "FormCTPSC";
            this.Text = "FormCTPSC";
            this.pnlCTPSC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gwCTPSC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCTPSC;
        private System.Windows.Forms.DataGridView gwCTPSC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSC_MAPSC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSC_MAVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTPSC_SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPTSC_NOIDUNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTPSC_DONGIA;
    }
}