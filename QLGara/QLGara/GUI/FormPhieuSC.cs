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
    public partial class FormPhieuSC : MyFormPage
    {
        private BUS_PhieuSuaChua psc = new BUS_PhieuSuaChua();
        private BUS_CTPSC ctpsc = new BUS_CTPSC();
        private BUS_KhachHang kh = new BUS_KhachHang();
        private BUS_Xe xe = new BUS_Xe();
        private BUS_VatTu vt = new BUS_VatTu();
        private int maPSC = 1;
        private double tong = 0;

        public FormPhieuSC()
        {
            InitializeComponent();

            setup();
        }

        private void setup()
        {
            this.pnl = this.pnlPhieuSC;
            //
            this.gwPhieuSuaChua.AutoGenerateColumns = false;
            this.gwPhieuSuaChua.DataSource = psc.getData();
            //
            this.gwCTPhieuSuaChua.AutoGenerateColumns = false;
            this.gwCTPhieuSuaChua.DataSource = ctpsc.getData();
            //
            this.cbbBienSo.DataSource = xe.getData();
            this.cbbBienSo.DisplayMember = "BIENSO";
            this.cbbBienSo.ValueMember = "BIENSO";
            //
            this.cbbKhachHang.DataSource = kh.getData();
            this.cbbKhachHang.DisplayMember = "KH_TEN";
            this.cbbKhachHang.ValueMember = "KH_ID";

            btnHuy_Click(null, null);

            //
            this.cbbPhuTung.DataSource = vt.GetData();
            this.cbbPhuTung.DisplayMember = "TENVT";
            this.cbbPhuTung.ValueMember = "MAVT";
        }

        public void reset()
        {
            this.gwPhieuSuaChua.DataSource = psc.getData();
            this.gwCTPhieuSuaChua.DataSource = ctpsc.getData();
        }

        private void gwPhieuSuaChua_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in gwPhieuSuaChua.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {

                DataGridViewRow row = cell.OwningRow;
                this.txtMPSC.Text = row.Cells["MAPSC"].Value.ToString();
                this.cbbBienSo.SelectedValue = row.Cells["BIENSO"].Value;
                try
                {
                    this.dtNgaySC.Value = Convert.ToDateTime(row.Cells["NGAYSC"].Value);
                    this.txtTong.Text = row.Cells["TONGTIEN"].Value.ToString();
                }
                catch
                {
                    this.dtNgaySC.Value = DateTime.Now;
                    this.txtTong.Text = "0";
                }
                this.cbbKhachHang.SelectedValue = row.Cells["USER_ID"].Value.ToString();
                //this.gwCTPhieuSuaChua.DataSource = ctpsc.getData(this.txtMPSC.Text);
                this.gwCTPhieuSuaChua.DataSource = psc.getPscByID(Int32.Parse(this.txtMPSC.Text));

            }
            this.btnThemCT.Enabled  = (this.txtMPSC.Text != null) ? true : false;
            this.txtSoLuong.Enabled = (this.txtMPSC.Text != null) ? true : false;
            this.cbbPhuTung.Enabled = (this.txtMPSC.Text != null) ? true : false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string bs = this.cbbBienSo.Text;
            string khachHang = this.cbbKhachHang.SelectedValue.ToString();
            int kh_id = 1;
            try
            {
                kh_id = Int32.Parse(khachHang);
                this.txtMPSC.Text = maPSC.ToString();
                tong = Double.Parse(this.txtTong.Text);

            }
            catch
            {
                tong = 0;
            }
            if (bs == "" || khachHang == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Entity_PhieuSuaChua _psc = new Entity_PhieuSuaChua(maPSC, bs, kh_id);
            if (psc.insertPSC(_psc))
            {
                MessageBox.Show("Thêm thành công", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.gwPhieuSuaChua.DataSource = psc.getData();
            }
            else if (psc.updatePSC(_psc) == true)
            {
                MessageBox.Show("Lưu thành công", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.gwPhieuSuaChua.DataSource = psc.getData();
            }
            else
            {
                MessageBox.Show("Không thể thêm!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            string maVtStr = this.cbbPhuTung.SelectedValue.ToString();
            string soluong = this.txtSoLuong.Text;
            int maVt = 1;
            int sl = 0;
            try
            {
                maVt = Int32.Parse(maVtStr);
                sl = Int32.Parse(soluong);
            }
            catch
            {
                maVt = 1;
                sl = 0;
            }

            if (maVtStr == "" || soluong == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Entity_CTPSC _ct = new Entity_CTPSC(Int32.Parse(this.txtMPSC.Text), maVt, sl);
            //MessageBox.Show(this.maPSC.ToString());
            if (ctpsc.insertCTPSC(_ct) == true)
            {
                //MessageBox.Show("Thêm thành công Vật tư " + _vt.TenVt, "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataGridViewRow row = null;
                int indexKey = 0;
                foreach (DataGridViewCell selectedCell in gwPhieuSuaChua.SelectedCells)
                {
                    DataGridViewRow cell = selectedCell.OwningRow;
                    if (cell.Cells["MAPSC"].Value.ToString() == _ct.MaPsc.ToString())
                    {
                        indexKey = cell.Index;
                        break;
                    }
                }
                reset();
                if (indexKey != 0)
                {
                    this.gwPhieuSuaChua.Rows[0].Selected = false;
                    this.gwPhieuSuaChua.Rows[indexKey].Selected = true;
                }
                this.gwCTPhieuSuaChua.DataSource = psc.getPscByID(Int32.Parse(this.txtMPSC.Text));
            }
            else
            {
                MessageBox.Show("Vui lòng điền thông tin!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.txtTong.Text = "";
            
            try
            {
                maPSC = Utility.Instance.autoKey(gwPhieuSuaChua);
                //psc.insertPSC(new Entity_PhieuSuaChua(maPSC, this.cbbBienSo.SelectedValue.ToString(), Int32.Parse(this.cbbKhachHang.SelectedValue.ToString())));
                this.txtMPSC.Text = maPSC.ToString();

            }
            catch
            {
                return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            this.cbbPhuTung.Enabled = false;
            this.txtSoLuong.Enabled = false;
            this.btnThemCT.Enabled = false;
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Bạn có chăc muốn xóa?", "Xác nhận:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    //if (ptt.(Int32.Parse(this.txtMaVT.Text)) == true)
            //    Entity_CTPSC val = new Entity_CTPSC(Int32.Parse(this.txtMPSC.Text),Int32.par)
            //    if (ctpsc.deleteCTPSC() == true)
            //    {
            //        MessageBox.Show("Xóa thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        //gwVatTu.DataSource = vt.GetData();
            //    }
            //    else
            //        MessageBox.Show("Không thể xóa!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
