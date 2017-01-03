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
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string id = this.txtID.Text;
            string hx = this.txtHieuXe.Text;
            string tskt = this.txtTSKT.Text;
            if (id == "" || hx == "" || tskt == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Entity_DongXe _dx = new Entity_DongXe(id, hx, tskt);
            if (dx.insertDongXe(_dx) == true)
            {
                MessageBox.Show("Thêm thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gwDongXe.DataSource = dx.getData();
            }
            else
                MessageBox.Show("Không thể thêm!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string id = this.txtID.Text;
            string hx = this.txtHieuXe.Text;
            string tskt = this.txtTSKT.Text;
            if (id == "" || hx == "" || tskt == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Entity_DongXe _dx = new Entity_DongXe(id, hx, tskt);
            if (dx.updateDongXe(_dx) == true)
            {
                MessageBox.Show("Sửa thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gwDongXe.DataSource = dx.getData();
            }
            else
                MessageBox.Show("Không thể sửa!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chăc muốn xóa Dòng Xe này?", "Xác nhận:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dx.delDongXe(this.txtID.Text) == true)
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gwDongXe.DataSource = dx.getData();
                }
                else
                {
                    MessageBox.Show("Không thể xóa!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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
                this.txtID.Text = row.Cells["DX_ID"].Value.ToString();
                this.txtHieuXe.Text = row.Cells["DX_HX"].Value.ToString();
                this.txtTSKT.Text = row.Cells["TSKT"].Value.ToString();
            }
        }
    }
}
