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
    public partial class frmDichVu : Form
    {
        public frmDichVu()
        {
            InitializeComponent();
        }

        private void DichVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet1.DichVu' table. You can move, or remove it, as needed.
            this.dichVuTableAdapter.Fill(this.hotelDataSet1.DichVu);

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
                dichVuBindingSource.EndEdit();
                dichVuTableAdapter.Update(hotelDataSet1.DichVu);
                MessageBox.Show("Đã ghi nhận thông tin thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất Bại1\n Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoát_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ActiveControl = txtMaDV;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (tscboTypeSearch.SelectedIndex == 0)
            {
                dichVuBindingSource.Filter = "MaDV='" + tstxtKey.Text.Trim() + "'";
            }
            else if (tscboTypeSearch.SelectedIndex == 1)
            {
                dichVuBindingSource.Filter = "TenDV Like'*" + tstxtKey.Text.Trim() + "*'";
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dichVuBindingSource.Filter = null;
        }
    }
}
