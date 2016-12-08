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
    public partial class FormCTPSC : MyFormPage
    {
        private BUS_CTPSC ct = new BUS_CTPSC();
        public FormCTPSC()
        {
            InitializeComponent();
            this.pnl = this.pnlCTPSC;
            this.gwCTPSC.DataSource = ct.getData();
        }
    }
}
