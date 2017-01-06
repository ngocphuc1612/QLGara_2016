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
    public partial class FormDongXe : MyFormPage
    {
        private BUS_DongXe dx = new BUS_DongXe();
        public FormDongXe()
        {
            InitializeComponent();
            this.pnl = pnlDongXe;
            this.gwDongXe.AutoGenerateColumns = false;
            this.gwDongXe.DataSource = dx.getData();
            this.btn_Luu.Enabled = false;
        }

        private void gwDongXe_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in gwDongXe.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {

                DataGridViewRow row = cell.OwningRow;

                this.txtID.Text = row.Cells["DONGXE_ID"].Value.ToString();
                this.txtHieuXe.Text = row.Cells["HIEU_XE"].Value.ToString();
                this.rbThongSoKyThuat.Text = row.Cells["THONG_SO_KY_THUAT"].Value.ToString();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            this.txtID.Text = null;
            this.txtHieuXe.Text = null;
            this.rbThongSoKyThuat.Text = null;

            this.btnThemMoi.TabStop = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chăc muốn xóa dòng xe này?", "Xác nhận:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (dx.delDongXe(this.txtID.Text) == true)
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.gwDongXe.DataSource = dx.getData();
                }
                else
                    MessageBox.Show("Không thể xóa!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            this.gwDongXe.DataSource = dx.searchKH(this.txtTimKiem.Text);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            this.txtID.ReadOnly = false;
            this.txtID.Enabled = true;
            this.txtID.BackColor = Color.White;
            this.btn_Luu.Enabled = true;
            this.txtID.Text = "";
            this.txtHieuXe.Text = "";
            this.rbThongSoKyThuat.Text = "";
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string hieuXe = this.txtHieuXe.Text;
            string dongXeId = this.txtID.Text;
            string tskt = this.rbThongSoKyThuat.Text;

            if (hieuXe == "" || dongXeId == "" || tskt == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Entity_DongXe _dx = new Entity_DongXe(dongXeId, hieuXe, tskt);

            if (dx.insertDongXe(_dx) )
            {

                MessageBox.Show("Thêm thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gwDongXe.DataSource = dx.getData();
                this.btn_Luu.Enabled = false;

            } else if (dx.updateDongXe(_dx))
            {
                MessageBox.Show("Sửa thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gwDongXe.DataSource = dx.getData();
                btn_Luu.Enabled = false;
            } else
            {
                MessageBox.Show("Có lỗi xảy ra,vui lòng kiểm tra lại!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chăc muốn xóa dòng xe này?", "Xác nhận:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dx.delDongXe(this.txtID.Text))
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gwDongXe.DataSource = dx.getData();
                }
                else
                    MessageBox.Show("Không thể xóa!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
