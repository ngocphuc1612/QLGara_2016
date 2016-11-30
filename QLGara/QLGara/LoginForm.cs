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
using BUS;
using Entity;

namespace QLGara
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        BUS_Users us = new BUS_Users();
        DataTable dt = new DataTable();
        public static Entity_User MyProfile;
        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = this.btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = this.txtUsername.Text;
            string password = this.txtPassword.Text;

            if (username != "" && password != "")
            {
                try
                {
                    DataRow dr;
                    dt = us.login(username, password);
                    dr = dt.Rows[0];
                    MyProfile = new Entity_User(dr);
                    
                    MainForm frmMain = new MainForm();
                    this.Hide();
                    frmMain.Show();
                }
                catch
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            } else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}