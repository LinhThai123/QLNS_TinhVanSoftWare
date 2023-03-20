using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace QLNS_TinhVanSoftWare
{
    static class Program
    {
        public static string maQuyenQuanLy = "Q00001";
        public static string maQuyenKeToan = "Q00002";
        public static string maQuyenNhanSu = "Q00003";
        public static string maQuyenNhanVien = "Q00004";

        public static string tenNV, maTK, maQuyen, tenTK;

        [STAThread]
        static void Main()
        {
            /// <summary>
            /// The main entry point for the application.
            /// </summary>
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PresentationLayer.frmTrangChu());
        }
    }
}
