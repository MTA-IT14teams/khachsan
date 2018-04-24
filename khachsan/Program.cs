using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace khachsan
{
    static class Program
    {
        public static SqlConnection cnn;
        public static string userName = "";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\ThucTapNhom\Project\khachsan\khachsan\Hotel.mdf;Integrated Security=True;Connect Timeout=30");
                cnn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hãy sửa lại connect string trong Program.cs");
            }
            Application.Run(new frmMain());
        }
    }
}
