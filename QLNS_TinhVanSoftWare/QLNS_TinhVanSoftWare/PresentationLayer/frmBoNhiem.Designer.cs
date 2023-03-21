namespace QLNS_TinhVanSoftWare.PresentationLayer
{
    partial class frmBoNhiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBoNhiem));
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBoNhiem = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtNoiDung = new System.Windows.Forms.RichTextBox();
            this.dtpNgayHieuLuc = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.cmbChucVu = new System.Windows.Forms.ComboBox();
            this.cmbPhongBan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.nmrLuongMoi = new System.Windows.Forms.NumericUpDown();
            this.txtMabonhiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoNhiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrLuongMoi)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "Chức vụ mới :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(43, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 24);
            this.label11.TabIndex = 18;
            this.label11.Text = "Phòng ban mới :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(43, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(198, 24);
            this.label12.TabIndex = 20;
            this.label12.Text = "Mức lương mới (VND):";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.ForestGreen;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.MintCream;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(569, 255);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(118, 42);
            this.btnThem.TabIndex = 22;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.txtMabonhiem);
            this.groupBox2.Controls.Add(this.nmrLuongMoi);
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.txtNoiDung);
            this.groupBox2.Controls.Add(this.dtpNgayHieuLuc);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.cmbPhongBan);
            this.groupBox2.Controls.Add(this.cmbChucVu);
            this.groupBox2.Controls.Add(this.cmbNhanVien);
            this.groupBox2.Controls.Add(this.dgvBoNhiem);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1361, 620);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "QUYẾT ĐỊNH BỔ NHIỆM";
            // 
            // dgvBoNhiem
            // 
            this.dgvBoNhiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBoNhiem.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBoNhiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoNhiem.Location = new System.Drawing.Point(47, 343);
            this.dgvBoNhiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBoNhiem.Name = "dgvBoNhiem";
            this.dgvBoNhiem.RowHeadersWidth = 51;
            this.dgvBoNhiem.Size = new System.Drawing.Size(1267, 271);
            this.dgvBoNhiem.TabIndex = 43;
            this.dgvBoNhiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoNhiem_CellContentClick);
            this.dgvBoNhiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoNhiem_CellContentClick);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.MintCream;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(728, 255);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 42);
            this.btnSua.TabIndex = 42;
            this.btnSua.Text = "Cập nhật";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.MintCream;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(1209, 165);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 42);
            this.btnXoa.TabIndex = 41;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.MintCream;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(1052, 162);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(118, 42);
            this.btnTimKiem.TabIndex = 40;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Location = new System.Drawing.Point(569, 95);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(443, 109);
            this.txtNoiDung.TabIndex = 0;
            this.txtNoiDung.Text = "";
            // 
            // dtpNgayHieuLuc
            // 
            this.dtpNgayHieuLuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayHieuLuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHieuLuc.Location = new System.Drawing.Point(264, 268);
            this.dtpNgayHieuLuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayHieuLuc.Name = "dtpNgayHieuLuc";
            this.dtpNgayHieuLuc.Size = new System.Drawing.Size(240, 29);
            this.dtpNgayHieuLuc.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(43, 273);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(157, 24);
            this.label17.TabIndex = 30;
            this.label17.Text = "Ngày có hiệu lực:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(43, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 24);
            this.label14.TabIndex = 28;
            this.label14.Text = "Nhân viên :";
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Location = new System.Drawing.Point(208, 67);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(296, 32);
            this.cmbNhanVien.TabIndex = 44;
            // 
            // cmbChucVu
            // 
            this.cmbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChucVu.FormattingEnabled = true;
            this.cmbChucVu.Location = new System.Drawing.Point(208, 120);
            this.cmbChucVu.Name = "cmbChucVu";
            this.cmbChucVu.Size = new System.Drawing.Size(296, 32);
            this.cmbChucVu.TabIndex = 44;
            // 
            // cmbPhongBan
            // 
            this.cmbPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhongBan.FormattingEnabled = true;
            this.cmbPhongBan.Location = new System.Drawing.Point(208, 172);
            this.cmbPhongBan.Name = "cmbPhongBan";
            this.cmbPhongBan.Size = new System.Drawing.Size(296, 32);
            this.cmbPhongBan.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1048, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 48);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nhập mã bổ nhiệm\r\nđể tìm kiếm hoặc xóa:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.MintCream;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(893, 255);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(119, 42);
            this.btnLamMoi.TabIndex = 53;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // nmrLuongMoi
            // 
            this.nmrLuongMoi.Location = new System.Drawing.Point(264, 223);
            this.nmrLuongMoi.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nmrLuongMoi.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrLuongMoi.Name = "nmrLuongMoi";
            this.nmrLuongMoi.Size = new System.Drawing.Size(240, 29);
            this.nmrLuongMoi.TabIndex = 54;
            this.nmrLuongMoi.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // txtMabonhiem
            // 
            this.txtMabonhiem.Location = new System.Drawing.Point(1052, 118);
            this.txtMabonhiem.Name = "txtMabonhiem";
            this.txtMabonhiem.Size = new System.Drawing.Size(262, 29);
            this.txtMabonhiem.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(565, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nội dung:";
            // 
            // frmBoNhiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1393, 647);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBoNhiem";
            this.Text = "Quản lý bổ nhiệm";
            this.Load += new System.EventHandler(this.frmBoNhiem_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoNhiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrLuongMoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpNgayHieuLuc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox txtNoiDung;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvBoNhiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPhongBan;
        private System.Windows.Forms.ComboBox cmbChucVu;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.NumericUpDown nmrLuongMoi;
        private System.Windows.Forms.TextBox txtMabonhiem;
        private System.Windows.Forms.Label label2;
    }
}