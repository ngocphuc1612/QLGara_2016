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
    public partial class FormHieuXe : MyFormPage
    {
        BUS_HieuXe hx = new BUS_HieuXe();
        public FormHieuXe()
        {
            InitializeComponent();
            this.pnl = pnlHieuXe;
            this.gwHieuXe.DataSource = hx.getData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maHx = this.txtMaHX.Text;
            string tenHx = this.txtTenHX.Text;
            if (maHx == "" || tenHx == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Entity_HieuXe _hx = new Entity_HieuXe(Int32.Parse(maHx), tenHx);
            if (hx.insertHieuXe(_hx) == true)
            {
                MessageBox.Show("Thêm thành công Hiệu xe " + _hx.TenHx, "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gwHieuXe.DataSource = hx.getData();
            }
            else
                MessageBox.Show("Không thể thêm!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maHx = this.txtMaHX.Text;
            string tenHx = this.txtTenHX.Text;
            Entity_HieuXe _hx = new Entity_HieuXe(Int32.Parse(maHx), tenHx);
            if (hx.delHieuXe(maHx) == true)
            {
                MessageBox.Show("Xóa thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gwHieuXe.DataSource = hx.getData();
            }
            else
                MessageBox.Show("Không thể xóa!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maHx = this.txtMaHX.Text;
            string tenHx = this.txtTenHX.Text;
            if (maHx == "" || tenHx == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Entity_HieuXe _hx = new Entity_HieuXe(Int32.Parse(maHx), tenHx);
            if (hx.updateHieuXe(_hx) == true)
            {
                MessageBox.Show("Sửa thành công Hiệu xe " + _hx.TenHx, "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gwHieuXe.DataSource = hx.getData();
            }
            else
                MessageBox.Show("Không thể sửa!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
