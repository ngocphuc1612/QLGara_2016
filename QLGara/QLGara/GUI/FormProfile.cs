using System;
using System.Windows.Forms;
using Entity;
using BUS;

namespace QLGara
{
    public partial class FormProfile : MyFormPage
    {
        BUS_Users us = new BUS_Users();
        public FormProfile()
        {
            InitializeComponent();
            this.setupView();
        }

        private void setupView()
        {

            this.pnl = this.pnlProfile;

            Entity_User getUser = LoginForm.MyProfile;
            this.txtUsername.Text = getUser.Username;
            this.txtEmail.Text = getUser.Email;
            this.txtName.Text = getUser.FullName;

            BUS_ROLES rl = new BUS_ROLES();
            this.cbbQuyenHan.DataSource = rl.GetData();
            this.cbbQuyenHan.DisplayMember = "ROLE_NAME";
            this.cbbQuyenHan.ValueMember = "ROLE_ID";
            this.cbbQuyenHan.SelectedValue = getUser.Role;
            this.dtDob.Text = getUser.Birthday.ToString();
            this.txtAddress.Text = getUser.Direction;
            this.txtPhone.Text = getUser.Phone;           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = this.txtPass.Text;
            string comfirm = this.txtComfirm.Text;
            if (pass == comfirm && pass != "")
            {

                LoginForm.MyProfile.update(this.txtEmail.Text, this.txtPass.Text, this.txtPhone.Text, this.txtAddress.Text);
                if(us.updateProfile(LoginForm.MyProfile) == true)
                {
                    MessageBox.Show("Sửa thông tin thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                } else
                {
                    MessageBox.Show("Có lỗi xảy ra, không thể sủa thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            } else
            {
                MessageBox.Show("Mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}