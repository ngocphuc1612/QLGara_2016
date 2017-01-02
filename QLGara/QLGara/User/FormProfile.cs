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

namespace QLGara
{
    public partial class FormProfile : MyFormPage
    {
        public FormProfile()
        {
            InitializeComponent();
            this.setupView();
        }

        private void setupView()
        {
            Entity_User getUser = LoginForm.MyProfile;
            this.pnl = this.pnlProfile;
            //this.lblFullname.Text = getUser.FullName;
            //this.lblUsername.Text = getUser.Username;
            //this.lblEmail.Text = getUser.Email;
            //this.lblGender.Text = getUser.Gender ? "Nam" : "Nữ";
            //this.lblPhone.Text = getUser.Phone;
            //this.lblDirection.Text = getUser.Direction;
            //this.lblBirthday.Text = getUser.Birthday.ToShortDateString();

        }
    }
}