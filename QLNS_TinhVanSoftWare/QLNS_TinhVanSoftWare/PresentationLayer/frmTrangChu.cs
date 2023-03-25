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
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void mnPhongBan_Click(object sender, EventArgs e)
        {
            frmPhongBan frmPhongBan = new frmPhongBan();
            frmPhongBan.MdiParent = this;
            frmPhongBan.Show();
        }

        private void mnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn Đăng Xuất ", "Thông báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Hide();
                frmDangNhap formDangNhap = new frmDangNhap();
                formDangNhap.ShowDialog();
                this.Close();
            }
        }

        private void mnChucVu_Click(object sender, EventArgs e)
        {
            frmChucVu frmChucVu = new frmChucVu();
            frmChucVu.MdiParent = this;
            frmChucVu.Show();
        }

        private void mnNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNhanVien = new frmNhanVien();
            frmNhanVien.MdiParent = this;
            frmNhanVien.Show();
        }

        private void mnTaiKhoan_Click(object sender, EventArgs e)
        {
            frmTaiKhoan frmTaiKhoan = new frmTaiKhoan();
            frmTaiKhoan.MdiParent = this;
            frmTaiKhoan.Show();
        }

        private void mnBBDanhGia_Click(object sender, EventArgs e)
        {
            frmBienBanDanhGia frmBienBanDanhGia = new frmBienBanDanhGia();
            frmBienBanDanhGia.MdiParent = this;
            frmBienBanDanhGia.Show();
        }

        private void mnQDBoNhiem_Click(object sender, EventArgs e)
        {
            frmBoNhiem frmBoNhiem = new frmBoNhiem();
            frmBoNhiem.MdiParent = this;
            frmBoNhiem.Show();
        }

        private void mnHDLaoDong_Click(object sender, EventArgs e)
        {
            frmHopDong frmHopDong = new frmHopDong();
            frmHopDong.MdiParent = this;
            frmHopDong.Show();
        }

        private void mnNghiPhepThoiViec_Click(object sender, EventArgs e)
        {
            frmNghiPhepThoiViec frmNghiPhepThoiViec = new frmNghiPhepThoiViec();
            frmNghiPhepThoiViec.MdiParent = this;
            frmNghiPhepThoiViec.Show();
        }

        private void mnLuongNhanVien_Click(object sender, EventArgs e)
        {
            frmLuong frmLuong = new frmLuong();
            frmLuong.MdiParent = this;
            frmLuong.Show();
        }

        private void mnBangChamCong_Click(object sender, EventArgs e)
        {
            frmChamCong frmChamCong = new frmChamCong();
            frmChamCong.MdiParent = this;
            frmChamCong.Show();
        }

        private void mnKhenThuongKyLuat_Click(object sender, EventArgs e)
        {
            frmKhenThuongKyLuat frmKhenThuongKyLuat = new frmKhenThuongKyLuat();
            frmKhenThuongKyLuat.MdiParent = this;
            frmKhenThuongKyLuat.Show();
        }

        private void DoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoimatkhau frmDoimatkhau = new frmDoimatkhau();
            frmDoimatkhau.MdiParent = this;
            frmDoimatkhau.Show();
        }

        private void NghiPhepThoiViec_Click(object sender, EventArgs e)
        {
            
        }

        private void frmTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
