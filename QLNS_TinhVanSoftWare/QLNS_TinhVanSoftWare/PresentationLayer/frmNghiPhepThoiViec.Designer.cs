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
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbReason = new System.Windows.Forms.RichTextBox();
            this.dtpEndday = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbIDName = new System.Windows.Forms.ComboBox();
            this.dgvNghilamthoiviec = new System.Windows.Forms.DataGridView();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpStartday = new System.Windows.Forms.DateTimePicker();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNghilamthoiviec)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.dtpNgayLap);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.dtpEndday);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbIDName);
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
            this.groupBox2.Size = new System.Drawing.Size(1462, 385);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NGHỈ PHÉP - THÔI VIỆC";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(688, 235);
            this.dtpNgayLap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(318, 29);
            this.dtpNgayLap.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(551, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 53;
            this.label3.Text = "Ngày lập:";
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
            // dtpEndday
            // 
            this.dtpEndday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
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
            // cmbIDName
            // 
            this.cmbIDName.FormattingEnabled = true;
            this.cmbIDName.Location = new System.Drawing.Point(201, 126);
            this.cmbIDName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbIDName.Name = "cmbIDName";
            this.cmbIDName.Size = new System.Drawing.Size(298, 32);
            this.cmbIDName.TabIndex = 47;
            // 
            // dgvNghilamthoiviec
            // 
            this.dgvNghilamthoiviec.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvNghilamthoiviec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNghilamthoiviec.Location = new System.Drawing.Point(18, 419);
            this.dgvNghilamthoiviec.Name = "dgvNghilamthoiviec";
            this.dgvNghilamthoiviec.RowHeadersWidth = 51;
            this.dgvNghilamthoiviec.RowTemplate.Height = 24;
            this.dgvNghilamthoiviec.Size = new System.Drawing.Size(1462, 279);
            this.dgvNghilamthoiviec.TabIndex = 46;
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
            this.dtpStartday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
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
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.MintCream;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(1091, 308);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 48);
            this.btnDelete.TabIndex = 58;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MintCream;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(870, 308);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 48);
            this.button1.TabIndex = 57;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.MintCream;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(195, 308);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(131, 48);
            this.btnThem.TabIndex = 55;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseMnemonic = false;
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.MintCream;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(417, 308);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 48);
            this.btnUpdate.TabIndex = 59;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.MintCream;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(645, 308);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 48);
            this.button2.TabIndex = 56;
            this.button2.Text = "Làm mới";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // frmNghiPhepThoiViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1492, 710);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvNghilamthoiviec);
            this.Name = "frmNghiPhepThoiViec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nghỉ phép - thôi việc";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNghilamthoiviec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbReason;
        private System.Windows.Forms.DateTimePicker dtpEndday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbIDName;
        private System.Windows.Forms.DataGridView dgvNghilamthoiviec;
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
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button2;
    }
}