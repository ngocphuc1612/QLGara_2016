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
    public partial class FormNhapPhuTungCT : MyFormPage
    {
        private BUS_CTPhieuNhap ct = new BUS_CTPhieuNhap();
        public FormNhapPhuTungCT()
        {
            InitializeComponent();
            this.pnl = this.pnlCTPhieuNhap;
            this.gwCTPhieuNhap.AutoGenerateColumns = false;

            this.gwCTPhieuNhap.DataSource = ct.getData();
        }
    }
}
