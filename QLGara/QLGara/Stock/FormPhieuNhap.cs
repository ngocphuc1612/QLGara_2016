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
    public partial class FormPhieuNhap : MyFormPage
    {
        private BUS_PhieuNhap pn = new BUS_PhieuNhap();
        public FormPhieuNhap()
        {
            InitializeComponent();
            this.pnl = this.pnlPhieuNhap;
            this.gwPhieuNhap.AutoGenerateColumns = false;
            this.gwPhieuNhap.DataSource = pn.getData();
        }
    }
}
