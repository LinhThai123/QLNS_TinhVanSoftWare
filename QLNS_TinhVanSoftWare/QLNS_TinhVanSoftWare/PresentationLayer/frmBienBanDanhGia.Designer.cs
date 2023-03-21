﻿namespace QLNS_TinhVanSoftWare.PresentationLayer
{
    partial class frmBienBanDanhGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBienBanDanhGia));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbNoiDungDG = new System.Windows.Forms.RichTextBox();
            this.cmbMaNV = new System.Windows.Forms.ComboBox();
            this.dgvBienBanDanhGia = new System.Windows.Forms.DataGridView();
            this.clNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSuaDanhGia = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.cmbTrangThai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMaPB = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMaCV = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProviderBienBanDanhGia = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtMabienban = new System.Windows.Forms.TextBox();
            this.dNgaylap = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBienBanDanhGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBienBanDanhGia)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dNgaylap);
            this.groupBox2.Controls.Add(this.txtMabienban);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnCreate);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.cmbMaNV);
            this.groupBox2.Controls.Add(this.dgvBienBanDanhGia);
            this.groupBox2.Controls.Add(this.btnSuaDanhGia);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnFind);
            this.groupBox2.Controls.Add(this.cmbTrangThai);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbMaPB);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbMaCV);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(962, 561);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BIÊN BẢN ĐÁNH GIÁ";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Green;
            this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.MintCream;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(243, 269);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(90, 39);
            this.btnCreate.TabIndex = 51;
            this.btnCreate.Text = "Thêm mới";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbNoiDungDG);
            this.groupBox1.Location = new System.Drawing.Point(630, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 203);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nội dung đánh giá";
            // 
            // rtbNoiDungDG
            // 
            this.rtbNoiDungDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNoiDungDG.Location = new System.Drawing.Point(6, 23);
            this.rtbNoiDungDG.Name = "rtbNoiDungDG";
            this.rtbNoiDungDG.Size = new System.Drawing.Size(266, 161);
            this.rtbNoiDungDG.TabIndex = 0;
            this.rtbNoiDungDG.Text = "";
            // 
            // cmbMaNV
            // 
            this.cmbMaNV.FormattingEnabled = true;
            this.cmbMaNV.Location = new System.Drawing.Point(136, 160);
            this.cmbMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMaNV.Name = "cmbMaNV";
            this.cmbMaNV.Size = new System.Drawing.Size(161, 26);
            this.cmbMaNV.TabIndex = 47;
            // 
            // dgvBienBanDanhGia
            // 
            this.dgvBienBanDanhGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBienBanDanhGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clNo,
            this.clDate,
            this.clID,
            this.clName,
            this.clDepartment,
            this.clPosition,
            this.clStatus});
            this.dgvBienBanDanhGia.Location = new System.Drawing.Point(17, 334);
            this.dgvBienBanDanhGia.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBienBanDanhGia.Name = "dgvBienBanDanhGia";
            this.dgvBienBanDanhGia.RowHeadersWidth = 51;
            this.dgvBienBanDanhGia.RowTemplate.Height = 24;
            this.dgvBienBanDanhGia.Size = new System.Drawing.Size(917, 178);
            this.dgvBienBanDanhGia.TabIndex = 46;
            // 
            // clNo
            // 
            this.clNo.HeaderText = "STT";
            this.clNo.MinimumWidth = 6;
            this.clNo.Name = "clNo";
            this.clNo.Width = 60;
            // 
            // clDate
            // 
            this.clDate.HeaderText = "Ngày lập";
            this.clDate.MinimumWidth = 6;
            this.clDate.Name = "clDate";
            this.clDate.Width = 135;
            // 
            // clID
            // 
            this.clID.HeaderText = "Mã biên bản";
            this.clID.MinimumWidth = 6;
            this.clID.Name = "clID";
            this.clID.Width = 135;
            // 
            // clName
            // 
            this.clName.HeaderText = "Họ và tên";
            this.clName.MinimumWidth = 6;
            this.clName.Name = "clName";
            this.clName.Width = 150;
            // 
            // clDepartment
            // 
            this.clDepartment.HeaderText = "Phòng ban";
            this.clDepartment.MinimumWidth = 6;
            this.clDepartment.Name = "clDepartment";
            this.clDepartment.Width = 130;
            // 
            // clPosition
            // 
            this.clPosition.HeaderText = "Chức vụ";
            this.clPosition.MinimumWidth = 6;
            this.clPosition.Name = "clPosition";
            this.clPosition.Width = 130;
            // 
            // clStatus
            // 
            this.clStatus.HeaderText = "Trạng thái";
            this.clStatus.MinimumWidth = 6;
            this.clStatus.Name = "clStatus";
            this.clStatus.Width = 125;
            // 
            // btnSuaDanhGia
            // 
            this.btnSuaDanhGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSuaDanhGia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSuaDanhGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDanhGia.ForeColor = System.Drawing.Color.MintCream;
            this.btnSuaDanhGia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaDanhGia.Location = new System.Drawing.Point(373, 269);
            this.btnSuaDanhGia.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaDanhGia.Name = "btnSuaDanhGia";
            this.btnSuaDanhGia.Size = new System.Drawing.Size(84, 39);
            this.btnSuaDanhGia.TabIndex = 45;
            this.btnSuaDanhGia.Text = "Cập nhật";
            this.btnSuaDanhGia.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.MintCream;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(616, 269);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 39);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.MintCream;
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(497, 269);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(83, 39);
            this.btnFind.TabIndex = 42;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.FormattingEnabled = true;
            this.cmbTrangThai.Location = new System.Drawing.Point(428, 165);
            this.cmbTrangThai.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(152, 26);
            this.cmbTrangThai.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Trạng thái:";
            // 
            // cmbMaPB
            // 
            this.cmbMaPB.FormattingEnabled = true;
            this.cmbMaPB.Location = new System.Drawing.Point(428, 111);
            this.cmbMaPB.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMaPB.Name = "cmbMaPB";
            this.cmbMaPB.Size = new System.Drawing.Size(152, 26);
            this.cmbMaPB.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(332, 112);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = "Phòng ban  :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(332, 59);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Chức vụ  :";
            // 
            // cmbMaCV
            // 
            this.cmbMaCV.FormattingEnabled = true;
            this.cmbMaCV.Location = new System.Drawing.Point(428, 56);
            this.cmbMaCV.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMaCV.Name = "cmbMaCV";
            this.cmbMaCV.Size = new System.Drawing.Size(152, 26);
            this.cmbMaCV.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 168);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mã nhân viên :";
            // 
            // errorProviderBienBanDanhGia
            // 
            this.errorProviderBienBanDanhGia.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(18, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 52;
            this.label1.Text = "Mã biên bản:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMabienban
            // 
            this.txtMabienban.Location = new System.Drawing.Point(136, 58);
            this.txtMabienban.Name = "txtMabienban";
            this.txtMabienban.Size = new System.Drawing.Size(161, 24);
            this.txtMabienban.TabIndex = 53;
            // 
            // dNgaylap
            // 
            this.dNgaylap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dNgaylap.Location = new System.Drawing.Point(136, 109);
            this.dNgaylap.Name = "dNgaylap";
            this.dNgaylap.Size = new System.Drawing.Size(161, 24);
            this.dNgaylap.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(18, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 55;
            this.label3.Text = "Ngày lập:";
            // 
            // frmBienBanDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 609);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBienBanDanhGia";
            this.Text = "frmBienBanDanhGia";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBienBanDanhGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBienBanDanhGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbNoiDungDG;
        private System.Windows.Forms.ComboBox cmbMaNV;
        private System.Windows.Forms.DataGridView dgvBienBanDanhGia;
        private System.Windows.Forms.Button btnSuaDanhGia;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cmbTrangThai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMaPB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbMaCV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStatus;
        private System.Windows.Forms.ErrorProvider errorProviderBienBanDanhGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMabienban;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dNgaylap;
    }
}