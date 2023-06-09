﻿namespace QLNS_TinhVanSoftWare.PresentationLayer
{
    partial class frmNghiPhepThoiViec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNghiPhepThoiViec));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvNghilamthoiviec = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpStartday = new System.Windows.Forms.DateTimePicker();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbIDName = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpEndday = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbReason = new System.Windows.Forms.RichTextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.clNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIDType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStartdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEnddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNghilamthoiviec)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.btnCreate);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.dtpEndday);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbIDName);
            this.groupBox2.Controls.Add(this.dgvNghilamthoiviec);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnFind);
            this.groupBox2.Controls.Add(this.cmbStatus);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbDepartment);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dtpStartday);
            this.groupBox2.Controls.Add(this.cmbPosition);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.cmbType);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1462, 669);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NGHỈ PHÉP - THÔI VIỆC";
            // 
            // dgvNghilamthoiviec
            // 
            this.dgvNghilamthoiviec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNghilamthoiviec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clNo,
            this.clDate,
            this.clIDType,
            this.clName,
            this.clType,
            this.clDepartment,
            this.clPosition,
            this.clStartdate,
            this.clEnddate,
            this.clStatus});
            this.dgvNghilamthoiviec.Location = new System.Drawing.Point(23, 416);
            this.dgvNghilamthoiviec.Name = "dgvNghilamthoiviec";
            this.dgvNghilamthoiviec.RowHeadersWidth = 51;
            this.dgvNghilamthoiviec.RowTemplate.Height = 24;
            this.dgvNghilamthoiviec.Size = new System.Drawing.Size(1407, 233);
            this.dgvNghilamthoiviec.TabIndex = 46;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.MintCream;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(800, 308);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 48);
            this.btnUpdate.TabIndex = 45;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Gray;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.MintCream;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(1302, 308);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 48);
            this.btnReset.TabIndex = 44;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.MintCream;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(1137, 308);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 48);
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
            this.btnFind.Location = new System.Drawing.Point(968, 308);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(128, 48);
            this.btnFind.TabIndex = 42;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(688, 181);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(318, 32);
            this.cmbStatus.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(551, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 40;
            this.label2.Text = "Trạng thái:";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(200, 181);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(298, 32);
            this.cmbDepartment.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 24);
            this.label11.TabIndex = 18;
            this.label11.Text = "Phòng ban  :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "Chức vụ  :";
            // 
            // dtpStartday
            // 
            this.dtpStartday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartday.Location = new System.Drawing.Point(688, 67);
            this.dtpStartday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStartday.Name = "dtpStartday";
            this.dtpStartday.Size = new System.Drawing.Size(318, 29);
            this.dtpStartday.TabIndex = 35;
            // 
            // cmbPosition
            // 
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(200, 235);
            this.cmbPosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(298, 32);
            this.cmbPosition.TabIndex = 31;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(200, 68);
            this.cmbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(298, 32);
            this.cmbType.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 24);
            this.label7.TabIndex = 24;
            this.label7.Text = "Loại đơn nghỉ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mã/Tên nhân viên :";
            // 
            // cmbIDName
            // 
            this.cmbIDName.FormattingEnabled = true;
            this.cmbIDName.Location = new System.Drawing.Point(201, 126);
            this.cmbIDName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbIDName.Name = "cmbIDName";
            this.cmbIDName.Size = new System.Drawing.Size(298, 32);
            this.cmbIDName.TabIndex = 47;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(551, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(132, 24);
            this.label17.TabIndex = 30;
            this.label17.Text = "Ngày bắt đầu :";
            // 
            // dtpEndday
            // 
            this.dtpEndday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndday.Location = new System.Drawing.Point(688, 123);
            this.dtpEndday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEndday.Name = "dtpEndday";
            this.dtpEndday.Size = new System.Drawing.Size(318, 29);
            this.dtpEndday.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(551, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 48;
            this.label1.Text = "Ngày kết thúc :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbReason);
            this.groupBox1.Location = new System.Drawing.Point(1034, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(396, 212);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lý do";
            // 
            // rtbReason
            // 
            this.rtbReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbReason.Location = new System.Drawing.Point(8, 39);
            this.rtbReason.Margin = new System.Windows.Forms.Padding(4);
            this.rtbReason.Name = "rtbReason";
            this.rtbReason.Size = new System.Drawing.Size(370, 149);
            this.rtbReason.TabIndex = 0;
            this.rtbReason.Text = "";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Green;
            this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.MintCream;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(639, 308);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(128, 48);
            this.btnCreate.TabIndex = 51;
            this.btnCreate.Text = "Thêm mới";
            this.btnCreate.UseVisualStyleBackColor = false;
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
            this.clDate.Width = 130;
            // 
            // clIDType
            // 
            this.clIDType.HeaderText = "Mã đơn nghỉ";
            this.clIDType.MinimumWidth = 6;
            this.clIDType.Name = "clIDType";
            this.clIDType.Width = 125;
            // 
            // clName
            // 
            this.clName.HeaderText = "Họ và tên";
            this.clName.MinimumWidth = 6;
            this.clName.Name = "clName";
            this.clName.Width = 140;
            // 
            // clType
            // 
            this.clType.HeaderText = "Loại đơn nghỉ";
            this.clType.MinimumWidth = 6;
            this.clType.Name = "clType";
            this.clType.Width = 138;
            // 
            // clDepartment
            // 
            this.clDepartment.HeaderText = "Phòng ban";
            this.clDepartment.MinimumWidth = 6;
            this.clDepartment.Name = "clDepartment";
            this.clDepartment.Width = 115;
            // 
            // clPosition
            // 
            this.clPosition.HeaderText = "Chức vụ";
            this.clPosition.MinimumWidth = 6;
            this.clPosition.Name = "clPosition";
            this.clPosition.Width = 115;
            // 
            // clStartdate
            // 
            this.clStartdate.HeaderText = "Ngày bắt đầu";
            this.clStartdate.MinimumWidth = 6;
            this.clStartdate.Name = "clStartdate";
            this.clStartdate.Width = 140;
            // 
            // clEnddate
            // 
            this.clEnddate.HeaderText = "Ngày kết thúc";
            this.clEnddate.MinimumWidth = 6;
            this.clEnddate.Name = "clEnddate";
            this.clEnddate.Width = 140;
            // 
            // clStatus
            // 
            this.clStatus.HeaderText = "Trạng thái";
            this.clStatus.MinimumWidth = 6;
            this.clStatus.Name = "clStatus";
            this.clStatus.Width = 115;
            // 
            // frmNghiPhepThoiViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1492, 710);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmNghiPhepThoiViec";
            this.Text = "frmNghiPhepThoiViec";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNghilamthoiviec)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbReason;
        private System.Windows.Forms.DateTimePicker dtpEndday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbIDName;
        private System.Windows.Forms.DataGridView dgvNghilamthoiviec;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpStartday;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIDType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStartdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEnddate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStatus;
    }
}