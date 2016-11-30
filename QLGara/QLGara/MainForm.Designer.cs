namespace QLGara
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnUsersList = new DevExpress.XtraBars.BarButtonItem();
            this.btnProfile = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbUsersList = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.superTab = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tabWelcome = new DevComponents.DotNetBar.SuperTabItem();
            this.btnVatTu = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superTab)).BeginInit();
            this.superTab.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnUsersList,
            this.btnProfile,
            this.btnVatTu});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.ribbonControl1.Size = new System.Drawing.Size(1184, 141);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            // 
            // btnUsersList
            // 
            this.btnUsersList.Caption = "Users";
            this.btnUsersList.Id = 3;
            this.btnUsersList.LargeGlyph = global::QLGara.Properties.Resources.apply_32x32;
            this.btnUsersList.LargeWidth = 70;
            this.btnUsersList.Name = "btnUsersList";
            this.btnUsersList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUsersList_ItemClick);
            // 
            // btnProfile
            // 
            this.btnProfile.Caption = "Profile";
            this.btnProfile.Glyph = ((System.Drawing.Image)(resources.GetObject("btnProfile.Glyph")));
            this.btnProfile.Id = 4;
            this.btnProfile.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnProfile.LargeGlyph")));
            this.btnProfile.LargeWidth = 60;
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProfile_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.rbUsersList,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Function";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Glyph = global::QLGara.Properties.Resources.apply_32x32;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnProfile);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnVatTu);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // rbUsersList
            // 
            this.rbUsersList.ItemLinks.Add(this.btnUsersList);
            this.rbUsersList.Name = "rbUsersList";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // superTab
            // 
            this.superTab.CloseButtonOnTabsVisible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTab.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTab.ControlBox.MenuBox.Name = "";
            this.superTab.ControlBox.Name = "";
            this.superTab.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTab.ControlBox.MenuBox,
            this.superTab.ControlBox.CloseBox});
            this.superTab.Controls.Add(this.superTabControlPanel1);
            this.superTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTab.Location = new System.Drawing.Point(0, 141);
            this.superTab.Name = "superTab";
            this.superTab.ReorderTabsEnabled = true;
            this.superTab.SelectedTabFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.superTab.SelectedTabIndex = 0;
            this.superTab.Size = new System.Drawing.Size(1184, 540);
            this.superTab.TabFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.superTab.TabIndex = 1;
            this.superTab.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tabWelcome});
            this.superTab.Text = "superTab";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.panelControl1);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(1184, 514);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.tabWelcome;
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1184, 514);
            this.panelControl1.TabIndex = 0;
            // 
            // tabWelcome
            // 
            this.tabWelcome.AttachedControl = this.superTabControlPanel1;
            this.tabWelcome.CloseButtonVisible = false;
            this.tabWelcome.GlobalItem = false;
            this.tabWelcome.Name = "tabWelcome";
            this.tabWelcome.Text = "Welcome";
            // 
            // btnVatTu
            // 
            this.btnVatTu.Caption = "Vật Tư";
            this.btnVatTu.Glyph = ((System.Drawing.Image)(resources.GetObject("btnVatTu.Glyph")));
            this.btnVatTu.Id = 8;
            this.btnVatTu.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnVatTu.LargeGlyph")));
            this.btnVatTu.LargeWidth = 60;
            this.btnVatTu.Name = "btnVatTu";
            this.btnVatTu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVatTu_ItemClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.superTab);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superTab)).EndInit();
            this.superTab.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbUsersList;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnUsersList;
        private DevExpress.XtraBars.BarButtonItem btnProfile;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevComponents.DotNetBar.SuperTabControl superTab;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem tabWelcome;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.BarButtonItem btnVatTu;
    }
}