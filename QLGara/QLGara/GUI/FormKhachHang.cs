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

namespace QLGara
{
    public partial class FormKhachHang : MyFormPage
    {
        private BUS_KhachHang kh = new BUS_KhachHang();
        public FormKhachHang()
        {
            InitializeComponent();
            this.pnl = this.pnlKhachHang;
            this.gwKhachHang.AutoGenerateColumns = false;
            this.gwKhachHang.DataSource = kh.getData();
        }

        private void gwKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in gwKhachHang.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {

                DataGridViewRow row = cell.OwningRow;

                this.txtID.Text = row.Cells["KH_ID"].Value.ToString();
                this.txtEmail.Text = row.Cells["KH_EMAIL"].Value.ToString();
                this.txtTen.Text = row.Cells["KH_TEN"].Value.ToString();
                string gender = row.Cells["KH_GIOITINH"].Value.ToString();
                this.rdNam.Checked = ( gender == "True" ) ? true : false;
                this.rdNu.Checked = (gender == "True") ? false : true;
                this.txtCongNo.Text = row.Cells["KH_CONGNO"].Value.ToString();
                try
                {
                    this.dtDoB.Value = Convert.ToDateTime(row.Cells["KH_NGAYSINH"].Value);
                }
                catch
                {
                    this.dtDoB.Value = DateTime.Now;
                }
                this.txtPhone.Text = row.Cells["KH_SDT"].Value.ToString();
                this.txtAddress.Text = row.Cells["KH_DIACHI"].Value.ToString();
            }
        }

    }
}
