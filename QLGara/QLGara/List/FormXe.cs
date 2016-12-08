using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace QLGara
{
    public partial class FormXe : MyFormPage
    {
        private BUS_Xe xe = new BUS_Xe();
        public FormXe()
        {
            InitializeComponent();
            this.pnl = this.pnlXe;
            this.gwXe.DataSource = xe.getData();
        }
    }
}
