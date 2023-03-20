using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_TinhVanSoftWare.PresentationLayer
{
    public partial class frmTaiKhoan : Form
    {

        string constr = "Data Source=DESKTOP-F0LS1J1;Initial Catalog=QuanLyNhanVien;Integrated Security=True";

        BusinessLogicLayer.TaiKhoanBLL taiKhoanBLL = new BusinessLogicLayer.TaiKhoanBLL(); 

        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            if (cbMaNV.Text != "" && txtMaTK.Text != "" && txtTenTK.Text != "" 
                && txtTinhTrang.Text != "" && cbMaQuyen.Text != "" && txtMK.Text != "")
            {
                if (taiKhoanBLL.Check_MaTaiKhoan(constr, txtMaTK.Text))
                {
                    taiKhoanBLL.insert(constr, cbMaNV.Text, txtMaTK.Text, txtTenTK.Text, txtTinhTrang.Text, cbMaQuyen.Text, txtMK.Text);
                    MessageBox.Show("Thêm tài khoản thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tài đã tồn tại! Vui lòng thêm tài khoản khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ các thông tin ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
