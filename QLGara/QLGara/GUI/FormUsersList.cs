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
    public partial class FormUsersList : MyFormPage
    {
        BUS_Users us = new BUS_Users();
        BUS_ROLES rl = new BUS_ROLES();
        public FormUsersList()
        {
            InitializeComponent();
            this.setupProperties();
        }

        private void setupProperties()
        {
            this.pnl = this.pnlUsers;
            DataTable dt = us.GetData();
            this.gvUsers.AutoGenerateColumns = false;
            this.gvUsers.DataSource = Utility.Instance.changeGender(dt, "GENDER");

            getCbb();

        }

        private void getCbb()
        {
            this.cbbRole.DataSource = rl.GetData();
            this.cbbRole.DisplayMember = "ROLE_NAME";
            this.cbbRole.ValueMember = "ROLE_ID";
        }

        private void gvUsers_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in gvUsers.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {

                DataGridViewRow row = cell.OwningRow;

                this.txtID.Text = row.Cells["USER_ID"].Value.ToString();
                this.txtUsername.Text = row.Cells["USERNAME"].Value.ToString();
                this.txtEmail.Text = row.Cells["EMAIL"].Value.ToString();
                try
                {
                    this.dtDoB.Value = Convert.ToDateTime(row.Cells["BIRTHDAY"].Value);
                } catch
                {
                    this.dtDoB.Value = DateTime.Now;
                }
                this.txtName.Text = row.Cells["FULL_NAME"].Value.ToString();
                this.txtPhone.Text = row.Cells["PHONE"].Value.ToString();
                this.txtAddress.Text = row.Cells["DIRECTION"].Value.ToString();
                this.cbbRole.SelectedValue = row.Cells["ROLE_ID"].Value;
                
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string id = this.txtID.Text;
            string userName = this.txtUsername.Text;
            string pass = this.txtPass.Text;
            string comfirm = this.txtComfirm.Text;
            string email = this.txtEmail.Text;
            string name = this.txtName.Text;
            DateTime dob = this.dtDoB.Value;
            bool gender = this.rdNam.Checked ? true : false;
            string sdt = this.txtPhone.Text;
            string address = this.txtAddress.Text;
            string role = this.cbbRole.SelectedValue.ToString();
            if (id == "" || userName == "" || pass == "" || comfirm == "" || email == "" || name == "" )
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (pass != comfirm)
            {
                MessageBox.Show("Vui lòng điền xác nhận lại mật khẩu!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtPass.Text = "";
                this.txtComfirm.Text = "";
                return;
            }

            int idUser = Utility.Instance.autoKey(gvUsers);

            Entity_User _us = new Entity_User(idUser, userName,email,pass,Int32.Parse(role), gender, dob,name, sdt, address);
            if(us.insertUser(_us) == true)
            {
                MessageBox.Show("Thêm thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gvUsers.DataSource = us.GetData();
            } else
            {
                MessageBox.Show("Không thể thêm!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}