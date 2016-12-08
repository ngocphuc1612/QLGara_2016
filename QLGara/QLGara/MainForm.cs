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
            int roleId = LoginForm.MyProfile.Role;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        private void btnYourProfile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Hồ sơ của bạn"))
            {
                SuperTabItem t = superTab.CreateTab("Hồ sơ của bạn");
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

        private void btnListAccessary_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Danh mục phụ tùng"))
            {
                SuperTabItem t = superTab.CreateTab("Danh mục phụ tùng");
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

        private void btnAllUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Danh mục tài khoản"))
            {
                SuperTabItem t = superTab.CreateTab("Danh mục tài khoản");
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

        private void btnNewUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void superTab_SelectedTabChanged(object sender, SuperTabStripSelectedTabChangedEventArgs e)
        {

        }
    }
}