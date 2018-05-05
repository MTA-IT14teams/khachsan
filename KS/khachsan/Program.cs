using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace khachsan
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Application.Run(new Phong());
           // Application.Run(new Khachhang());
            //Application.Run(new DoDung());
            //Application.Run(new DichVu());
            //Application.Run(new ChiTietDoDung());
            //Application.Run(new ChiTietHDDV());
            //Application.Run(new HoaDonDV());
            //Application.Run(new HoaDonTraPhong());
            //Application.Run(new KiemTraDoDung());
        }
    }
}
