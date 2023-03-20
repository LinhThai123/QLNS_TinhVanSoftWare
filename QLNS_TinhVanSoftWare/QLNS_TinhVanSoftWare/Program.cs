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
        public static string maQuyenQuanLy = "Q01";
        public static string maQuyenKeToan = "Q02";
        public static string maQuyenNhanSu = "Q03";
        public static string maQuyenNhanVien = "Q04";

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
