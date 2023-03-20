using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_TinhVanSoftWare
{
    class Program
    {
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