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
    }
}
