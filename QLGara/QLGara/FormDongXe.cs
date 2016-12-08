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
    public partial class FormDongXe : MyFormPage
    {
        private BUS_DongXe dx = new BUS_DongXe();
        public FormDongXe()
        {
            InitializeComponent();
            this.pnl = pnlDongXe;
            this.gwDongXe.DataSource = dx.getData();
        }
    }
}
