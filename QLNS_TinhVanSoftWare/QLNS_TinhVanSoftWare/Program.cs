﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace QLNS_TinhVanSoftWare
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            /// <summary>
            /// The main entry point for the application.
            /// </summary>
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PresentationLayer.frmBoNhiem());
        }
    }
}
