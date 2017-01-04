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
        BUS_KhachHang hd_kh = new BUS_KhachHang();
        BUS_PhieuSuaChua hd_psc = new BUS_PhieuSuaChua();
        public FormHoaDon()
        {
            InitializeComponent();
            this.pnl = this.pnlHoaDon;

            this.gwHoaDon.AutoGenerateColumns = false;
            this.gwHoaDon.DataSource = ptt.getHoaDon();
        }

        private void gwHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in gwHoaDon.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {

                DataGridViewRow row = cell.OwningRow;

                string psc_id = row.Cells["MAPSC"].Value.ToString();
                this.txtID.Text = psc_id;
                DataTable dt = new DataTable();
                dt = hd_psc.findByID(psc_id);
                this.gw2.DataSource = dt;
                //this.cbbKH.DataSource = hd_kh.getData();
                //this.cbbKH.DisplayMember = "KH_TEN";
                //this.cbbKH.ValueMember = "KH_ID";
                //this.cbbKH.SelectedValue = kh_id;
                this.txtTong.Text = row.Cells["TONGTIEN"].Value.ToString();
            }
        }
    }
}
