﻿using QLNS_TinhVanSoftWare.BusinessLogicLayer;
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

        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDanhNhap_Click(object sender, EventArgs e)
        {
            string tenTK = txtTenTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;

            if (tenTK.Equals(""))
            {
                errorProviderLogin.SetError(txtTenTaiKhoan, "Vui lòng nhập tên tài khoản");
            }
            else
            {
                errorProviderLogin.SetError(txtTenTaiKhoan, "");

                if (taiKhoanBLL.login(tenTK, matKhau) == 0)
                    errorProviderLogin.SetError(txtTenTaiKhoan, "Sai tên tên tài khoản");
                else
                    errorProviderLogin.SetError(txtTenTaiKhoan, "");
            }

            if (matKhau.Equals(""))
            {
                errorProviderLogin.SetError(txtMatKhau, "Vui lòng nhập mật khẩu");
            }
            else
            {
                errorProviderLogin.SetError(txtMatKhau, "");

                if (taiKhoanBLL.login(tenTK, matKhau) == 2)
                {
                    errorProviderLogin.SetError(txtMatKhau, "Sai mật khẩu");
                    txtMatKhau.Text = "";
                }
                else
                    errorProviderLogin.SetError(txtMatKhau, "");
            }

            if (taiKhoanBLL.login(tenTK, matKhau) == 1)
            {
                new frmTrangChu().Show();
                this.Hide();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
