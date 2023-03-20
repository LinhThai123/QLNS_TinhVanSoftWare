using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_TinhVanSoftWare
{
    public partial class frmDangNhap : Form

    {

        BusinessLogicLayer.TaiKhoanBLL taiKhoanBLL = new BusinessLogicLayer.TaiKhoanBLL();
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDanhNhap_Click(object sender, EventArgs e)
        {

        }
    }
}
