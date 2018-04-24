using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace khachsan.GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Thoát_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (Logging())
            {
                Program.userName = txtTaiKhoan.Text.Trim();
                this.DialogResult = DialogResult.OK;
            }
        }

        private bool Logging()
        {
           var ok = false;
           var cmd = new SqlCommand("", Program.cnn);
           cmd.CommandText = "SELECT * FROM users WHERE [user]=@user and pass=@pass";
            cmd.Parameters.AddWithValue("@user", this.txtTaiKhoan.Text.Trim());
            cmd.Parameters.AddWithValue("@pass", this.txtMatKhau.Text.Trim());
            var dr = cmd.ExecuteReader();
            ok = dr.Read();
            dr.Close();
            if (!ok)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return ok;
        }
    }
}
