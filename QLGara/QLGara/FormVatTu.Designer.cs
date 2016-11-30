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
            this.gwVatTu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gwVatTu.Location = new System.Drawing.Point(0, 0);
            this.gwVatTu.Name = "gwVatTu";
            this.gwVatTu.ReadOnly = true;
            this.gwVatTu.Size = new System.Drawing.Size(646, 429);
            this.gwVatTu.TabIndex = 0;
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
    }
}