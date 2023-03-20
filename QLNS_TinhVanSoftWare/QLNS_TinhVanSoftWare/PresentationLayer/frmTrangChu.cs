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

        private void frmTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void mnPhongBan_Click(object sender, EventArgs e)
        {
            frmPhongBan frmPhongBan = new frmPhongBan();
            frmPhongBan.Show();
            this.Hide();
        }

        private void mnDangXuat_Click(object sender, EventArgs e)
        {        
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.Show(); 
            this.Hide();
        }

        private void mnChucVu_Click(object sender, EventArgs e)
        {
            frmChucVu frmChucVu = new frmChucVu();
            frmChucVu.Show();
            this.Hide();
        }

        private void mnNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNhanVien = new frmNhanVien();
            frmNhanVien.Show();
            this.Hide(); 
        }

        private void mnTaiKhoan_Click(object sender, EventArgs e)
        {
            frmTaiKhoan frmTaiKhoan = new frmTaiKhoan();
            frmTaiKhoan.Show();
            this.Hide(); 
        }

        private void mnBBDanhGia_Click(object sender, EventArgs e)
        {
            frmBienBanDanhGia frmBienBanDanhGia = new frmBienBanDanhGia();
            frmBienBanDanhGia.Show();
            this.Hide(); 
        }

        private void mnQDBoNhiem_Click(object sender, EventArgs e)
        {
            frmBoNhiem frmBoNhiem = new frmBoNhiem();
            frmBoNhiem.Show();
            this.Hide();
        }

        private void mnHDLaoDong_Click(object sender, EventArgs e)
        {
            frmHopDong frmHopDong = new frmHopDong();
            frmHopDong.Show();
            this.Hide(); 
        }

        private void mnNghiPhepThoiViec_Click(object sender, EventArgs e)
        {
            frmNghiPhepThoiViec frmNghiPhepThoiViec = new frmNghiPhepThoiViec();
            frmNghiPhepThoiViec.Show();
            this.Hide(); 
        }

        private void mnLuongNhanVien_Click(object sender, EventArgs e)
        {
            frmLuong frmLuong = new frmLuong();
            frmLuong.Show();
            this.Hide(); 
        }

        private void mnBangChamCong_Click(object sender, EventArgs e)
        {
            new frmChamCong().Show();
            this.Hide();
        }

        private void mnKhenThuongKyLuat_Click(object sender, EventArgs e)
        {
            new frmKhenThuongKyLuat().Show();
            this.Hide();
        }

        private void DoiMatKhau_Click(object sender, EventArgs e)
        {
            new frmDoimatkhau().Show();
            this.Hide(); 
        }

        private void NghiPhepThoiViec_Click(object sender, EventArgs e)
        {
            
        }
    }
}
