using System;
using System.Data;
using BUS;
using Entity;
using System.Windows.Forms;

namespace QLGara
{
    public partial class FormVatTu : MyFormPage
    {
        BUS_VatTu vt = new BUS_VatTu();
        public FormVatTu()
        {
            InitializeComponent();
            this.pnl = this.pnlVatTu;
            this.gwVatTu.AutoGenerateColumns = false;
            this.gwVatTu.DataSource = vt.GetData();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string maVt = this.txtMaVT.Text;
            string tenVt = this.txtTenVT.Text;
            string donGia = this.txtDonGia.Text;
            string sl = this.txtSoLuong.Text;

            if (maVt == "" || tenVt == "" || donGia == "" || sl == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int maVatTu = 1;
            double dg = 0;
            int sluog = 0;
            try
            {
                maVatTu = Utility.Instance.autoKey(gwVatTu); 
                dg = Double.Parse(donGia);
                sluog = Int32.Parse(sl);
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại Đơn giá và Số lượng!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Entity_VatTu _vt = new Entity_VatTu(maVatTu, tenVt, dg, sluog);
            if (vt.insertVatTu(_vt) == true)
            {
                MessageBox.Show("Thêm thành công Vật tư " + _vt.TenVt, "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gwVatTu.DataSource = vt.GetData();
            }
            else
                MessageBox.Show("Không thể thêm!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maVt = this.txtMaVT.Text;
            string tenVt = this.txtTenVT.Text;
            string donGia = this.txtDonGia.Text;
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
            } catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại Đơn giá và Số lượng!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Entity_VatTu _vt = new Entity_VatTu(Int32.Parse(maVt), tenVt, dg, sluog);
            if (vt.updateVatTu(_vt) == true)
            {
                MessageBox.Show("Sửa thành công Vật tư " + _vt.TenVt, "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gwVatTu.DataSource = vt.GetData();
            }
            else
                MessageBox.Show("Không thể sửa!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chăc muốn xóa vật tư này?", "Xác nhận:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (vt.delVatTu(Int32.Parse(this.txtMaVT.Text)) == true)
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gwVatTu.DataSource = vt.GetData();
                }
                else
                    MessageBox.Show("Không thể xóa!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gwVatTu_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in gwVatTu.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {

                DataGridViewRow row = cell.OwningRow;
                txtMaVT.Text = row.Cells["VT_MAVT"].Value.ToString();
                txtTenVT.Text = row.Cells["VT_TENVT"].Value.ToString();
                txtSoLuong.Text = row.Cells["VT_SL"].Value.ToString();
                txtDonGia.Text = row.Cells["VT_DONGIA"].Value.ToString();
            }
        }

        private void txtSearchVT_TextChanged(object sender, EventArgs e)
        {
            this.gwVatTu.DataSource = vt.searchVatTu(this.txtSearchVT.Text);
        }

        //private void txtSearch_TextChanged(object sender, EventArgs e)
        //{
        //    this.gwVatTu.DataSource = vt.searchVatTu(this.txtSearch.Text);
        //}
    }
}