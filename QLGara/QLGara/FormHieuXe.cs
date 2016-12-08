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
    public partial class FormHieuXe : MyFormPage
    {
        BUS_HieuXe hx = new BUS_HieuXe();
        public FormHieuXe()
        {
            InitializeComponent();
            this.pnl = pnlHieuXe;
            this.gwHieuXe.DataSource = hx.getData();
        }
    }
}
