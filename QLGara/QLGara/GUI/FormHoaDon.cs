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
using Entity;

namespace QLGara
{
    public partial class FormHoaDon : MyFormPage
    {
        BUS_PhieuThanhToan ptt = new BUS_PhieuThanhToan();
        public FormHoaDon()
        {
            InitializeComponent();
            this.pnl = this.pnlHoaDon;

            this.gwHoaDon.DataSource = ptt.getHoaDon();
            this.gw.DataSource = ptt.getHoaDon();
        }
    }
}
