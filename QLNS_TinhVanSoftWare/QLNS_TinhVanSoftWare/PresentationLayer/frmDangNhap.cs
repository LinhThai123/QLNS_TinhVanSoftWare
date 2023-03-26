using QLNS_TinhVanSoftWare.BusinessLogicLayer;
using QLNS_TinhVanSoftWare.PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        DangNhapBLL dangNhapBLL = new DangNhapBLL();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDanhNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTenTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;

            if (dangNhapBLL.login(taiKhoan, matKhau) == 0)
            {
                MessageBox.Show("Tài khoản không tồn tại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (taiKhoan == "" || matKhau == "")
            {
                MessageBox.Show("Không được để trống !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (dangNhapBLL.login(taiKhoan, matKhau) == 2)
                    MessageBox.Show("Mật khẩu không chính xác !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (dangNhapBLL.login(taiKhoan, matKhau) == -2)
                    MessageBox.Show("Tài khoản này hiện đang bị khóa !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (dangNhapBLL.login(taiKhoan, matKhau) == 1)
                {
                    this.Hide();
                    new frmTrangChu().ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
