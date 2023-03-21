
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cmbMaNv = new System.Windows.Forms.ComboBox();
            this.lblNgayKy = new System.Windows.Forms.Label();
            this.dtpNgayChamCong = new System.Windows.Forms.DateTimePicker();
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
            this.grbHopDong.Controls.Add(this.btnTimKiem);
            this.grbHopDong.Controls.Add(this.cmbMaNv);
            this.grbHopDong.Controls.Add(this.lblNgayKy);
            this.grbHopDong.Controls.Add(this.dtpNgayChamCong);
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
            this.dgvChamCong.Location = new System.Drawing.Point(10, 185);
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.RowHeadersWidth = 51;
            this.dgvChamCong.RowTemplate.Height = 24;
            this.dgvChamCong.Size = new System.Drawing.Size(981, 320);
            this.dgvChamCong.TabIndex = 60;
            this.dgvChamCong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChamCong_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 55;
            this.label1.Text = "Mã nhân viên :";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.MintCream;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(552, 98);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(110, 35);
            this.btnTimKiem.TabIndex = 50;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cmbMaNv
            // 
            this.cmbMaNv.FormattingEnabled = true;
            this.cmbMaNv.Location = new System.Drawing.Point(218, 49);
            this.cmbMaNv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMaNv.Name = "cmbMaNv";
            this.cmbMaNv.Size = new System.Drawing.Size(237, 32);
            this.cmbMaNv.TabIndex = 48;
            this.cmbMaNv.SelectedIndexChanged += new System.EventHandler(this.cmbMaNv_SelectedIndexChanged);
            // 
            // lblNgayKy
            // 
            this.lblNgayKy.AutoSize = true;
            this.lblNgayKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayKy.Location = new System.Drawing.Point(30, 114);
            this.lblNgayKy.Name = "lblNgayKy";
            this.lblNgayKy.Size = new System.Drawing.Size(164, 24);
            this.lblNgayKy.TabIndex = 43;
            this.lblNgayKy.Text = "Ngày chấm công :";
            // 
            // dtpNgayChamCong
            // 
            this.dtpNgayChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayChamCong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayChamCong.Location = new System.Drawing.Point(218, 114);
            this.dtpNgayChamCong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayChamCong.Name = "dtpNgayChamCong";
            this.dtpNgayChamCong.Size = new System.Drawing.Size(237, 29);
            this.dtpNgayChamCong.TabIndex = 42;
            this.dtpNgayChamCong.Value = new System.DateTime(2023, 3, 20, 0, 0, 0, 0);
            this.dtpNgayChamCong.ValueChanged += new System.EventHandler(this.dtpNgayChamCong_ValueChanged);
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
            this.Load += new System.EventHandler(this.frmChamCong_Load);
            this.grbHopDong.ResumeLayout(false);
            this.grbHopDong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHopDong;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cmbMaNv;
        private System.Windows.Forms.Label lblNgayKy;
        private System.Windows.Forms.DateTimePicker dtpNgayChamCong;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvChamCong;
        private System.Windows.Forms.Label label1;
    }
}