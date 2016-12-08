namespace QLGara
{
    partial class FormVatTu
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
            this.pnlVatTu = new System.Windows.Forms.Panel();
            this.gwVatTu = new System.Windows.Forms.DataGridView();
            this.VT_MAVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VT_TENVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VT_DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VT_SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlVatTu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwVatTu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVatTu
            // 
            this.pnlVatTu.Controls.Add(this.gwVatTu);
            this.pnlVatTu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVatTu.Location = new System.Drawing.Point(0, 0);
            this.pnlVatTu.Name = "pnlVatTu";
            this.pnlVatTu.Size = new System.Drawing.Size(646, 429);
            this.pnlVatTu.TabIndex = 0;
            // 
            // gwVatTu
            // 
            this.gwVatTu.AllowUserToAddRows = false;
            this.gwVatTu.AllowUserToDeleteRows = false;
            this.gwVatTu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gwVatTu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwVatTu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VT_MAVT,
            this.VT_TENVT,
            this.VT_DONGIA,
            this.VT_SL});
            this.gwVatTu.Dock = System.Windows.Forms.DockStyle.Top;
            this.gwVatTu.Location = new System.Drawing.Point(0, 0);
            this.gwVatTu.Name = "gwVatTu";
            this.gwVatTu.ReadOnly = true;
            this.gwVatTu.Size = new System.Drawing.Size(646, 208);
            this.gwVatTu.TabIndex = 0;
            // 
            // VT_MAVT
            // 
            this.VT_MAVT.DataPropertyName = "MAVT";
            this.VT_MAVT.HeaderText = "Mã VT";
            this.VT_MAVT.Name = "VT_MAVT";
            this.VT_MAVT.ReadOnly = true;
            // 
            // VT_TENVT
            // 
            this.VT_TENVT.DataPropertyName = "TENVT";
            this.VT_TENVT.HeaderText = "Tên VT";
            this.VT_TENVT.Name = "VT_TENVT";
            this.VT_TENVT.ReadOnly = true;
            // 
            // VT_DONGIA
            // 
            this.VT_DONGIA.DataPropertyName = "DONGIA";
            this.VT_DONGIA.HeaderText = "Đơn giá";
            this.VT_DONGIA.Name = "VT_DONGIA";
            this.VT_DONGIA.ReadOnly = true;
            // 
            // VT_SL
            // 
            this.VT_SL.DataPropertyName = "SL";
            this.VT_SL.HeaderText = "Số lượng";
            this.VT_SL.Name = "VT_SL";
            this.VT_SL.ReadOnly = true;
            // 
            // FormVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 429);
            this.Controls.Add(this.pnlVatTu);
            this.Name = "FormVatTu";
            this.Text = "FormVatTu";
            this.pnlVatTu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gwVatTu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlVatTu;
        private System.Windows.Forms.DataGridView gwVatTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn VT_MAVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn VT_TENVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn VT_DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VT_SL;
    }
}