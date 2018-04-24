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
    public partial class frmKiemTraDoDung : Form
    {
        public frmKiemTraDoDung()
        {
            InitializeComponent();
        }

        private void KiemTraDoDung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet1.KiemTraDoDung' table. You can move, or remove it, as needed.
            this.kiemTraDoDungTableAdapter.Fill(this.hotelDataSet1.KiemTraDoDung);

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
