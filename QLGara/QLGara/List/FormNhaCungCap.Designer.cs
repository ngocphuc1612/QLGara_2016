namespace QLGara
{
    partial class FormNhaCungCap
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
            this.pnlNhacCungCap = new System.Windows.Forms.Panel();
            this.gwNhacCungCap = new System.Windows.Forms.DataGridView();
            this.NCC_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCC_TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCC_SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCC_EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCC_DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlNhacCungCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwNhacCungCap)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNhacCungCap
            // 
            this.pnlNhacCungCap.Controls.Add(this.gwNhacCungCap);
            this.pnlNhacCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNhacCungCap.Location = new System.Drawing.Point(0, 0);
            this.pnlNhacCungCap.Name = "pnlNhacCungCap";
            this.pnlNhacCungCap.Size = new System.Drawing.Size(552, 261);
            this.pnlNhacCungCap.TabIndex = 0;
            // 
            // gwNhacCungCap
            // 
            this.gwNhacCungCap.AllowUserToAddRows = false;
            this.gwNhacCungCap.AllowUserToDeleteRows = false;
            this.gwNhacCungCap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gwNhacCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwNhacCungCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NCC_ID,
            this.NCC_TEN,
            this.NCC_SDT,
            this.NCC_EMAIL,
            this.NCC_DIACHI});
            this.gwNhacCungCap.Dock = System.Windows.Forms.DockStyle.Top;
            this.gwNhacCungCap.Location = new System.Drawing.Point(0, 0);
            this.gwNhacCungCap.Name = "gwNhacCungCap";
            this.gwNhacCungCap.ReadOnly = true;
            this.gwNhacCungCap.Size = new System.Drawing.Size(552, 150);
            this.gwNhacCungCap.TabIndex = 0;
            // 
            // NCC_ID
            // 
            this.NCC_ID.DataPropertyName = "NCC_ID";
            this.NCC_ID.HeaderText = "ID NCC";
            this.NCC_ID.Name = "NCC_ID";
            this.NCC_ID.ReadOnly = true;
            // 
            // NCC_TEN
            // 
            this.NCC_TEN.DataPropertyName = "NCC_TEN";
            this.NCC_TEN.HeaderText = "Tên NCC";
            this.NCC_TEN.Name = "NCC_TEN";
            this.NCC_TEN.ReadOnly = true;
            // 
            // NCC_SDT
            // 
            this.NCC_SDT.DataPropertyName = "NCC_SDT";
            this.NCC_SDT.HeaderText = "Số điện thoại";
            this.NCC_SDT.Name = "NCC_SDT";
            this.NCC_SDT.ReadOnly = true;
            // 
            // NCC_EMAIL
            // 
            this.NCC_EMAIL.DataPropertyName = "NCC_EMAIL";
            this.NCC_EMAIL.HeaderText = "Email";
            this.NCC_EMAIL.Name = "NCC_EMAIL";
            this.NCC_EMAIL.ReadOnly = true;
            // 
            // NCC_DIACHI
            // 
            this.NCC_DIACHI.DataPropertyName = "NCC_DIACHI";
            this.NCC_DIACHI.HeaderText = "Địa chỉ NCC";
            this.NCC_DIACHI.Name = "NCC_DIACHI";
            this.NCC_DIACHI.ReadOnly = true;
            // 
            // FormNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 261);
            this.Controls.Add(this.pnlNhacCungCap);
            this.Name = "FormNhaCungCap";
            this.Text = "FormNhaCungCap";
            this.pnlNhacCungCap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gwNhacCungCap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNhacCungCap;
        private System.Windows.Forms.DataGridView gwNhacCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCC_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCC_TEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCC_SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCC_EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCC_DIACHI;
    }
}