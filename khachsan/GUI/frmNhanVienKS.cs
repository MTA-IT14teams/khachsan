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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet1.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.hotelDataSet1.NhanVien);
            // TODO: This line of code loads data into the 'hotelDataSet.NhanVien' table. You can move, or remove it, as needed.
           
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.CurrentRow.Selected = true;
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Bạn có thật sự muốn thoát?","Thông Báo", MessageBoxButtons.YesNo,MessageBoxIcon.Information)== DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnGhiNhan_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                nhanVienBindingSource.EndEdit();
                nhanVienTableAdapter.Update(hotelDataSet1.NhanVien);
                MessageBox.Show("Đã ghi nhận thông tin thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất Bại1\n Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            btnGhiNhan_Click(null, null);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Bạn có thật sự muốn Xóa?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //{
            //    nhanVienBindingSource.RemoveCurrent();
            //}
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
           // nhanVienBindingSource.AddNew();
            ActiveControl = this.txtMaNV;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(tscboTypeSearch.SelectedIndex== 0)
            {
               nhanVienBindingSource.Filter = "MaNV='" + tstxtKey.Text.Trim()+"'";
            }
            else if(tscboTypeSearch.SelectedIndex==1)
            {
                nhanVienBindingSource.Filter = "TenNV Like'*" + tstxtKey.Text.Trim() + "*'";
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            nhanVienBindingSource.Filter = null;
        }
    }
}
