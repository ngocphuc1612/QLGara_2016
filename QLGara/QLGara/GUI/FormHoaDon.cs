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
                //DataTable dt = new DataTable();
                //dt = hd_psc.findByID(psc_id);
                //this.gw2.DataSource = dt;
                this.cbbKH.DataSource = hd_kh.getData();
                this.cbbKH.DisplayMember = "KH_TEN";
                this.cbbKH.ValueMember = "KH_ID";
                this.cbbKH.SelectedText = row.Cells["KH_TEN"].Value.ToString();
                this.txtTong.Text = row.Cells["TONGTIEN"].Value.ToString();
                this.txtBienSo.Text = row.Cells["BIENSO"].Value.ToString();
                this.txtMaPSC.Text = row.Cells["MAPSC"].Value.ToString();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            this.gwHoaDon.DataSource = ptt.searchHoaDon(this.txtTimKiem.Text);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int maPsc = 1;
            int maPtt = 1;

            if (this.txtMaPSC.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                maPsc = Int32.Parse(this.txtMaPSC.Text);
                maPtt = Utility.Instance.autoKey(gwHoaDon);
            } catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Entity_PhieuThanhToan _ptt = new Entity_PhieuThanhToan(maPtt, maPsc);
            if (ptt.insertHoaDon(_ptt) == true)
            {
                MessageBox.Show("Lưu thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.gwHoaDon.DataSource = ptt.getHoaDon();
                this.btnLuu.Enabled = true;
            } else
            {
                MessageBox.Show("Có lỗi xảy ra, không thể lưu hóa đơn!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            this.txtBienSo.Text = "";
            this.txtTong.Text = "";
            this.txtMaPSC.Text = "";
            this.txtID.Text = Utility.Instance.autoKey(gwHoaDon).ToString();
            this.btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chăc muốn xóa?", "Xác nhận:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //if (ptt.(Int32.Parse(this.txtMaVT.Text)) == true)
                if ( 1 == 2 )
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //gwVatTu.DataSource = vt.GetData();
                }
                else
                    MessageBox.Show("Không thể xóa!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
