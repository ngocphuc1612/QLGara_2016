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
    public partial class FormKhachHang : MyFormPage
    {
        private BUS_KhachHang kh = new BUS_KhachHang();
        public FormKhachHang()
        {
            InitializeComponent();
            this.pnl = this.pnlKhachHang;
            this.gwKhachHang.AutoGenerateColumns = false;
            this.gwKhachHang.DataSource = kh.getData();
        }
    }
}
