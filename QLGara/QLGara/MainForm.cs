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

        private void btnListCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Danh mục khách hàng"))
            {
                SuperTabItem t = superTab.CreateTab("Danh mục khách hàng");
                FormKhachHang frm = new FormKhachHang();
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

        private void btnListPartner_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Danh mục nhà cung cấp"))
            {
                SuperTabItem t = superTab.CreateTab("Danh mục nhà cung cấp");
                FormNhaCungCap frm = new FormNhaCungCap();
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

        private void btnListAccessary_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void btnListCar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Danh mục Xe"))
            {
                SuperTabItem t = superTab.CreateTab("Danh mục Xe");
                FormXe frm = new FormXe();
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

        private void btnListCarBrand_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckOpenTabs("Danh mục dòng xe"))
            {
                SuperTabItem t = superTab.CreateTab("Danh mục dòng xe");
                FormDongXe frm = new FormDongXe();
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

        private void btnAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Phần mềm được xây dựng bởi nhóm 37\n Võ Văn Cường \n Đỗ Trung Hiếu \n Trần Bình Minh\n Trần Ngọc Phúc", "Giới thiệu",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnSupport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string guide = "1. Quản lý Gara \n";
            guide += "2. Quản lý Kho \n";
            guide += "3. Danh mục thống kê \n";
            guide += "4. Báo cáo \n";
            guide += "5. Thành viên \n";
            guide += "6. Hệ thống \n";
            guide += "7. Trợ giúp \n";
            MessageBox.Show(guide, "Hướng dẫn sử dụng",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}