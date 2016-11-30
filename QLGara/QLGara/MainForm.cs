using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Entity;
using BUS;
using DevComponents.DotNetBar;

namespace QLGara
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        //Declarations
        BUS_ROLES rl = new BUS_ROLES();
        BUS_Users us = new BUS_Users();
        public MainForm()
        {
            InitializeComponent();
            //this.tabProfile.CloseButtonVisible = true;
            int roleId = LoginForm.MyProfile.Role;

            if (roleId > 3)
            {
                this.rbUsersList.Visible = false;
            }
            else
            {
                this.rbUsersList.Visible = true;
            }

            //cbbRoles.DataSource = rl.GetData();
            //cbbRoles.DisplayMember = "ROLE_NAME";
            //cbbRoles.ValueMember = "ROLE_ID";

            //initiated
            //grUsers.DataSource = us.GetData();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnUsersList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("UsersList"))
            {
                SuperTabItem t = superTab.CreateTab("UsersList");
                FormUsersList frm = new FormUsersList();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm.pnl);
                frm.Show();
                superTab.SelectedTabIndex = superTab.Tabs.Count - 1;
            }
            else
                superTab.TabIndex = superTab.Tabs.Count - 1;
        }

        public bool CheckOpenTabs(string name)
        {
            for (int i = 0; i < superTab.Tabs.Count; i++)
            {
                if (superTab.Tabs[i].Text == name)
                {
                    superTab.SelectedTabIndex = i;
                    return true;
                }
            }
            return false;
        }

        private void btnProfile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Profile"))
            {
                SuperTabItem t = superTab.CreateTab("Profile");
                FormProfile frm = new FormProfile();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm.pnl);
                frm.Show();
                superTab.SelectedTabIndex = superTab.Tabs.Count - 1;
            }
            else
                superTab.TabIndex = superTab.Tabs.Count - 1;
        }

        private void btnVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Vật Tư"))
            {
                SuperTabItem t = superTab.CreateTab("Vật Tư");
                FormVatTu frm = new FormVatTu();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm.pnl);
                frm.Show();
                superTab.SelectedTabIndex = superTab.Tabs.Count - 1;
            }
            else
                superTab.TabIndex = superTab.Tabs.Count - 1;
        }
    }
}