using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGara
{
    public class MyFormPage : Form
    {
        public Panel pnl;
    }

    public partial class MyTabPage : TabPage
    {
        private Form frm;
        public MyTabPage(MyFormPage frm_contensido)
        {
            this.frm = frm_contensido;
            this.Controls.Add(frm_contensido.pnl);
            this.Text = frm_contensido.Text;
        }

    }
}
