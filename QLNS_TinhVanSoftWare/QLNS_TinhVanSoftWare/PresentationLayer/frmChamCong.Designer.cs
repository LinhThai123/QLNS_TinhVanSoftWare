
namespace QLNS_TinhVanSoftWare.PresentationLayer
{
    partial class frmChamCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChamCong));
            this.grbHopDong = new System.Windows.Forms.GroupBox();
            this.dgvChamCong = new System.Windows.Forms.DataGridView();
            this.clMaChamCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaNv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenNv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayChamCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGioVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGioRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cmbMaNv = new System.Windows.Forms.ComboBox();
            this.lblTenNv = new System.Windows.Forms.Label();
            this.txtTenNv = new System.Windows.Forms.TextBox();
            this.lblNgayKy = new System.Windows.Forms.Label();
            this.dtpNgayChamCong = new System.Windows.Forms.DateTimePicker();
            this.lblMaHd = new System.Windows.Forms.Label();
            this.cmbMaChamCong = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.grbHopDong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // grbHopDong
            // 
            this.grbHopDong.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grbHopDong.Controls.Add(this.dgvChamCong);
            this.grbHopDong.Controls.Add(this.label1);
            this.grbHopDong.Controls.Add(this.btnSua);
            this.grbHopDong.Controls.Add(this.btnLamMoi);
            this.grbHopDong.Controls.Add(this.btnXoa);
            this.grbHopDong.Controls.Add(this.btnTimKiem);
            this.grbHopDong.Controls.Add(this.cmbMaNv);
            this.grbHopDong.Controls.Add(this.lblTenNv);
            this.grbHopDong.Controls.Add(this.txtTenNv);
            this.grbHopDong.Controls.Add(this.lblNgayKy);
            this.grbHopDong.Controls.Add(this.dtpNgayChamCong);
            this.grbHopDong.Controls.Add(this.lblMaHd);
            this.grbHopDong.Controls.Add(this.cmbMaChamCong);
            this.grbHopDong.Controls.Add(this.label13);
            this.grbHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbHopDong.Location = new System.Drawing.Point(12, 22);
            this.grbHopDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbHopDong.Name = "grbHopDong";
            this.grbHopDong.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbHopDong.Size = new System.Drawing.Size(1018, 510);
            this.grbHopDong.TabIndex = 28;
            this.grbHopDong.TabStop = false;
            this.grbHopDong.Text = "CHẤM CÔNG";
            // 
            // dgvChamCong
            // 
            this.dgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaChamCong,
            this.clMaNv,
            this.clTenNv,
            this.clNgayChamCong,
            this.clGioVao,
            this.clGioRa});
            this.dgvChamCong.Location = new System.Drawing.Point(10, 257);
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.RowHeadersWidth = 51;
            this.dgvChamCong.RowTemplate.Height = 24;
            this.dgvChamCong.Size = new System.Drawing.Size(981, 248);
            this.dgvChamCong.TabIndex = 60;
            // 
            // clMaChamCong
            // 
            this.clMaChamCong.HeaderText = "Mã chấm công";
            this.clMaChamCong.MinimumWidth = 6;
            this.clMaChamCong.Name = "clMaChamCong";
            this.clMaChamCong.Width = 180;
            // 
            // clMaNv
            // 
            this.clMaNv.HeaderText = "Mã nhân viên";
            this.clMaNv.MinimumWidth = 6;
            this.clMaNv.Name = "clMaNv";
            this.clMaNv.Width = 175;
            // 
            // clTenNv
            // 
            this.clTenNv.HeaderText = "Tên nhân viên";
            this.clTenNv.MinimumWidth = 6;
            this.clTenNv.Name = "clTenNv";
            this.clTenNv.Width = 175;
            // 
            // clNgayChamCong
            // 
            this.clNgayChamCong.HeaderText = "Ngày chấm";
            this.clNgayChamCong.MinimumWidth = 6;
            this.clNgayChamCong.Name = "clNgayChamCong";
            this.clNgayChamCong.Width = 150;
            // 
            // clGioVao
            // 
            this.clGioVao.HeaderText = "Giờ vào";
            this.clGioVao.MinimumWidth = 6;
            this.clGioVao.Name = "clGioVao";
            this.clGioVao.Width = 125;
            // 
            // clGioRa
            // 
            this.clGioRa.HeaderText = "Giờ ra";
            this.clGioRa.MinimumWidth = 6;
            this.clGioRa.Name = "clGioRa";
            this.clGioRa.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(548, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 55;
            this.label1.Text = "Mã nhân viên :";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.MintCream;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(600, 187);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(111, 35);
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
            this.btnLamMoi.Location = new System.Drawing.Point(881, 187);
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
            this.btnXoa.Location = new System.Drawing.Point(754, 187);
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
            this.btnTimKiem.Location = new System.Drawing.Point(443, 187);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(110, 35);
            this.btnTimKiem.TabIndex = 50;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // cmbMaNv
            // 
            this.cmbMaNv.FormattingEnabled = true;
            this.cmbMaNv.Location = new System.Drawing.Point(754, 57);
            this.cmbMaNv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMaNv.Name = "cmbMaNv";
            this.cmbMaNv.Size = new System.Drawing.Size(237, 32);
            this.cmbMaNv.TabIndex = 48;
            // 
            // lblTenNv
            // 
            this.lblTenNv.AutoSize = true;
            this.lblTenNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNv.Location = new System.Drawing.Point(548, 127);
            this.lblTenNv.Name = "lblTenNv";
            this.lblTenNv.Size = new System.Drawing.Size(142, 24);
            this.lblTenNv.TabIndex = 47;
            this.lblTenNv.Text = "Tên nhân viên :";
            // 
            // txtTenNv
            // 
            this.txtTenNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNv.Location = new System.Drawing.Point(754, 124);
            this.txtTenNv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNv.Name = "txtTenNv";
            this.txtTenNv.Size = new System.Drawing.Size(237, 27);
            this.txtTenNv.TabIndex = 46;
            // 
            // lblNgayKy
            // 
            this.lblNgayKy.AutoSize = true;
            this.lblNgayKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayKy.Location = new System.Drawing.Point(6, 127);
            this.lblNgayKy.Name = "lblNgayKy";
            this.lblNgayKy.Size = new System.Drawing.Size(164, 24);
            this.lblNgayKy.TabIndex = 43;
            this.lblNgayKy.Text = "Ngày chấm công :";
            // 
            // dtpNgayChamCong
            // 
            this.dtpNgayChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayChamCong.Location = new System.Drawing.Point(209, 122);
            this.dtpNgayChamCong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayChamCong.Name = "dtpNgayChamCong";
            this.dtpNgayChamCong.Size = new System.Drawing.Size(237, 29);
            this.dtpNgayChamCong.TabIndex = 42;
            // 
            // lblMaHd
            // 
            this.lblMaHd.AutoSize = true;
            this.lblMaHd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHd.Location = new System.Drawing.Point(6, 65);
            this.lblMaHd.Name = "lblMaHd";
            this.lblMaHd.Size = new System.Drawing.Size(136, 24);
            this.lblMaHd.TabIndex = 41;
            this.lblMaHd.Text = "Mã chấm công";
            // 
            // cmbMaChamCong
            // 
            this.cmbMaChamCong.FormattingEnabled = true;
            this.cmbMaChamCong.Location = new System.Drawing.Point(209, 57);
            this.cmbMaChamCong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMaChamCong.Name = "cmbMaChamCong";
            this.cmbMaChamCong.Size = new System.Drawing.Size(237, 32);
            this.cmbMaChamCong.TabIndex = 40;
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
            // frmChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1048, 543);
            this.Controls.Add(this.grbHopDong);
            this.Name = "frmChamCong";
            this.Text = "frmChamCong";
            this.grbHopDong.ResumeLayout(false);
            this.grbHopDong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHopDong;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cmbMaNv;
        private System.Windows.Forms.Label lblTenNv;
        private System.Windows.Forms.TextBox txtTenNv;
        private System.Windows.Forms.Label lblNgayKy;
        private System.Windows.Forms.DateTimePicker dtpNgayChamCong;
        private System.Windows.Forms.Label lblMaHd;
        private System.Windows.Forms.ComboBox cmbMaChamCong;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvChamCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaChamCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayChamCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGioVao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGioRa;
        private System.Windows.Forms.Label label1;
    }
}