namespace QLNS_TinhVanSoftWare.PresentationLayer
{
    partial class frmTrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangChu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPhongBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnChucVu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnNhanSu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBBDanhGia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQDBoNhiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHDLaoDong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnNghiPhepThoiViec = new System.Windows.Forms.ToolStripMenuItem();
            this.mnKeToan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLuongNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBangChamCong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSupport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnKhenThuongKyLuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnManager = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.DoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.NghiPhepThoiViec = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnHeThong,
            this.mnNhanSu,
            this.mnKeToan,
            this.mnManager});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(895, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnHeThong
            // 
            this.mnHeThong.BackColor = System.Drawing.SystemColors.Control;
            this.mnHeThong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mnHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnPhongBan,
            this.mnChucVu,
            this.mnNhanVien,
            this.mnTaiKhoan});
            this.mnHeThong.ForeColor = System.Drawing.Color.Black;
            this.mnHeThong.Image = ((System.Drawing.Image)(resources.GetObject("mnHeThong.Image")));
            this.mnHeThong.Name = "mnHeThong";
            this.mnHeThong.Size = new System.Drawing.Size(105, 24);
            this.mnHeThong.Text = "Hệ thống";
            // 
            // mnPhongBan
            // 
            this.mnPhongBan.Name = "mnPhongBan";
            this.mnPhongBan.Size = new System.Drawing.Size(224, 26);
            this.mnPhongBan.Text = "Quản Lý Phòng Ban";
            this.mnPhongBan.Click += new System.EventHandler(this.mnPhongBan_Click);
            // 
            // mnChucVu
            // 
            this.mnChucVu.Name = "mnChucVu";
            this.mnChucVu.Size = new System.Drawing.Size(224, 26);
            this.mnChucVu.Text = "Quản lý Chức Vụ";
            this.mnChucVu.Click += new System.EventHandler(this.mnChucVu_Click);
            // 
            // mnNhanVien
            // 
            this.mnNhanVien.Name = "mnNhanVien";
            this.mnNhanVien.Size = new System.Drawing.Size(224, 26);
            this.mnNhanVien.Text = "Quản Lý Nhân Viên";
            this.mnNhanVien.Click += new System.EventHandler(this.mnNhanVien_Click);
            // 
            // mnTaiKhoan
            // 
            this.mnTaiKhoan.Name = "mnTaiKhoan";
            this.mnTaiKhoan.Size = new System.Drawing.Size(224, 26);
            this.mnTaiKhoan.Text = "Quản Lý Tài Khoản";
            this.mnTaiKhoan.Click += new System.EventHandler(this.mnTaiKhoan_Click);
            // 
            // mnNhanSu
            // 
            this.mnNhanSu.BackColor = System.Drawing.SystemColors.Control;
            this.mnNhanSu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mnNhanSu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnBBDanhGia,
            this.mnQDBoNhiem,
            this.mnHDLaoDong,
            this.mnNghiPhepThoiViec});
            this.mnNhanSu.Image = ((System.Drawing.Image)(resources.GetObject("mnNhanSu.Image")));
            this.mnNhanSu.Name = "mnNhanSu";
            this.mnNhanSu.Size = new System.Drawing.Size(155, 24);
            this.mnNhanSu.Text = "Quản Lý Nhân Sự";
            // 
            // mnBBDanhGia
            // 
            this.mnBBDanhGia.Name = "mnBBDanhGia";
            this.mnBBDanhGia.Size = new System.Drawing.Size(292, 26);
            this.mnBBDanhGia.Text = "Quản Lý Biên Bản Đánh Giá";
            this.mnBBDanhGia.Click += new System.EventHandler(this.mnBBDanhGia_Click);
            // 
            // mnQDBoNhiem
            // 
            this.mnQDBoNhiem.Name = "mnQDBoNhiem";
            this.mnQDBoNhiem.Size = new System.Drawing.Size(292, 26);
            this.mnQDBoNhiem.Text = "Quản Lý Quyết Định Bổ Nhiệm";
            this.mnQDBoNhiem.Click += new System.EventHandler(this.mnQDBoNhiem_Click);
            // 
            // mnHDLaoDong
            // 
            this.mnHDLaoDong.Name = "mnHDLaoDong";
            this.mnHDLaoDong.Size = new System.Drawing.Size(292, 26);
            this.mnHDLaoDong.Text = "Quản Lý Hợp Đồng Lao Động";
            this.mnHDLaoDong.Click += new System.EventHandler(this.mnHDLaoDong_Click);
            // 
            // mnNghiPhepThoiViec
            // 
            this.mnNghiPhepThoiViec.Name = "mnNghiPhepThoiViec";
            this.mnNghiPhepThoiViec.Size = new System.Drawing.Size(292, 26);
            this.mnNghiPhepThoiViec.Text = "Quản Lý Nghỉ Phép,Thôi Việc";
            this.mnNghiPhepThoiViec.Click += new System.EventHandler(this.mnNghiPhepThoiViec_Click);
            // 
            // mnKeToan
            // 
            this.mnKeToan.BackColor = System.Drawing.SystemColors.Control;
            this.mnKeToan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mnKeToan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnLuongNhanVien,
            this.mnBangChamCong,
            this.mnSupport,
            this.mnKhenThuongKyLuat});
            this.mnKeToan.Image = ((System.Drawing.Image)(resources.GetObject("mnKeToan.Image")));
            this.mnKeToan.Name = "mnKeToan";
            this.mnKeToan.Size = new System.Drawing.Size(152, 24);
            this.mnKeToan.Text = "Quản Lý Kế Toán";
            // 
            // mnLuongNhanVien
            // 
            this.mnLuongNhanVien.Name = "mnLuongNhanVien";
            this.mnLuongNhanVien.Size = new System.Drawing.Size(300, 26);
            this.mnLuongNhanVien.Text = "Quản Lý Bảng Lương Nhân Viên";
            this.mnLuongNhanVien.Click += new System.EventHandler(this.mnLuongNhanVien_Click);
            // 
            // mnBangChamCong
            // 
            this.mnBangChamCong.Name = "mnBangChamCong";
            this.mnBangChamCong.Size = new System.Drawing.Size(300, 26);
            this.mnBangChamCong.Text = "Quản Lý Bảng Chấm Công";
            this.mnBangChamCong.Click += new System.EventHandler(this.mnBangChamCong_Click);
            // 
            // mnSupport
            // 
            this.mnSupport.Name = "mnSupport";
            this.mnSupport.Size = new System.Drawing.Size(300, 26);
            this.mnSupport.Text = "Quản Lý Báo Cáo Tài Chính";
            // 
            // mnKhenThuongKyLuat
            // 
            this.mnKhenThuongKyLuat.Name = "mnKhenThuongKyLuat";
            this.mnKhenThuongKyLuat.Size = new System.Drawing.Size(300, 26);
            this.mnKhenThuongKyLuat.Text = "Quản Lý Khen Thưởng, Kỷ Luật";
            this.mnKhenThuongKyLuat.Click += new System.EventHandler(this.mnKhenThuongKyLuat_Click);
            // 
            // mnManager
            // 
            this.mnManager.BackColor = System.Drawing.SystemColors.Control;
            this.mnManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mnManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnDangXuat,
            this.DoiMatKhau,
            this.NghiPhepThoiViec});
            this.mnManager.Image = ((System.Drawing.Image)(resources.GetObject("mnManager.Image")));
            this.mnManager.Name = "mnManager";
            this.mnManager.Size = new System.Drawing.Size(107, 24);
            this.mnManager.Text = "Tài Khoản";
            // 
            // mnDangXuat
            // 
            this.mnDangXuat.Name = "mnDangXuat";
            this.mnDangXuat.Size = new System.Drawing.Size(268, 26);
            this.mnDangXuat.Text = "Đăng Xuất";
            this.mnDangXuat.Click += new System.EventHandler(this.mnDangXuat_Click);
            // 
            // DoiMatKhau
            // 
            this.DoiMatKhau.Name = "DoiMatKhau";
            this.DoiMatKhau.Size = new System.Drawing.Size(268, 26);
            this.DoiMatKhau.Text = "Đổi Mật Khẩu";
            this.DoiMatKhau.Click += new System.EventHandler(this.DoiMatKhau_Click);
            // 
            // NghiPhepThoiViec
            // 
            this.NghiPhepThoiViec.Name = "NghiPhepThoiViec";
            this.NghiPhepThoiViec.Size = new System.Drawing.Size(268, 26);
            this.NghiPhepThoiViec.Text = "Đơn Nghỉ Phép - Thôi Việc";
            this.NghiPhepThoiViec.Click += new System.EventHandler(this.NghiPhepThoiViec_Click);
            // 
            // frmTrangChu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 538);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Name = "frmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm Quản lý nhân sự công ty Tinh Vân Software";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTrangChu_FormClosing);
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnPhongBan;
        private System.Windows.Forms.ToolStripMenuItem mnChucVu;
        private System.Windows.Forms.ToolStripMenuItem mnNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnNhanSu;
        private System.Windows.Forms.ToolStripMenuItem mnBBDanhGia;
        private System.Windows.Forms.ToolStripMenuItem mnQDBoNhiem;
        private System.Windows.Forms.ToolStripMenuItem mnHDLaoDong;
        private System.Windows.Forms.ToolStripMenuItem mnNghiPhepThoiViec;
        private System.Windows.Forms.ToolStripMenuItem mnKeToan;
        private System.Windows.Forms.ToolStripMenuItem mnLuongNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnBangChamCong;
        private System.Windows.Forms.ToolStripMenuItem mnSupport;
        private System.Windows.Forms.ToolStripMenuItem mnManager;
        private System.Windows.Forms.ToolStripMenuItem mnDangXuat;
        private System.Windows.Forms.ToolStripMenuItem DoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem mnKhenThuongKyLuat;
        private System.Windows.Forms.ToolStripMenuItem NghiPhepThoiViec;
        private System.Windows.Forms.ToolStripMenuItem mnTaiKhoan;
    }
}