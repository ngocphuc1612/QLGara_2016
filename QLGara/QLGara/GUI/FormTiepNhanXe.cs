using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace QLGara
{
    public partial class FormTiepNhanXe : MyFormPage
    {
        private BUS_Xe xe = new BUS_Xe();
        private BUS_DongXe dx = new BUS_DongXe();
        private BUS_KhachHang kh = new BUS_KhachHang();
        public FormTiepNhanXe()
        {
            InitializeComponent();
            this.pnl = this.pnlTiepNhanXe;
            setProperty();
        }

        private void setProperty()
        {
            DataTable dt = xe.getData();
            this.gwXe.AutoGenerateColumns = false;
            this.gwXe.DataSource = dt;
            this.txtBienSo.Enabled = false;
            this.btnLuu.Enabled = false;

            this.cbbKhachHang.DataSource = kh.getData();
            this.cbbKhachHang.DisplayMember = "KH_TEN";
            this.cbbKhachHang.ValueMember = "KH_ID";

            this.cbbDongXe.DataSource = dx.getData();
            this.cbbDongXe.ValueMember = "DONGXE_ID";
            this.cbbDongXe.DisplayMember = "DONGXE_ID";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string bienSo = this.txtBienSo.Text;
            string userID = this.cbbKhachHang.SelectedValue.ToString();
            string dongXe = this.cbbDongXe.SelectedValue.ToString();
            string mota = this.txtMoTa.Text;
            string mau = this.colorMauXe.Text;
            string mauTrong = this.colorMauNoiThat.Text;
            string namSX = this.txtNamSX.Text;
            string xuatXu = this.txtXuatXu.Text;
            if (bienSo == "" || userID == "" || dongXe == "" || mau == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int userId = 1;
            try
            {
                userId = Int32.Parse(userID);
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại Dòng xe ID và ID chủ xe!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Entity_Xe _xe = new Entity_Xe(bienSo, userId, dongXe, mau, mota, mauTrong, namSX, xuatXu);
            if (xe.insertXe(_xe) == true)
            {
                MessageBox.Show("Thêm thành công Xe " + _xe.BienSo, "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gwXe.DataSource = xe.getData();
                this.txtBienSo.Enabled = false;
            }
            else
            {
                if (xe.updateXe(_xe) == true)
                {
                    MessageBox.Show("Sửa thành công Xe " + _xe.BienSo, "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gwXe.DataSource = xe.getData();
                } else
                    MessageBox.Show("Không thể thêm!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtBienSo.Enabled = false;
            this.btnLuu.Enabled = false;
            this.txtBienSo.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
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
                this.txtBienSo.Text = row.Cells["BIENSO"].Value.ToString();
                this.cbbKhachHang.SelectedValue = row.Cells["USER_ID"].Value;
                this.cbbDongXe.Text = row.Cells["DONGXE_ID"].Value.ToString();
                this.colorMauXe.EditValue = row.Cells["MAU_XE"].Value;
                this.colorMauNoiThat.EditValue = row.Cells["MAU_NOI_THAT"].Value;
                this.txtNamSX.Text = row.Cells["NAM_XUAT_XU"].Value.ToString();
                this.txtXuatXu.Text = row.Cells["XUAT_XU"].Value.ToString();
                this.txtMoTa.Text = row.Cells["MOTA"].Value.ToString();

            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            this.gwXe.DataSource = xe.searchXe(this.txtTimKiem.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtBienSo.Enabled = true;
            this.btnLuu.Enabled = true;
            this.txtBienSo.Text = "";
            this.txtNamSX.Text = "";
            this.txtMoTa.Text = "";
            this.txtXuatXu.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chăc muốn xóa xe này?", "Xác nhận:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (xe.delXe(this.txtBienSo.Text) == true)
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.gwXe.DataSource = xe.getData();
                }
                else
                    MessageBox.Show("Không thể xóa!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
