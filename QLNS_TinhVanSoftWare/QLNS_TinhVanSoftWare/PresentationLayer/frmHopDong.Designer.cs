
namespace QLNS_TinhVanSoftWare.PresentationLayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHopDong));
            this.grbHopDong = new System.Windows.Forms.GroupBox();
            this.dgvHopDong = new System.Windows.Forms.DataGridView();
            this.clMaHd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThoiHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenNv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cmbPhongban = new System.Windows.Forms.ComboBox();
            this.cmbChucvu = new System.Windows.Forms.ComboBox();
            this.lblTenNv = new System.Windows.Forms.Label();
            this.txtTennv = new System.Windows.Forms.TextBox();
            this.lblNgayKy = new System.Windows.Forms.Label();
            this.dtpNgayky = new System.Windows.Forms.DateTimePicker();
            this.lblMaHd = new System.Windows.Forms.Label();
            this.cmbMahd = new System.Windows.Forms.ComboBox();
            this.lblPhongBan = new System.Windows.Forms.Label();
            this.txtThoihan = new System.Windows.Forms.TextBox();
            this.lblThoiHan = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbHopDong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).BeginInit();
            this.SuspendLayout();
            // 
            // grbHopDong
            // 
            this.grbHopDong.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grbHopDong.Controls.Add(this.btnThem);
            this.grbHopDong.Controls.Add(this.dgvHopDong);
            this.grbHopDong.Controls.Add(this.btnSua);
            this.grbHopDong.Controls.Add(this.btnLamMoi);
            this.grbHopDong.Controls.Add(this.btnXoa);
            this.grbHopDong.Controls.Add(this.btnTimKiem);
            this.grbHopDong.Controls.Add(this.cmbPhongban);
            this.grbHopDong.Controls.Add(this.cmbChucvu);
            this.grbHopDong.Controls.Add(this.lblTenNv);
            this.grbHopDong.Controls.Add(this.txtTennv);
            this.grbHopDong.Controls.Add(this.lblNgayKy);
            this.grbHopDong.Controls.Add(this.dtpNgayky);
            this.grbHopDong.Controls.Add(this.lblMaHd);
            this.grbHopDong.Controls.Add(this.cmbMahd);
            this.grbHopDong.Controls.Add(this.lblPhongBan);
            this.grbHopDong.Controls.Add(this.txtThoihan);
            this.grbHopDong.Controls.Add(this.lblThoiHan);
            this.grbHopDong.Controls.Add(this.lblChucVu);
            this.grbHopDong.Controls.Add(this.txtLuong);
            this.grbHopDong.Controls.Add(this.label13);
            this.grbHopDong.Controls.Add(this.lblLuong);
            this.grbHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbHopDong.Location = new System.Drawing.Point(11, 25);
            this.grbHopDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbHopDong.Name = "grbHopDong";
            this.grbHopDong.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbHopDong.Size = new System.Drawing.Size(1361, 503);
            this.grbHopDong.TabIndex = 27;
            this.grbHopDong.TabStop = false;
            this.grbHopDong.Text = "HỢP ĐỒNG";
            // 
            // dgvHopDong
            // 
            this.dgvHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaHd,
            this.clNgayKy,
            this.clThoiHan,
            this.clTenNv,
            this.clChucVu,
            this.clPhongBan,
            this.clLuong});
            this.dgvHopDong.Location = new System.Drawing.Point(10, 296);
            this.dgvHopDong.Name = "dgvHopDong";
            this.dgvHopDong.RowHeadersWidth = 51;
            this.dgvHopDong.RowTemplate.Height = 24;
            this.dgvHopDong.Size = new System.Drawing.Size(1332, 198);
            this.dgvHopDong.TabIndex = 54;
            // 
            // clMaHd
            // 
            this.clMaHd.HeaderText = "Mã hợp đồng";
            this.clMaHd.MinimumWidth = 6;
            this.clMaHd.Name = "clMaHd";
            this.clMaHd.Width = 180;
            // 
            // clNgayKy
            // 
            this.clNgayKy.HeaderText = "Ngày ký";
            this.clNgayKy.MinimumWidth = 6;
            this.clNgayKy.Name = "clNgayKy";
            this.clNgayKy.Width = 160;
            // 
            // clThoiHan
            // 
            this.clThoiHan.HeaderText = "Thời hạn";
            this.clThoiHan.MinimumWidth = 6;
            this.clThoiHan.Name = "clThoiHan";
            this.clThoiHan.Width = 160;
            // 
            // clTenNv
            // 
            this.clTenNv.HeaderText = "Tên nhân viên";
            this.clTenNv.MinimumWidth = 6;
            this.clTenNv.Name = "clTenNv";
            this.clTenNv.Width = 250;
            // 
            // clChucVu
            // 
            this.clChucVu.HeaderText = "Chức vụ";
            this.clChucVu.MinimumWidth = 6;
            this.clChucVu.Name = "clChucVu";
            this.clChucVu.Width = 160;
            // 
            // clPhongBan
            // 
            this.clPhongBan.HeaderText = "Phòng ban";
            this.clPhongBan.MinimumWidth = 6;
            this.clPhongBan.Name = "clPhongBan";
            this.clPhongBan.Width = 160;
            // 
            // clLuong
            // 
            this.clLuong.HeaderText = "Lương";
            this.clLuong.MinimumWidth = 6;
            this.clLuong.Name = "clLuong";
            this.clLuong.Width = 210;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.MintCream;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(931, 215);
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
            this.btnLamMoi.Location = new System.Drawing.Point(1232, 215);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(110, 35);
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
            this.btnXoa.Location = new System.Drawing.Point(1097, 215);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 35);
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
            this.btnTimKiem.Location = new System.Drawing.Point(644, 215);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(110, 35);
            this.btnTimKiem.TabIndex = 50;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // cmbPhongban
            // 
            this.cmbPhongban.FormattingEnabled = true;
            this.cmbPhongban.Location = new System.Drawing.Point(1105, 62);
            this.cmbPhongban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPhongban.Name = "cmbPhongban";
            this.cmbPhongban.Size = new System.Drawing.Size(237, 32);
            this.cmbPhongban.TabIndex = 49;
            // 
            // cmbChucvu
            // 
            this.cmbChucvu.FormattingEnabled = true;
            this.cmbChucvu.Location = new System.Drawing.Point(631, 122);
            this.cmbChucvu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbChucvu.Name = "cmbChucvu";
            this.cmbChucvu.Size = new System.Drawing.Size(237, 32);
            this.cmbChucvu.TabIndex = 48;
            // 
            // lblTenNv
            // 
            this.lblTenNv.AutoSize = true;
            this.lblTenNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNv.Location = new System.Drawing.Point(465, 70);
            this.lblTenNv.Name = "lblTenNv";
            this.lblTenNv.Size = new System.Drawing.Size(142, 24);
            this.lblTenNv.TabIndex = 47;
            this.lblTenNv.Text = "Tên nhân viên :";
            // 
            // txtTennv
            // 
            this.txtTennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTennv.Location = new System.Drawing.Point(631, 67);
            this.txtTennv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTennv.Name = "txtTennv";
            this.txtTennv.Size = new System.Drawing.Size(237, 27);
            this.txtTennv.TabIndex = 46;
            // 
            // lblNgayKy
            // 
            this.lblNgayKy.AutoSize = true;
            this.lblNgayKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayKy.Location = new System.Drawing.Point(6, 126);
            this.lblNgayKy.Name = "lblNgayKy";
            this.lblNgayKy.Size = new System.Drawing.Size(87, 24);
            this.lblNgayKy.TabIndex = 43;
            this.lblNgayKy.Text = "Ngày ký :";
            // 
            // dtpNgayky
            // 
            this.dtpNgayky.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayky.Location = new System.Drawing.Point(169, 128);
            this.dtpNgayky.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayky.Name = "dtpNgayky";
            this.dtpNgayky.Size = new System.Drawing.Size(237, 29);
            this.dtpNgayky.TabIndex = 42;
            // 
            // lblMaHd
            // 
            this.lblMaHd.AutoSize = true;
            this.lblMaHd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHd.Location = new System.Drawing.Point(6, 65);
            this.lblMaHd.Name = "lblMaHd";
            this.lblMaHd.Size = new System.Drawing.Size(134, 24);
            this.lblMaHd.TabIndex = 41;
            this.lblMaHd.Text = "Mã hợp đồng :";
            // 
            // cmbMahd
            // 
            this.cmbMahd.FormattingEnabled = true;
            this.cmbMahd.Location = new System.Drawing.Point(169, 62);
            this.cmbMahd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMahd.Name = "cmbMahd";
            this.cmbMahd.Size = new System.Drawing.Size(237, 32);
            this.cmbMahd.TabIndex = 40;
            // 
            // lblPhongBan
            // 
            this.lblPhongBan.AutoSize = true;
            this.lblPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhongBan.Location = new System.Drawing.Point(950, 70);
            this.lblPhongBan.Name = "lblPhongBan";
            this.lblPhongBan.Size = new System.Drawing.Size(118, 24);
            this.lblPhongBan.TabIndex = 18;
            this.lblPhongBan.Text = "Phòng ban  :";
            // 
            // txtThoihan
            // 
            this.txtThoihan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoihan.Location = new System.Drawing.Point(169, 191);
            this.txtThoihan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThoihan.Name = "txtThoihan";
            this.txtThoihan.Size = new System.Drawing.Size(237, 27);
            this.txtThoihan.TabIndex = 4;
            // 
            // lblThoiHan
            // 
            this.lblThoiHan.AutoSize = true;
            this.lblThoiHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiHan.Location = new System.Drawing.Point(6, 194);
            this.lblThoiHan.Name = "lblThoiHan";
            this.lblThoiHan.Size = new System.Drawing.Size(95, 24);
            this.lblThoiHan.TabIndex = 3;
            this.lblThoiHan.Text = "Thời hạn :";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.Location = new System.Drawing.Point(465, 133);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(95, 24);
            this.lblChucVu.TabIndex = 12;
            this.lblChucVu.Text = "Chức vụ  :";
            // 
            // txtLuong
            // 
            this.txtLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuong.Location = new System.Drawing.Point(1105, 130);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(237, 27);
            this.txtLuong.TabIndex = 36;
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
            this.lblLuong.Location = new System.Drawing.Point(950, 133);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(79, 24);
            this.lblLuong.TabIndex = 20;
            this.lblLuong.Text = "Lương  :";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.MintCream;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(788, 215);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 35);
            this.btnThem.TabIndex = 55;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseMnemonic = false;
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // frmHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1383, 548);
            this.Controls.Add(this.grbHopDong);
            this.Name = "frmHopDong";
            this.Text = "frmHopDong";
            this.grbHopDong.ResumeLayout(false);
            this.grbHopDong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHopDong;
        private System.Windows.Forms.Label lblPhongBan;
        private System.Windows.Forms.TextBox txtThoihan;
        private System.Windows.Forms.Label lblThoiHan;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label lblMaHd;
        private System.Windows.Forms.ComboBox cmbMahd;
        private System.Windows.Forms.Label lblNgayKy;
        private System.Windows.Forms.DateTimePicker dtpNgayky;
        private System.Windows.Forms.ComboBox cmbPhongban;
        private System.Windows.Forms.ComboBox cmbChucvu;
        private System.Windows.Forms.Label lblTenNv;
        private System.Windows.Forms.TextBox txtTennv;
        private System.Windows.Forms.DataGridView dgvHopDong;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaHd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThoiHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLuong;
        private System.Windows.Forms.Button btnThem;
    }
}