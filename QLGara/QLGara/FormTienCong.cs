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
    public partial class FormTienCong : MyFormPage
    {
        private BUS_TienCong tc = new BUS_TienCong();
        public FormTienCong()
        {
            InitializeComponent();
            this.pnl = pnlTienCong;
            this.gwTienCong.DataSource = tc.getData();
        }
    }
}
