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
    public partial class FormPhieuTT : MyFormPage
    {
        private BUS_PhieuThanhToan ptt = new BUS_PhieuThanhToan();
        public FormPhieuTT()
        {
            InitializeComponent();
            this.pnl = this.pnlPhieuTT;
            this.gwPhieuTT.DataSource = ptt.getData();
        }
    }
}
