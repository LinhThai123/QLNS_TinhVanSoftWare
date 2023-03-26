﻿namespace QLNS_TinhVanSoftWare.PresentationLayer
{
    partial class frmHopDong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHopDong));
            this.grbHopDong = new System.Windows.Forms.GroupBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.dgvHopDong = new System.Windows.Forms.DataGridView();
            this.nmrLuongCB = new System.Windows.Forms.NumericUpDown();
            this.nmrThoiHan = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cmbPhongban = new System.Windows.Forms.ComboBox();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.cmbChucvu = new System.Windows.Forms.ComboBox();
            this.lblTenNv = new System.Windows.Forms.Label();
            this.lblPhongBan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblThoiHan = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbHopDong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrLuongCB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrThoiHan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbHopDong
            // 
            this.grbHopDong.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grbHopDong.Controls.Add(this.txtMaHD);
            this.grbHopDong.Controls.Add(this.nmrLuongCB);
            this.grbHopDong.Controls.Add(this.nmrThoiHan);
            this.grbHopDong.Controls.Add(this.btnThem);
            this.grbHopDong.Controls.Add(this.btnSua);
            this.grbHopDong.Controls.Add(this.btnLamMoi);
            this.grbHopDong.Controls.Add(this.btnXoa);
            this.grbHopDong.Controls.Add(this.btnTimKiem);
            this.grbHopDong.Controls.Add(this.cmbPhongban);
            this.grbHopDong.Controls.Add(this.cmbNhanVien);
            this.grbHopDong.Controls.Add(this.cmbChucvu);
            this.grbHopDong.Controls.Add(this.lblTenNv);
            this.grbHopDong.Controls.Add(this.lblPhongBan);
            this.grbHopDong.Controls.Add(this.label1);
            this.grbHopDong.Controls.Add(this.lblThoiHan);
            this.grbHopDong.Controls.Add(this.lblChucVu);
            this.grbHopDong.Controls.Add(this.label13);
            this.grbHopDong.Controls.Add(this.lblLuong);
            this.grbHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbHopDong.Location = new System.Drawing.Point(13, 25);
            this.grbHopDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbHopDong.Name = "grbHopDong";
            this.grbHopDong.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbHopDong.Size = new System.Drawing.Size(1230, 272);
            this.grbHopDong.TabIndex = 27;
            this.grbHopDong.TabStop = false;
            this.grbHopDong.Text = "Hợp đồng";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(924, 109);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(264, 29);
            this.txtMaHD.TabIndex = 55;
            // 
            // dgvHopDong
            // 
            this.dgvHopDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHopDong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHopDong.Location = new System.Drawing.Point(14, 317);
            this.dgvHopDong.Name = "dgvHopDong";
            this.dgvHopDong.RowHeadersWidth = 51;
            this.dgvHopDong.RowTemplate.Height = 24;
            this.dgvHopDong.Size = new System.Drawing.Size(1229, 310);
            this.dgvHopDong.TabIndex = 54;
            // 
            // nmrLuongCB
            // 
            this.nmrLuongCB.Location = new System.Drawing.Point(424, 144);
            this.nmrLuongCB.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmrLuongCB.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrLuongCB.Name = "nmrLuongCB";
            this.nmrLuongCB.Size = new System.Drawing.Size(190, 29);
            this.nmrLuongCB.TabIndex = 5;
            this.nmrLuongCB.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // nmrThoiHan
            // 
            this.nmrThoiHan.Location = new System.Drawing.Point(424, 75);
            this.nmrThoiHan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrThoiHan.Name = "nmrThoiHan";
            this.nmrThoiHan.Size = new System.Drawing.Size(148, 29);
            this.nmrThoiHan.TabIndex = 4;
            this.nmrThoiHan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.MintCream;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(693, 48);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(119, 35);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseMnemonic = false;
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.MintCream;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(693, 106);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(119, 35);
            this.btnSua.TabIndex = 53;
            this.btnSua.Text = "Cập nhật";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.MintCream;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(693, 166);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(119, 35);
            this.btnLamMoi.TabIndex = 52;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.MintCream;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(924, 166);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 35);
            this.btnXoa.TabIndex = 51;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.MintCream;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(1076, 166);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(112, 35);
            this.btnTimKiem.TabIndex = 50;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // cmbPhongban
            // 
            this.cmbPhongban.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhongban.FormattingEnabled = true;
            this.cmbPhongban.Location = new System.Drawing.Point(42, 215);
            this.cmbPhongban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPhongban.Name = "cmbPhongban";
            this.cmbPhongban.Size = new System.Drawing.Size(319, 32);
            this.cmbPhongban.TabIndex = 3;
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Items.AddRange(new object[] {
            "Chọn nhân viên"});
            this.cmbNhanVien.Location = new System.Drawing.Point(42, 74);
            this.cmbNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(319, 32);
            this.cmbNhanVien.TabIndex = 1;
            // 
            // cmbChucvu
            // 
            this.cmbChucvu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChucvu.FormattingEnabled = true;
            this.cmbChucvu.Location = new System.Drawing.Point(42, 143);
            this.cmbChucvu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbChucvu.Name = "cmbChucvu";
            this.cmbChucvu.Size = new System.Drawing.Size(319, 32);
            this.cmbChucvu.TabIndex = 2;
            // 
            // lblTenNv
            // 
            this.lblTenNv.AutoSize = true;
            this.lblTenNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNv.Location = new System.Drawing.Point(38, 48);
            this.lblTenNv.Name = "lblTenNv";
            this.lblTenNv.Size = new System.Drawing.Size(106, 24);
            this.lblTenNv.TabIndex = 47;
            this.lblTenNv.Text = "Nhân viên :";
            // 
            // lblPhongBan
            // 
            this.lblPhongBan.AutoSize = true;
            this.lblPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhongBan.Location = new System.Drawing.Point(38, 189);
            this.lblPhongBan.Name = "lblPhongBan";
            this.lblPhongBan.Size = new System.Drawing.Size(118, 24);
            this.lblPhongBan.TabIndex = 18;
            this.lblPhongBan.Text = "Phòng ban  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(920, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập mã hợp đồng\r\nđể tìm kiếm hoặc xóa:";
            // 
            // lblThoiHan
            // 
            this.lblThoiHan.AutoSize = true;
            this.lblThoiHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiHan.Location = new System.Drawing.Point(420, 48);
            this.lblThoiHan.Name = "lblThoiHan";
            this.lblThoiHan.Size = new System.Drawing.Size(152, 24);
            this.lblThoiHan.TabIndex = 3;
            this.lblThoiHan.Text = "Thời hạn (Năm) :";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.Location = new System.Drawing.Point(38, 117);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(95, 24);
            this.lblChucVu.TabIndex = 12;
            this.lblChucVu.Text = "Chức vụ  :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(465, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 24);
            this.label13.TabIndex = 25;
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuong.Location = new System.Drawing.Point(420, 117);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(194, 24);
            this.lblLuong.TabIndex = 20;
            this.lblLuong.Text = "Lương cơ bản (VND) :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1259, 649);
            this.Controls.Add(this.grbHopDong);
            this.Controls.Add(this.dgvHopDong);
            this.Name = "frmHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hợp đồng";
            this.grbHopDong.ResumeLayout(false);
            this.grbHopDong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrLuongCB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrThoiHan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHopDong;
        private System.Windows.Forms.Label lblPhongBan;
        private System.Windows.Forms.Label lblThoiHan;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.ComboBox cmbPhongban;
        private System.Windows.Forms.ComboBox cmbChucvu;
        private System.Windows.Forms.Label lblTenNv;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.NumericUpDown nmrThoiHan;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private System.Windows.Forms.NumericUpDown nmrLuongCB;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgvHopDong;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label1;
    }
}