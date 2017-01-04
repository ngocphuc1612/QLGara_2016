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
    public partial class FormPhieuSC : MyFormPage
    {
        private BUS_PhieuSuaChua psc = new BUS_PhieuSuaChua();
        public FormPhieuSC()
        {
            InitializeComponent();
            this.pnl = this.pnlPhieuSC;
            //this.gwPhieuSC.DataSource = psc.getData();
        }
    }
}
