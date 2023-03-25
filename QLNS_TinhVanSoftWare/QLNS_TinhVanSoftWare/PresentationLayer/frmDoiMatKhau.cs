﻿using QLNS_TinhVanSoftWare.BusinessLogicLayer;
using QLNS_TinhVanSoftWare.PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_TinhVanSoftWare
{
    public partial class frmDoimatkhau : Form
    {
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();

        public frmDoimatkhau()
        {
            InitializeComponent();
        }
        private int CheckingPasswordStrength(string password)
        {
            int score = 0;

            if (password.Length >= 8)
                score++;

            //if (password.Length >= 12)
            //    score++;

            //Check xem mật khẩu có số hay không
            if (Regex.IsMatch(password, @"[0-9]+(\.[0-9][0-9]?)?", RegexOptions.ECMAScript))   //number only //"^\d+$" if you need to match more than one digit.
                score++;

            //Chekc xem mật khẩu có chữ thường không
            if (Regex.IsMatch(password, @"^(?=.*[a-z]).+$", RegexOptions.ECMAScript)) //lower
                score++;

            //Chekc xem mật khẩu có chữ hoa không
            if (Regex.IsMatch(password, @"^(?=.*[A-Z]).+$", RegexOptions.ECMAScript)) //upper case
                score++;

            //Chekc xem mật khẩu có ký tự đặc biệt hay không
            //if (Regex.IsMatch(password, @"[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]", RegexOptions.ECMAScript)) //^[A-Z]+$
            //    score++;

            return score;
        }
        private void Doimatkhau_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool checkValid = true;
            string matKhauCu = txtMatKhauCu.Text;
            string matKhauMoi = txtMatKhauMoi.Text;
            string nhapLaiMatKhauMoi = txtNhapLaiMatKhauMoi.Text;

            if (matKhauCu.Equals(""))
            {
                errorProviderDoiMatKhau.SetError(txtMatKhauCu, "Vui lòng nhập mật khẩu cũ");
                checkValid = false;
            }
            else
            {
                errorProviderDoiMatKhau.SetError(txtMatKhauCu, "");
            }

            if (matKhauMoi.Equals(""))
            {
                errorProviderDoiMatKhau.SetError(txtMatKhauMoi, "Vui lòng nhập mật khẩu mới");
                checkValid = false;
            }
            else
            {
                errorProviderDoiMatKhau.SetError(txtMatKhauMoi, "");
            }

            if (nhapLaiMatKhauMoi.Equals(""))
            {
                errorProviderDoiMatKhau.SetError(txtNhapLaiMatKhauMoi, "Vui lòng nhập lại mật khẩu mới");
                checkValid = false;
            }
            else
            {
                errorProviderDoiMatKhau.SetError(txtNhapLaiMatKhauMoi, "");
            }

            if (checkValid)
            {
                if (CheckingPasswordStrength(matKhauMoi) < 4)
                {
                    MessageBox.Show("Mật khẩu cần có 8 ký tự trở lên, bao gồm chữ số, chữ thường, chữ hoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (!taiKhoanBLL.changePassword(Program.maTK, matKhauCu))
                        MessageBox.Show("Mật khẩu cũ không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (nhapLaiMatKhauMoi != matKhauMoi)
                        MessageBox.Show("Mật khẩu nhập lại không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        if (taiKhoanBLL.changePassword(Program.maTK, nhapLaiMatKhauMoi))
                        {
                            MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtMatKhauCu.Text = "";
                            txtMatKhauMoi.Text = "";
                            txtNhapLaiMatKhauMoi.Text = "";
                        }
                    }
                }

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new frmTrangChu().Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMatKhauMoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNhapLaiMatKhauMoi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}