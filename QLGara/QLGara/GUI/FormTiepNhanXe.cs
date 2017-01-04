using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGara
{
    public partial class FormTiepNhanXe : MyFormPage
    {
        private BUS_Xe xe = new BUS_Xe();
        private BUS_DongXe dx = new BUS_DongXe();
        public FormTiepNhanXe()
        {
            InitializeComponent();
            this.pnl = this.pnlTiepNhanXe;
            setProperty();
        }

        private void setProperty()
        {
            DataTable dt = xe.getData();
            this.gwXe.AutoGenerateColumns = false;
            this.gwXe.DataSource = dt;
        }
    }
}
