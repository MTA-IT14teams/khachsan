using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace khachsan
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void Khachhang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet1.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.hotelDataSet1.KhachHang);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                dataGridView1.CurrentRow.Selected = true;
            }
            catch
            {

            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                khachHangBindingSource.EndEdit();
                khachHangTableAdapter.Update(hotelDataSet1.KhachHang);
                MessageBox.Show("Đã ghi nhận thông tin thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất Bại1\n Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ActiveControl = this.txtMaKH;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (tscboTypeSearch.SelectedIndex == 0)
            {
                khachHangBindingSource.Filter = "MaKH='" + tstxtKey.Text.Trim() + "'";
            }
            else if (tscboTypeSearch.SelectedIndex == 1)
            {
                khachHangBindingSource.Filter = "TenKH Like'*" + tstxtKey.Text.Trim() + "*'";
            }
            else if (tscboTypeSearch.SelectedIndex == 2)
            {
                khachHangBindingSource.Filter = "MaPhong='" + tstxtKey.Text.Trim() + "'";
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            khachHangBindingSource.Filter = null;
        }
    }
}
