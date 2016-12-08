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
    public partial class FormCTPhieuNhap : MyFormPage
    {
        private BUS_CTPhieuNhap ct = new BUS_CTPhieuNhap();
        public FormCTPhieuNhap()
        {
            InitializeComponent();
            this.pnl = this.pnlCTPhieuNhap;
            this.gwCTPhieuNhap.DataSource = ct.getData();
        }
    }
}
