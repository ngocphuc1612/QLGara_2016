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
            this.layoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.layoutGroup1 = new DevComponents.DotNetBar.Layout.LayoutGroup();
            this.layoutGroup2 = new DevComponents.DotNetBar.Layout.LayoutGroup();
            this.txtHieuXe = new System.Windows.Forms.TextBox();
            this.layoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.txtHopSo = new System.Windows.Forms.TextBox();
            this.layoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.cbbSoCua = new System.Windows.Forms.ComboBox();
            this.layoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.txtDanDong = new System.Windows.Forms.TextBox();
            this.layoutControlItem4 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.txtNhienLieu = new System.Windows.Forms.TextBox();
            this.layoutControlItem5 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.cbbSoGhe = new System.Windows.Forms.ComboBox();
            this.layoutControlItem6 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.txtKieuDang = new System.Windows.Forms.TextBox();
            this.layoutControlItem7 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutGroup3 = new DevComponents.DotNetBar.Layout.LayoutGroup();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.layoutSpacerItem1 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            this.layoutControlItem8 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem9 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem10 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem11 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.pnlDongXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwDongXe)).BeginInit();
            this.layoutControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDongXe
            // 
            this.pnlDongXe.Controls.Add(this.layoutControl1);
            this.pnlDongXe.Controls.Add(this.gwDongXe);
            this.pnlDongXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDongXe.Location = new System.Drawing.Point(0, 0);
            this.pnlDongXe.Name = "pnlDongXe";
            this.pnlDongXe.Size = new System.Drawing.Size(817, 464);
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
            this.gwDongXe.Size = new System.Drawing.Size(817, 174);
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
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtKieuDang);
            this.layoutControl1.Controls.Add(this.cbbSoGhe);
            this.layoutControl1.Controls.Add(this.txtNhienLieu);
            this.layoutControl1.Controls.Add(this.txtDanDong);
            this.layoutControl1.Controls.Add(this.cbbSoCua);
            this.layoutControl1.Controls.Add(this.txtHopSo);
            this.layoutControl1.Controls.Add(this.txtHieuXe);
            this.layoutControl1.Controls.Add(this.btnThemMoi);
            this.layoutControl1.Controls.Add(this.btnSua);
            this.layoutControl1.Controls.Add(this.btnLuu);
            this.layoutControl1.Controls.Add(this.btnXoa);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 174);
            this.layoutControl1.Name = "layoutControl1";
            // 
            // 
            // 
            this.layoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.layoutGroup1,
            this.layoutGroup2,
            this.layoutGroup3,
            this.layoutSpacerItem1,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.layoutControlItem11});
            this.layoutControl1.Size = new System.Drawing.Size(817, 257);
            this.layoutControl1.TabIndex = 1;
            // 
            // layoutGroup1
            // 
            this.layoutGroup1.Height = 170;
            this.layoutGroup1.MinSize = new System.Drawing.Size(30, 32);
            this.layoutGroup1.Name = "layoutGroup1";
            this.layoutGroup1.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            this.layoutGroup1.Width = 40;
            // 
            // layoutGroup2
            // 
            this.layoutGroup2.Height = 100;
            this.layoutGroup2.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem5,
            this.layoutControlItem7});
            this.layoutGroup2.MinSize = new System.Drawing.Size(120, 32);
            this.layoutGroup2.Name = "layoutGroup2";
            this.layoutGroup2.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            this.layoutGroup2.Width = 60;
            this.layoutGroup2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // txtHieuXe
            // 
            this.txtHieuXe.Location = new System.Drawing.Point(109, 8);
            this.txtHieuXe.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.txtHieuXe.Name = "txtHieuXe";
            this.txtHieuXe.Size = new System.Drawing.Size(389, 20);
            this.txtHieuXe.TabIndex = 1;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtHieuXe;
            this.layoutControlItem1.Height = 28;
            this.layoutControlItem1.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Text = "Hiệu xe:";
            this.layoutControlItem1.Width = 100;
            this.layoutControlItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // txtHopSo
            // 
            this.txtHopSo.Location = new System.Drawing.Point(109, 36);
            this.txtHopSo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.txtHopSo.Name = "txtHopSo";
            this.txtHopSo.Size = new System.Drawing.Size(389, 20);
            this.txtHopSo.TabIndex = 2;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtHopSo;
            this.layoutControlItem2.Height = 28;
            this.layoutControlItem2.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Text = "Hộp số:";
            this.layoutControlItem2.Width = 100;
            this.layoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // cbbSoCua
            // 
            this.cbbSoCua.FormattingEnabled = true;
            this.cbbSoCua.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbbSoCua.Location = new System.Drawing.Point(109, 64);
            this.cbbSoCua.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.cbbSoCua.Name = "cbbSoCua";
            this.cbbSoCua.Size = new System.Drawing.Size(60, 21);
            this.cbbSoCua.TabIndex = 3;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cbbSoCua;
            this.layoutControlItem3.Height = 29;
            this.layoutControlItem3.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Text = "Số cửa:";
            this.layoutControlItem3.Width = 129;
            // 
            // txtDanDong
            // 
            this.txtDanDong.Location = new System.Drawing.Point(238, 64);
            this.txtDanDong.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.txtDanDong.Name = "txtDanDong";
            this.txtDanDong.Size = new System.Drawing.Size(260, 20);
            this.txtDanDong.TabIndex = 4;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtDanDong;
            this.layoutControlItem4.Height = 28;
            this.layoutControlItem4.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Text = "Dẫn động:";
            this.layoutControlItem4.Width = 100;
            this.layoutControlItem4.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // txtNhienLieu
            // 
            this.txtNhienLieu.Location = new System.Drawing.Point(238, 93);
            this.txtNhienLieu.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.txtNhienLieu.Name = "txtNhienLieu";
            this.txtNhienLieu.Size = new System.Drawing.Size(260, 20);
            this.txtNhienLieu.TabIndex = 6;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtNhienLieu;
            this.layoutControlItem5.Height = 28;
            this.layoutControlItem5.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Text = "Nhiên liệu:";
            this.layoutControlItem5.Width = 100;
            this.layoutControlItem5.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // cbbSoGhe
            // 
            this.cbbSoGhe.FormattingEnabled = true;
            this.cbbSoGhe.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "5",
            "6",
            "7",
            "10",
            "16",
            "24",
            "32"});
            this.cbbSoGhe.Location = new System.Drawing.Point(109, 93);
            this.cbbSoGhe.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.cbbSoGhe.Name = "cbbSoGhe";
            this.cbbSoGhe.Size = new System.Drawing.Size(60, 21);
            this.cbbSoGhe.TabIndex = 5;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.cbbSoGhe;
            this.layoutControlItem6.Height = 29;
            this.layoutControlItem6.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Text = "Số ghế:";
            this.layoutControlItem6.Width = 129;
            // 
            // txtKieuDang
            // 
            this.txtKieuDang.Location = new System.Drawing.Point(109, 122);
            this.txtKieuDang.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.txtKieuDang.Name = "txtKieuDang";
            this.txtKieuDang.Size = new System.Drawing.Size(389, 20);
            this.txtKieuDang.TabIndex = 7;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtKieuDang;
            this.layoutControlItem7.Height = 28;
            this.layoutControlItem7.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Text = "Kiểu dáng:";
            this.layoutControlItem7.Width = 100;
            this.layoutControlItem7.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutGroup3
            // 
            this.layoutGroup3.Height = 100;
            this.layoutGroup3.MinSize = new System.Drawing.Size(120, 32);
            this.layoutGroup3.Name = "layoutGroup3";
            this.layoutGroup3.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            this.layoutGroup3.Width = 40;
            this.layoutGroup3.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(353, 174);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 24);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(270, 174);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 24);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(187, 174);
            this.btnSua.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 24);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.AllowDrop = true;
            this.btnThemMoi.AutoEllipsis = true;
            this.btnThemMoi.Location = new System.Drawing.Point(104, 174);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 24);
            this.btnThemMoi.TabIndex = 11;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            // 
            // layoutSpacerItem1
            // 
            this.layoutSpacerItem1.Height = 32;
            this.layoutSpacerItem1.Name = "layoutSpacerItem1";
            this.layoutSpacerItem1.Width = 100;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnThemMoi;
            this.layoutControlItem8.Height = 31;
            this.layoutControlItem8.MinSize = new System.Drawing.Size(32, 20);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Width = 83;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnSua;
            this.layoutControlItem9.Height = 31;
            this.layoutControlItem9.MinSize = new System.Drawing.Size(32, 20);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Width = 83;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.btnLuu;
            this.layoutControlItem10.Height = 31;
            this.layoutControlItem10.MinSize = new System.Drawing.Size(32, 20);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Width = 83;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.btnXoa;
            this.layoutControlItem11.Height = 31;
            this.layoutControlItem11.MinSize = new System.Drawing.Size(32, 20);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Width = 83;
            // 
            // FormDongXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 464);
            this.Controls.Add(this.pnlDongXe);
            this.Name = "FormDongXe";
            this.Text = "FormDongXe";
            this.pnlDongXe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gwDongXe)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            this.layoutControl1.PerformLayout();
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
        private DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;
        private System.Windows.Forms.TextBox txtKieuDang;
        private System.Windows.Forms.ComboBox cbbSoGhe;
        private System.Windows.Forms.TextBox txtNhienLieu;
        private System.Windows.Forms.TextBox txtDanDong;
        private System.Windows.Forms.ComboBox cbbSoCua;
        private System.Windows.Forms.TextBox txtHopSo;
        private System.Windows.Forms.TextBox txtHieuXe;
        private DevComponents.DotNetBar.Layout.LayoutGroup layoutGroup1;
        private DevComponents.DotNetBar.Layout.LayoutGroup layoutGroup2;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;
        private DevComponents.DotNetBar.Layout.LayoutGroup layoutGroup3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThemMoi;
        private DevComponents.DotNetBar.Layout.LayoutSpacerItem layoutSpacerItem1;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem11;
    }
}