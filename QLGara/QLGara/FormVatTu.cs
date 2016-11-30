using System;
using System.Data;
using BUS;

namespace QLGara
{
    public partial class FormVatTu : MyFormPage
    {
        BUS_VatTu vt = new BUS_VatTu();
        public FormVatTu()
        {
            InitializeComponent();
            this.pnl = this.pnlVatTu;
            this.gwVatTu.DataSource = vt.GetData();
        }
    }
}