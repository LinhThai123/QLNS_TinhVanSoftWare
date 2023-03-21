namespace QLNS_TinhVanSoftWare.PresentationLayer
{
    partial class frmKhenThuongKyLuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhenThuongKyLuat));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKhenThuongKyLuat = new System.Windows.Forms.DataGridView();
            this.colMaQĐ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNglap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiQĐ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLydo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCNhapKTKL = new System.Windows.Forms.Button();
            this.btnXoaKTKL = new System.Windows.Forms.Button();
            this.btnTimKTKL = new System.Windows.Forms.Button();
            this.btnThemKTKL = new System.Windows.Forms.Button();
            this.cmbMaNV = new System.Windows.Forms.ComboBox();
            this.cmbMucKhenKy = new System.Windows.Forms.ComboBox();
            this.cmbLoaiQD = new System.Windows.Forms.ComboBox();
            this.txtMaQD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTenPB = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLydo = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTenCV = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dNgaylap = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProviderKhenThuongKyLuat = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhenThuongKyLuat)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKhenThuongKyLuat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.dgvKhenThuongKyLuat);
            this.groupBox1.Controls.Add(this.btnCNhapKTKL);
            this.groupBox1.Controls.Add(this.btnXoaKTKL);
            this.groupBox1.Controls.Add(this.btnTimKTKL);
            this.groupBox1.Controls.Add(this.btnThemKTKL);
            this.groupBox1.Controls.Add(this.cmbMaNV);
            this.groupBox1.Controls.Add(this.cmbMucKhenKy);
            this.groupBox1.Controls.Add(this.cmbLoaiQD);
            this.groupBox1.Controls.Add(this.txtMaQD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbTenPB);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbTenCV);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dNgaylap);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(11, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1183, 513);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // dgvKhenThuongKyLuat
            // 
            this.dgvKhenThuongKyLuat.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvKhenThuongKyLuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhenThuongKyLuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaQĐ,
            this.colMaNV,
            this.colTenNV,
            this.colTenCV,
            this.colTenPB,
            this.colNglap,
            this.colLoaiQĐ,
            this.colMuc,
            this.colLydo});
            this.dgvKhenThuongKyLuat.Location = new System.Drawing.Point(0, 301);
            this.dgvKhenThuongKyLuat.Name = "dgvKhenThuongKyLuat";
            this.dgvKhenThuongKyLuat.Size = new System.Drawing.Size(890, 179);
            this.dgvKhenThuongKyLuat.TabIndex = 66;
            // 
            // colMaQĐ
            // 
            this.colMaQĐ.HeaderText = "Mã quyết định";
            this.colMaQĐ.Name = "colMaQĐ";
            this.colMaQĐ.Width = 150;
            // 
            // colMaNV
            // 
            this.colMaNV.HeaderText = "Mã nhân viên";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Width = 150;
            // 
            // colTenNV
            // 
            this.colTenNV.HeaderText = "Tên Nhân viên";
            this.colTenNV.Name = "colTenNV";
            this.colTenNV.Width = 150;
            // 
            // colTenCV
            // 
            this.colTenCV.HeaderText = "Tên chức vụ";
            this.colTenCV.Name = "colTenCV";
            this.colTenCV.Width = 140;
            // 
            // colTenPB
            // 
            this.colTenPB.HeaderText = "Tên phòng ban";
            this.colTenPB.Name = "colTenPB";
            this.colTenPB.Width = 160;
            // 
            // colNglap
            // 
            this.colNglap.HeaderText = "Ngày lập";
            this.colNglap.Name = "colNglap";
            this.colNglap.Width = 130;
            // 
            // colLoaiQĐ
            // 
            this.colLoaiQĐ.HeaderText = "Loại quyết định";
            this.colLoaiQĐ.Name = "colLoaiQĐ";
            this.colLoaiQĐ.Width = 160;
            // 
            // colMuc
            // 
            this.colMuc.HeaderText = "Mức";
            this.colMuc.Name = "colMuc";
            // 
            // colLydo
            // 
            this.colLydo.HeaderText = "Lý do";
            this.colLydo.Name = "colLydo";
            // 
            // btnCNhapKTKL
            // 
            this.btnCNhapKTKL.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnCNhapKTKL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCNhapKTKL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCNhapKTKL.ForeColor = System.Drawing.Color.MintCream;
            this.btnCNhapKTKL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCNhapKTKL.Location = new System.Drawing.Point(410, 243);
            this.btnCNhapKTKL.Margin = new System.Windows.Forms.Padding(2);
            this.btnCNhapKTKL.Name = "btnCNhapKTKL";
            this.btnCNhapKTKL.Size = new System.Drawing.Size(85, 34);
            this.btnCNhapKTKL.TabIndex = 65;
            this.btnCNhapKTKL.Text = "Cập nhật";
            this.btnCNhapKTKL.UseVisualStyleBackColor = false;
            this.btnCNhapKTKL.Click += new System.EventHandler(this.btnCNhapKTKL_Click);
            // 
            // btnXoaKTKL
            // 
            this.btnXoaKTKL.BackColor = System.Drawing.Color.Red;
            this.btnXoaKTKL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoaKTKL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKTKL.ForeColor = System.Drawing.Color.MintCream;
            this.btnXoaKTKL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaKTKL.Location = new System.Drawing.Point(659, 243);
            this.btnXoaKTKL.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaKTKL.Name = "btnXoaKTKL";
            this.btnXoaKTKL.Size = new System.Drawing.Size(87, 34);
            this.btnXoaKTKL.TabIndex = 64;
            this.btnXoaKTKL.Text = "Xoá";
            this.btnXoaKTKL.UseVisualStyleBackColor = false;
            // 
            // btnTimKTKL
            // 
            this.btnTimKTKL.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTimKTKL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTimKTKL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKTKL.ForeColor = System.Drawing.Color.MintCream;
            this.btnTimKTKL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKTKL.Location = new System.Drawing.Point(536, 243);
            this.btnTimKTKL.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKTKL.Name = "btnTimKTKL";
            this.btnTimKTKL.Size = new System.Drawing.Size(79, 34);
            this.btnTimKTKL.TabIndex = 63;
            this.btnTimKTKL.Text = "Tìm kiếm";
            this.btnTimKTKL.UseVisualStyleBackColor = false;
            // 
            // btnThemKTKL
            // 
            this.btnThemKTKL.BackColor = System.Drawing.Color.ForestGreen;
            this.btnThemKTKL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemKTKL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKTKL.ForeColor = System.Drawing.Color.MintCream;
            this.btnThemKTKL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemKTKL.Location = new System.Drawing.Point(281, 243);
            this.btnThemKTKL.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemKTKL.Name = "btnThemKTKL";
            this.btnThemKTKL.Size = new System.Drawing.Size(92, 34);
            this.btnThemKTKL.TabIndex = 62;
            this.btnThemKTKL.Text = "Thêm mới";
            this.btnThemKTKL.UseVisualStyleBackColor = false;
            this.btnThemKTKL.Click += new System.EventHandler(this.btnThemKTKL_Click);
            // 
            // cmbMaNV
            // 
            this.cmbMaNV.FormattingEnabled = true;
            this.cmbMaNV.Location = new System.Drawing.Point(125, 89);
            this.cmbMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMaNV.Name = "cmbMaNV";
            this.cmbMaNV.Size = new System.Drawing.Size(126, 28);
            this.cmbMaNV.TabIndex = 61;
            // 
            // cmbMucKhenKy
            // 
            this.cmbMucKhenKy.FormattingEnabled = true;
            this.cmbMucKhenKy.Location = new System.Drawing.Point(391, 137);
            this.cmbMucKhenKy.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMucKhenKy.Name = "cmbMucKhenKy";
            this.cmbMucKhenKy.Size = new System.Drawing.Size(158, 28);
            this.cmbMucKhenKy.TabIndex = 60;
            // 
            // cmbLoaiQD
            // 
            this.cmbLoaiQD.FormattingEnabled = true;
            this.cmbLoaiQD.Location = new System.Drawing.Point(391, 89);
            this.cmbLoaiQD.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLoaiQD.Name = "cmbLoaiQD";
            this.cmbLoaiQD.Size = new System.Drawing.Size(158, 28);
            this.cmbLoaiQD.TabIndex = 59;
            // 
            // txtMaQD
            // 
            this.txtMaQD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaQD.Location = new System.Drawing.Point(125, 51);
            this.txtMaQD.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaQD.Name = "txtMaQD";
            this.txtMaQD.Size = new System.Drawing.Size(126, 23);
            this.txtMaQD.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 57;
            this.label2.Text = "Mã quyết định :";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(125, 137);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(126, 23);
            this.txtTenNV.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 55;
            this.label1.Text = "Tên nhân viên :";
            // 
            // cmbTenPB
            // 
            this.cmbTenPB.FormattingEnabled = true;
            this.cmbTenPB.Location = new System.Drawing.Point(125, 221);
            this.cmbTenPB.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTenPB.Name = "cmbTenPB";
            this.cmbTenPB.Size = new System.Drawing.Size(126, 28);
            this.cmbTenPB.TabIndex = 54;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLydo);
            this.groupBox3.Location = new System.Drawing.Point(602, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 189);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lý do";
            // 
            // txtLydo
            // 
            this.txtLydo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLydo.Location = new System.Drawing.Point(6, 23);
            this.txtLydo.Name = "txtLydo";
            this.txtLydo.Size = new System.Drawing.Size(232, 166);
            this.txtLydo.TabIndex = 0;
            this.txtLydo.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 228);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 18);
            this.label11.TabIndex = 43;
            this.label11.Text = "Tên phòng ban :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 42;
            this.label4.Text = "Tên chức vụ :";
            // 
            // cmbTenCV
            // 
            this.cmbTenCV.FormattingEnabled = true;
            this.cmbTenCV.Location = new System.Drawing.Point(125, 178);
            this.cmbTenCV.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTenCV.Name = "cmbTenCV";
            this.cmbTenCV.Size = new System.Drawing.Size(126, 28);
            this.cmbTenCV.TabIndex = 49;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 99);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 18);
            this.label14.TabIndex = 47;
            this.label14.Text = "Mã nhân viên :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(278, 54);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 18);
            this.label10.TabIndex = 46;
            this.label10.Text = "Ngày lập :";
            // 
            // dNgaylap
            // 
            this.dNgaylap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dNgaylap.Location = new System.Drawing.Point(391, 51);
            this.dNgaylap.Margin = new System.Windows.Forms.Padding(2);
            this.dNgaylap.Name = "dNgaylap";
            this.dNgaylap.Size = new System.Drawing.Size(158, 24);
            this.dNgaylap.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(278, 141);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 18);
            this.label13.TabIndex = 44;
            this.label13.Text = "Mức:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(278, 99);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 18);
            this.label12.TabIndex = 40;
            this.label12.Text = "Loại quyết định:";
            
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(398, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "KHEN THƯỞNG - KỶ LUẬT";
           
            // 
            // errorProviderKhenThuongKyLuat
            // 
            this.errorProviderKhenThuongKyLuat.ContainerControl = this;
            // 
            // frmKhenThuongKyLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1217, 569);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmKhenThuongKyLuat";
            this.Text = "frmKhenThuongKyLuat";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhenThuongKyLuat)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKhenThuongKyLuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTenPB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox txtLydo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTenCV;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dNgaylap;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaQD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMaNV;
        private System.Windows.Forms.ComboBox cmbMucKhenKy;
        private System.Windows.Forms.ComboBox cmbLoaiQD;
        private System.Windows.Forms.Button btnCNhapKTKL;
        private System.Windows.Forms.Button btnXoaKTKL;
        private System.Windows.Forms.Button btnTimKTKL;
        private System.Windows.Forms.Button btnThemKTKL;
        private System.Windows.Forms.DataGridView dgvKhenThuongKyLuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaQĐ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNglap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiQĐ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLydo;
        private System.Windows.Forms.ErrorProvider errorProviderKhenThuongKyLuat;
    }
}