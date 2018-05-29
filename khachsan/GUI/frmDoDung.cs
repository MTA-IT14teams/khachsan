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
    public partial class frmDoDung : Form
    {
        public frmDoDung()
        {
            InitializeComponent();
        }

        private void DoDung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet1.DoDung' table. You can move, or remove it, as needed.
            this.doDungTableAdapter.Fill(this.hotelDataSet1.DoDung);

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

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.Validate();
            //    doDungBindingSource.EndEdit();
            //    doDungTableAdapter.Update(hotelDataSet1.DoDung);
            //    MessageBox.Show("Đã ghi nhận thông tin thành công");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Thất Bại1\n Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            //{
            //    this.Dispose();
            //}
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (tscboTypeSearch.SelectedIndex == 0)
            {
                doDungBindingSource.Filter = "MaDo='" + tstxtKey.Text.Trim() + "'";
            }
            else if(tscboTypeSearch.SelectedIndex==1)
            {
                doDungBindingSource.Filter = "TenDo Like '*" + tstxtKey.Text.Trim() + "*'";
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            doDungBindingSource.Filter = null;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                doDungBindingSource.EndEdit();
                doDungTableAdapter.Update(hotelDataSet1.DoDung);
                MessageBox.Show("Đã ghi nhận thông tin thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất Bại1\n Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }


    }
}
