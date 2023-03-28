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
        DoiMatKhauBLL doiMatKhauBLL = new DoiMatKhauBLL();

        public frmDoimatkhau()
        {
            InitializeComponent();
        }
        private int CheckingPasswordStrength(string password)
        {
            int score = 0;

            if (password.Length >= 8)
                score++;

            //Check xem mật khẩu có số hay không
            if (Regex.IsMatch(password, @"[0-9]+(\.[0-9][0-9]?)?", RegexOptions.ECMAScript))
                score++;

            //Chekc xem mật khẩu có chữ thường không
            if (Regex.IsMatch(password, @"^(?=.*[a-z]).+$", RegexOptions.ECMAScript)) //lower
                score++;

            //Check xem mật khẩu có chữ hoa không
            if (Regex.IsMatch(password, @"^(?=.*[A-Z]).+$", RegexOptions.ECMAScript)) //upper case
                score++;

            //Chekc xem mật khẩu có ký tự đặc biệt hay không
            //if (Regex.IsMatch(password, @"[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]", RegexOptions.ECMAScript)) //^[A-Z]+$
            //    score++;

            return score;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            bool checkValid = true;
            string matKhauCu = txtMatKhauCu.Text;
            string matKhauMoi = txtMatKhauMoi.Text;
            string nhapLaiMatKhauMoi = txtNhapLaiMatKhauMoi.Text;

            if (matKhauCu.Equals("") || matKhauMoi.Equals("") || nhapLaiMatKhauMoi.Equals(""))
            {
                checkValid = false;
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            if (checkValid)
            {
                if (CheckingPasswordStrength(matKhauMoi) < 4)
                {
                    MessageBox.Show("Mật khẩu cần có 8 ký tự trở lên, bao gồm chữ số, chữ thường, chữ hoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (matKhauCu != Program.mK)
                        MessageBox.Show("Mật khẩu cũ không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (nhapLaiMatKhauMoi != matKhauMoi)
                        MessageBox.Show("Mật khẩu nhập lại không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        if (doiMatKhauBLL.changePassword(Program.tenTK, nhapLaiMatKhauMoi))
                        {
                            MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Program.mK = matKhauMoi;
                            txtMatKhauCu.Text = "";
                            txtMatKhauMoi.Text = "";
                            txtNhapLaiMatKhauMoi.Text = "";
                        }
                    }
                }

            }
        }
    }
}