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
    public partial class frmPhong : Form
    {
        public frmPhong()
        {
            InitializeComponent();
        }

        private void Phong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet1.Phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter.Fill(this.hotelDataSet1.Phong);

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

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //if(MessageBox.Show("Bạn có thật sự muốn Xóa?","Cảnh Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== DialogResult.Yes)
            //{
            //    phongBindingSource.RemoveCurrent();
            //}
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //phongBindingSource.AddNew();
            //bindingNavigatorAddNewItem.
            ActiveControl = this.txtMaP;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                phongBindingSource.EndEdit();
                phongTableAdapter.Update(hotelDataSet1.Phong);
                MessageBox.Show("Đã ghi nhận thông tin thành công");
            }
            catch (Exception ex )
            {
                MessageBox.Show("Thất Bại1\n Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            btnGhi_Click(null, null);
        }

        
        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            if (tscboTypeSearch.SelectedIndex == 0)
            {
                phongBindingSource.Filter = "MaPhong='" + tstxtKey.Text.Trim() + "'";
            }
            else if (tscboTypeSearch.SelectedIndex == 1)
            {
                phongBindingSource.Filter = "TenPhong Like'*" + tstxtKey.Text.Trim() + "*'";
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            phongBindingSource.Filter = null;
        }
    }
}
