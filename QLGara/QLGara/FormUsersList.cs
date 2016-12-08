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

namespace QLGara
{
    public partial class FormUsersList : MyFormPage
    {
        BUS_Users us = new BUS_Users();
        public FormUsersList()
        {
            InitializeComponent();
            this.setupProperties();
        }

        private void setupProperties()
        {
            this.pnl = this.pnlUsers;
            DataTable dt = us.GetData();
            this.gvUsers.DataSource = Utility.Instance.changeGender(dt, "GENDER");
            
        }
    }
}