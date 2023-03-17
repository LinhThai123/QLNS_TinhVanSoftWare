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
            this.txtMabonhiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnThemBN = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvListBN = new System.Windows.Forms.DataGridView();
            this.btnCNhapBN = new System.Windows.Forms.Button();
            this.btnXoaBN = new System.Windows.Forms.Button();
            this.btnTimBN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNDBonhiem = new System.Windows.Forms.RichTextBox();
            this.txtLuongmoi = new System.Windows.Forms.TextBox();
            this.dtpNgaycohieuluc = new System.Windows.Forms.DateTimePicker();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMabonhiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaycohieuluc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLuongmoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNDBonhiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCVmoi = new System.Windows.Forms.TextBox();
            this.txtPBmoi = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListBN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMabonhiem
            // 
            this.txtMabonhiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMabonhiem.Location = new System.Drawing.Point(452, 52);
            this.txtMabonhiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtMabonhiem.Name = "txtMabonhiem";
            this.txtMabonhiem.Size = new System.Drawing.Size(179, 23);
            this.txtMabonhiem.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(334, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mã bổ nhiệm:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 100);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Chức vụ mới :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(32, 142);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = "Phòng ban mới :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(32, 181);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 18);
            this.label12.TabIndex = 20;
            this.label12.Text = "Mức lương mới:";
            // 
            // btnThemBN
            // 
            this.btnThemBN.BackColor = System.Drawing.Color.ForestGreen;
            this.btnThemBN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemBN.ForeColor = System.Drawing.Color.MintCream;
            this.btnThemBN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemBN.Location = new System.Drawing.Point(460, 222);
            this.btnThemBN.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemBN.Name = "btnThemBN";
            this.btnThemBN.Size = new System.Drawing.Size(103, 34);
            this.btnThemBN.TabIndex = 22;
            this.btnThemBN.Text = "Thêm mới";
            this.btnThemBN.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.txtPBmoi);
            this.groupBox2.Controls.Add(this.txtCVmoi);
            this.groupBox2.Controls.Add(this.dtgvListBN);
            this.groupBox2.Controls.Add(this.btnCNhapBN);
            this.groupBox2.Controls.Add(this.btnXoaBN);
            this.groupBox2.Controls.Add(this.btnTimBN);
            this.groupBox2.Controls.Add(this.btnThemBN);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtLuongmoi);
            this.groupBox2.Controls.Add(this.dtpNgaycohieuluc);
            this.groupBox2.Controls.Add(this.txtMaNV);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtMabonhiem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(1021, 504);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "QUYẾT ĐỊNH BỔ NHIỆM";
            // 
            // dtgvListBN
            // 
            this.dtgvListBN.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvListBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListBN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMabonhiem,
            this.colNgaylap,
            this.colNgaycohieuluc,
            this.colMaNV,
            this.colMaCV,
            this.colMaPB,
            this.colLuongmoi,
            this.colNDBonhiem});
            this.dtgvListBN.Location = new System.Drawing.Point(35, 279);
            this.dtgvListBN.Name = "dtgvListBN";
            this.dtgvListBN.Size = new System.Drawing.Size(950, 220);
            this.dtgvListBN.TabIndex = 43;
            // 
            // btnCNhapBN
            // 
            this.btnCNhapBN.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnCNhapBN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCNhapBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCNhapBN.ForeColor = System.Drawing.Color.MintCream;
            this.btnCNhapBN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCNhapBN.Location = new System.Drawing.Point(601, 222);
            this.btnCNhapBN.Margin = new System.Windows.Forms.Padding(2);
            this.btnCNhapBN.Name = "btnCNhapBN";
            this.btnCNhapBN.Size = new System.Drawing.Size(103, 34);
            this.btnCNhapBN.TabIndex = 42;
            this.btnCNhapBN.Text = "Cập nhật";
            this.btnCNhapBN.UseVisualStyleBackColor = false;
            // 
            // btnXoaBN
            // 
            this.btnXoaBN.BackColor = System.Drawing.Color.Red;
            this.btnXoaBN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoaBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaBN.ForeColor = System.Drawing.Color.MintCream;
            this.btnXoaBN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaBN.Location = new System.Drawing.Point(879, 222);
            this.btnXoaBN.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaBN.Name = "btnXoaBN";
            this.btnXoaBN.Size = new System.Drawing.Size(103, 34);
            this.btnXoaBN.TabIndex = 41;
            this.btnXoaBN.Text = "Xoá";
            this.btnXoaBN.UseVisualStyleBackColor = false;
            // 
            // btnTimBN
            // 
            this.btnTimBN.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTimBN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTimBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimBN.ForeColor = System.Drawing.Color.MintCream;
            this.btnTimBN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimBN.Location = new System.Drawing.Point(738, 222);
            this.btnTimBN.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimBN.Name = "btnTimBN";
            this.btnTimBN.Size = new System.Drawing.Size(103, 34);
            this.btnTimBN.TabIndex = 40;
            this.btnTimBN.Text = "Tìm kiếm";
            this.btnTimBN.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNDBonhiem);
            this.groupBox1.Location = new System.Drawing.Point(647, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 162);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nội dung bổ nhiệm";
            // 
            // txtNDBonhiem
            // 
            this.txtNDBonhiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNDBonhiem.Location = new System.Drawing.Point(6, 23);
            this.txtNDBonhiem.Name = "txtNDBonhiem";
            this.txtNDBonhiem.Size = new System.Drawing.Size(323, 149);
            this.txtNDBonhiem.TabIndex = 0;
            this.txtNDBonhiem.Text = "";
            // 
            // txtLuongmoi
            // 
            this.txtLuongmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuongmoi.Location = new System.Drawing.Point(145, 176);
            this.txtLuongmoi.Margin = new System.Windows.Forms.Padding(2);
            this.txtLuongmoi.Name = "txtLuongmoi";
            this.txtLuongmoi.Size = new System.Drawing.Size(179, 23);
            this.txtLuongmoi.TabIndex = 36;
            // 
            // dtpNgaycohieuluc
            // 
            this.dtpNgaycohieuluc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaycohieuluc.Location = new System.Drawing.Point(452, 92);
            this.dtpNgaycohieuluc.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaycohieuluc.Name = "dtpNgaycohieuluc";
            this.dtpNgaycohieuluc.Size = new System.Drawing.Size(179, 24);
            this.dtpNgaycohieuluc.TabIndex = 35;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(145, 52);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(179, 23);
            this.txtMaNV.TabIndex = 32;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(334, 97);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 18);
            this.label17.TabIndex = 30;
            this.label17.Text = "Ngày có hiệu lực:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(32, 57);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 18);
            this.label14.TabIndex = 28;
            this.label14.Text = "Mã nhân viên :";
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Width = 40;
            // 
            // colMabonhiem
            // 
            this.colMabonhiem.FillWeight = 50F;
            this.colMabonhiem.HeaderText = "Mã bổ nhiệm";
            this.colMabonhiem.Name = "colMabonhiem";
            this.colMabonhiem.Width = 130;
            // 
            // colNgaylap
            // 
            this.colNgaylap.HeaderText = "Ngày lập";
            this.colNgaylap.Name = "colNgaylap";
            // 
            // colNgaycohieuluc
            // 
            this.colNgaycohieuluc.HeaderText = "Ngày có hiệu lực";
            this.colNgaycohieuluc.Name = "colNgaycohieuluc";
            this.colNgaycohieuluc.Width = 160;
            // 
            // colMaNV
            // 
            this.colMaNV.HeaderText = "Mã nhân viên";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Width = 140;
            // 
            // colMaCV
            // 
            this.colMaCV.HeaderText = "Mã chức vụ";
            this.colMaCV.Name = "colMaCV";
            this.colMaCV.Width = 130;
            // 
            // colMaPB
            // 
            this.colMaPB.HeaderText = "Mã phòng ban";
            this.colMaPB.Name = "colMaPB";
            this.colMaPB.Width = 160;
            // 
            // colLuongmoi
            // 
            this.colLuongmoi.HeaderText = "Lương mới";
            this.colLuongmoi.Name = "colLuongmoi";
            this.colLuongmoi.Width = 120;
            // 
            // colNDBonhiem
            // 
            this.colNDBonhiem.HeaderText = "Nội dung bổ nhiệm";
            this.colNDBonhiem.Name = "colNDBonhiem";
            this.colNDBonhiem.Width = 190;
            // 
            // txtCVmoi
            // 
            this.txtCVmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVmoi.Location = new System.Drawing.Point(145, 95);
            this.txtCVmoi.Margin = new System.Windows.Forms.Padding(2);
            this.txtCVmoi.Name = "txtCVmoi";
            this.txtCVmoi.Size = new System.Drawing.Size(179, 23);
            this.txtCVmoi.TabIndex = 44;
            // 
            // txtPBmoi
            // 
            this.txtPBmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPBmoi.Location = new System.Drawing.Point(145, 138);
            this.txtPBmoi.Margin = new System.Windows.Forms.Padding(2);
            this.txtPBmoi.Name = "txtPBmoi";
            this.txtPBmoi.Size = new System.Drawing.Size(179, 23);
            this.txtPBmoi.TabIndex = 45;
            // 
            // frmBoNhiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 526);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBoNhiem";
            this.Text = "frmBoNhiem";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListBN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtMabonhiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnThemBN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtLuongmoi;
        private System.Windows.Forms.DateTimePicker dtpNgaycohieuluc;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtNDBonhiem;
        private System.Windows.Forms.Button btnXoaBN;
        private System.Windows.Forms.Button btnTimBN;
        private System.Windows.Forms.DataGridView dtgvListBN;
        private System.Windows.Forms.Button btnCNhapBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMabonhiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaylap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaycohieuluc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLuongmoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNDBonhiem;
        private System.Windows.Forms.TextBox txtPBmoi;
        private System.Windows.Forms.TextBox txtCVmoi;
    }
}