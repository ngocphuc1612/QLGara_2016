using BUS;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGara
{
    public partial class FormPhuTung : MyFormPage
    {
        BUS_VatTu vt = new BUS_VatTu();
        public FormPhuTung()
        {
            InitializeComponent();
            this.pnl = this.pnlPhuTung;
            this.gwPhuTung.AutoGenerateColumns = false;
            this.gwPhuTung.DataSource = vt.GetData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chăc muốn xóa vật tư này?", "Xác nhận:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (vt.delVatTu(Int32.Parse(this.txtID.Text)) == true)
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gwPhuTung.DataSource = vt.GetData();
                }
                else
                    MessageBox.Show("Không thể xóa!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gwPhuTung_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in gwPhuTung.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                txtID.Text = row.Cells["MAVT"].Value.ToString();
                txtTen.Text = row.Cells["TENVT"].Value.ToString();
                txtSoLuong.Text = row.Cells["SL"].Value.ToString();
                txtGiaBan.Text = row.Cells["DONGIA"].Value.ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.gwPhuTung.DataSource = vt.searchVatTu(this.txtTimKiem.Text);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            string maVt = this.txtID.Text;
            string tenVt = this.txtTen.Text;
            string donGia = this.txtGiaBan.Text;
            string sl = this.txtSoLuong.Text;

            if (maVt == "" || tenVt == "" || donGia == "" || sl == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            double dg = 0;
            int sluog = 0;
            try
            {
                dg = Double.Parse(donGia);
                sluog = Int32.Parse(sl);
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại Đơn giá và Số lượng!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Entity_VatTu _vt = new Entity_VatTu(Int32.Parse(maVt), tenVt, dg, sluog);
            if (vt.updateVatTu(_vt) == true)
            {
                MessageBox.Show("Lưu thành công Vật tư " + _vt.TenVt, "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gwPhuTung.DataSource = vt.GetData();
            }
            else
                MessageBox.Show("Không thể lưu!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtTen = null;
            this.txtSoLuong = null;
            this.txtGiaBan = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.txtTen = null;
            this.txtSoLuong = null;
            this.txtGiaBan = null;
        }
    }
}
