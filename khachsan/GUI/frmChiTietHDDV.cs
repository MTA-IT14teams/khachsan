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
    public partial class frmChiTietHDDV : Form
    {
        public frmChiTietHDDV()
        {
            InitializeComponent();
        }

        private void ChiTietHDDV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet1.ChiTietHDDV' table. You can move, or remove it, as needed.
            this.chiTietHDDVTableAdapter.Fill(this.hotelDataSet1.ChiTietHDDV);

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
    }
}
