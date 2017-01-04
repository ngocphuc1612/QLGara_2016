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
    public partial class FormNhaCungCap : MyFormPage
    {
        private BUS_NhaCungCap ncc = new BUS_NhaCungCap();
        public FormNhaCungCap()
        {
            InitializeComponent();
            this.pnl = this.pnlNhacCungCap;
            this.gwNhacCungCap.AutoGenerateColumns = false;
            this.gwNhacCungCap.DataSource = ncc.getData();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            this.txtTenNCC.Text = null;
            this.txtEmail.Text = null;
            this.txtPhone.Text = null;
            this.txtAddress.Text = null;

            this.btnThemMoi.TabStop = true;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void gwNhacCungCap_SelectionChanged(object sender, EventArgs e)
        {

            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in gwNhacCungCap.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {

                DataGridViewRow row = cell.OwningRow;

                this.txtID.Text = row.Cells["NCC_ID"].Value.ToString();
                this.txtEmail.Text = row.Cells["NCC_EMAIL"].Value.ToString();
                this.txtTenNCC.Text = row.Cells["NCC_TEN"].Value.ToString();
                this.txtPhone.Text = row.Cells["NCC_SDT"].Value.ToString();
                this.txtAddress.Text = row.Cells["NCC_DIACHI"].Value.ToString();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            this.gwNhacCungCap.DataSource = ncc.searchNCC(this.txtTimKiem.Text);
        }
    }
}
