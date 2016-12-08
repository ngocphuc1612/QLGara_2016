namespace QLGara
{
    partial class FormTienCong
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
            this.pnlTienCong = new System.Windows.Forms.Panel();
            this.gwTienCong = new System.Windows.Forms.DataGridView();
            this.TC_MATC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TC_TenTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TC_GIATIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTienCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwTienCong)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTienCong
            // 
            this.pnlTienCong.Controls.Add(this.gwTienCong);
            this.pnlTienCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTienCong.Location = new System.Drawing.Point(0, 0);
            this.pnlTienCong.Name = "pnlTienCong";
            this.pnlTienCong.Size = new System.Drawing.Size(565, 415);
            this.pnlTienCong.TabIndex = 0;
            // 
            // gwTienCong
            // 
            this.gwTienCong.AllowUserToAddRows = false;
            this.gwTienCong.AllowUserToDeleteRows = false;
            this.gwTienCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gwTienCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwTienCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TC_MATC,
            this.TC_TenTC,
            this.TC_GIATIEN});
            this.gwTienCong.Dock = System.Windows.Forms.DockStyle.Top;
            this.gwTienCong.Location = new System.Drawing.Point(0, 0);
            this.gwTienCong.Name = "gwTienCong";
            this.gwTienCong.ReadOnly = true;
            this.gwTienCong.Size = new System.Drawing.Size(565, 203);
            this.gwTienCong.TabIndex = 0;
            // 
            // TC_MATC
            // 
            this.TC_MATC.DataPropertyName = "MATC";
            dataGridViewCellStyle1.NullValue = null;
            this.TC_MATC.DefaultCellStyle = dataGridViewCellStyle1;
            this.TC_MATC.HeaderText = "Mã TC";
            this.TC_MATC.Name = "TC_MATC";
            this.TC_MATC.ReadOnly = true;
            // 
            // TC_TenTC
            // 
            this.TC_TenTC.DataPropertyName = "TENTC";
            this.TC_TenTC.HeaderText = "Tên Tiền Công";
            this.TC_TenTC.Name = "TC_TenTC";
            this.TC_TenTC.ReadOnly = true;
            // 
            // TC_GIATIEN
            // 
            this.TC_GIATIEN.DataPropertyName = "GIATIEN";
            dataGridViewCellStyle2.Format = "N0";
            this.TC_GIATIEN.DefaultCellStyle = dataGridViewCellStyle2;
            this.TC_GIATIEN.HeaderText = "Giá Tiền";
            this.TC_GIATIEN.Name = "TC_GIATIEN";
            this.TC_GIATIEN.ReadOnly = true;
            // 
            // FormTienCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 415);
            this.Controls.Add(this.pnlTienCong);
            this.Name = "FormTienCong";
            this.Text = "FormTienCong";
            this.pnlTienCong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gwTienCong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTienCong;
        private System.Windows.Forms.DataGridView gwTienCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TC_MATC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TC_TenTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TC_GIATIEN;
    }
}