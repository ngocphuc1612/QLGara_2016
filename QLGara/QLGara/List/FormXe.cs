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
    public partial class FormXe : MyFormPage
    {
        private BUS_Xe xe = new BUS_Xe();
        private BUS_DongXe dx = new BUS_DongXe();
        public FormXe()
        {
            InitializeComponent();
            this.pnl = this.pnlXe;
            this.gwXe.DataSource = xe.getData();

            reset();

        }

        private void reset()
        {
            cbbDongXe.DataSource = dx.getData();
            cbbDongXe.DisplayMember = "DONGXE_ID";
            cbbDongXe.ValueMember = "DONGXE_ID";
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string bienSo = this.txtBienSo.Text;
            string userID = this.txtIdChu.Text;
            string dongXe = this.cbbDongXe.SelectedValue.ToString();
            string mau = this.txtMau.Text;
            string mota = this.txtMota.Text;
            string mauTrong = this.txtMauTrong.Text;
            string namSX = this.txtNamSX.Text;
            string xuatXu = this.txtXuatxu.Text;
            if (bienSo == "" || userID == "" || dongXe == "" || mau == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int userId = 1;
            int dongXeID = 1;
            try
            {
                userId = Int32.Parse(userID);
                dongXeID = Int32.Parse(dongXe);
            } catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại Dòng xe ID và ID chủ xe!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Entity_Xe _xe = new Entity_Xe(bienSo, userId, dongXeID, mau, mota, mauTrong, namSX, xuatXu);
            if (xe.insertXe(_xe) == true)
            {
                MessageBox.Show("Thêm thành công Xe " + _xe.BienSo, "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gwXe.DataSource = xe.getData();
            }
            else
                MessageBox.Show("Không thể thêm!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string bienSo = this.txtBienSo.Text;
            string userID = this.txtIdChu.Text;
            string dongXe = this.cbbDongXe.SelectedValue.ToString();
            string mau = this.txtMau.Text;
            string mota = this.txtMota.Text;
            string mauTrong = this.txtMauTrong.Text;
            string namSX = this.txtNamSX.Text;
            string xuatXu = this.txtXuatxu.Text;
            if (bienSo == "" || userID == "" || dongXe == "" || mau == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int userId = 1;
            int dongXeID = 1;
            try
            {
                userId = Int32.Parse(userID);
                dongXeID = Int32.Parse(dongXe);
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại Dòng xe ID và ID chủ xe!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Entity_Xe _xe = new Entity_Xe(bienSo, userId, dongXeID, mau, mota, mauTrong, namSX, xuatXu);
            if (xe.updateXe(_xe) == true)
            {
                MessageBox.Show("Sửa thành công Xe " + _xe.BienSo, "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gwXe.DataSource = xe.getData();
            }
            else
                MessageBox.Show("Không thể sửa!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chăc muốn xóa Xe này?", "Xác nhận:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (xe.delXe(this.txtBienSo.Text) == true)
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gwXe.DataSource = xe.getData();
                }
                else
                    MessageBox.Show("Không thể xóa!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gwXe_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in gwXe.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {

                DataGridViewRow row = cell.OwningRow;
                this.txtBienSo.Text = row.Cells["Xe_BIENSO"].Value.ToString();
                this.txtIdChu.Text = row.Cells["Xe_USERID"].Value.ToString();
                this.txtMau.Text = row.Cells["Xe_MAU"].Value.ToString();
                this.txtMota.Text = row.Cells["Xe_MOTA"].Value.ToString();
                this.txtMauTrong.Text = row.Cells["Xe_MAUNT"].Value.ToString();
                this.txtNamSX.Text = row.Cells["Xe_NAMXX"].Value.ToString();
                this.txtXuatxu.Text = row.Cells["Xe_XUATXU"].Value.ToString();
                this.cbbDongXe.SelectedValue = row.Cells["Xe_ID_DX"].Value;
            }
        }
    }
}
