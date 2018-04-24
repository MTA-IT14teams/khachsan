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
    public partial class frmMain : Form
    {
        private GUI.frmLogin loginForm;
        public frmMain()
        {
            InitializeComponent();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chứcNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach( var fr in this.MdiChildren){
                if (fr.GetType()== typeof(Form1))
                {
                    fr.Activate();
                    return;
                }

            }
            var frm = new Form1();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(var fr in this.MdiChildren)
            {
                if(fr.GetType() == typeof(frmPhong))
                {
                    fr.Activate();
                    return;
                }
            }
            var frm = new frmPhong();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void đồDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var fr in this.MdiChildren)
            {
                if (fr.GetType() == typeof(frmDoDung))
                    {
                    fr.Activate();
                    return;
                }
            }
            var frm = new frmDoDung();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var fr in this.MdiChildren)
            {
                if (fr.GetType() == typeof(frmDichVu))
                {
                    fr.Activate();
                    return;
                }
            }
            var frm = new frmDichVu();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void kháchHàngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            foreach (var fr in this.MdiChildren)
            {
                if (fr.GetType() == typeof(frmKhachHang))
                {
                    fr.Activate();
                    return;
                }
            }
            var frm = new frmKhachHang();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
           var result = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void DisableMenu()
        {
            foreach ( ToolStripMenuItem _item in menuStrip1.Items)
            {
                
                    _item.Enabled = false;
                
            }
        }
        private void EnableMenu()
        {
            foreach (ToolStripMenuItem _item in menuStrip1.Items)
            {
                _item.Enabled = true;
               
            }
        }
        private void DoLogin()
        {
            DisableMenu();
            if(loginForm.ShowDialog() == DialogResult.OK)
            {
                EnableMenu();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(loginForm == null)
            {
                loginForm = new GUI.frmLogin();
            }
            else
            {
                loginForm.Activate();
            }
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            DoLogin();
            this.tsslblAcc.Text = "Tài Khoản: " + Program.userName;
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            thoátToolStripMenuItem_Click(null, null);
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loginForm == null)
            {
                loginForm = new GUI.frmLogin();
            }
            else
            {
                loginForm.Activate();
            }
            DoLogin();
            this.tsslblAcc.Text = "Tài Khoản: " + Program.userName;
        }

        private void kiểmTraĐồDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var fr in this.MdiChildren)
            {
                if (fr.GetType() == typeof(frmKiemTraDoDung))
                {
                    fr.Activate();
                    return;
                }
            }
            var frm = new frmKiemTraDoDung();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
