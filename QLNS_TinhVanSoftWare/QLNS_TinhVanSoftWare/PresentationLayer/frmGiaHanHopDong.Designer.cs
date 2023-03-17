namespace QLNS_TinhVanSoftWare.PresentationLayer
{
    partial class frmGiaHanHopDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaHanHopDong));
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPositionID = new System.Windows.Forms.ComboBox();
            this.cmbDepartID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbIdentitfyID = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSetNewPos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnUnchange = new System.Windows.Forms.Button();
            this.cmbSetNewDepart = new System.Windows.Forms.ComboBox();
            this.txtNewSalary = new System.Windows.Forms.TextBox();
            this.btnExtend = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEmployID = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmployName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã chức vụ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = " Mã phòng ban :";
            // 
            // cmbPositionID
            // 
            this.cmbPositionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPositionID.FormattingEnabled = true;
            this.cmbPositionID.Location = new System.Drawing.Point(127, 210);
            this.cmbPositionID.Name = "cmbPositionID";
            this.cmbPositionID.Size = new System.Drawing.Size(121, 24);
            this.cmbPositionID.TabIndex = 4;
            // 
            // cmbDepartID
            // 
            this.cmbDepartID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartID.FormattingEnabled = true;
            this.cmbDepartID.Location = new System.Drawing.Point(127, 164);
            this.cmbDepartID.Name = "cmbDepartID";
            this.cmbDepartID.Size = new System.Drawing.Size(121, 24);
            this.cmbDepartID.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "CCCD :";
            // 
            // cmbIdentitfyID
            // 
            this.cmbIdentitfyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIdentitfyID.FormattingEnabled = true;
            this.cmbIdentitfyID.Location = new System.Drawing.Point(127, 124);
            this.cmbIdentitfyID.Name = "cmbIdentitfyID";
            this.cmbIdentitfyID.Size = new System.Drawing.Size(121, 24);
            this.cmbIdentitfyID.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.txtEmployName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbEmployID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbIdentitfyID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbDepartID);
            this.groupBox1.Controls.Add(this.cmbPositionID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 286);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.txtNewSalary);
            this.groupBox2.Controls.Add(this.cmbSetNewDepart);
            this.groupBox2.Controls.Add(this.btnUnchange);
            this.groupBox2.Controls.Add(this.btnChange);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbSetNewPos);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(531, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 283);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nội dung thay đổi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Chức vụ mới :";
            // 
            // cmbSetNewPos
            // 
            this.cmbSetNewPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSetNewPos.FormattingEnabled = true;
            this.cmbSetNewPos.Location = new System.Drawing.Point(152, 42);
            this.cmbSetNewPos.Name = "cmbSetNewPos";
            this.cmbSetNewPos.Size = new System.Drawing.Size(162, 24);
            this.cmbSetNewPos.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Phòng ban mới :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Lương :";
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnChange.Location = new System.Drawing.Point(34, 207);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(150, 47);
            this.btnChange.TabIndex = 11;
            this.btnChange.Text = "Có thay đổi";
            this.btnChange.UseVisualStyleBackColor = false;
            // 
            // btnUnchange
            // 
            this.btnUnchange.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUnchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnchange.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnUnchange.Location = new System.Drawing.Point(254, 207);
            this.btnUnchange.Name = "btnUnchange";
            this.btnUnchange.Size = new System.Drawing.Size(150, 47);
            this.btnUnchange.TabIndex = 12;
            this.btnUnchange.Text = "Không thay đổi";
            this.btnUnchange.UseVisualStyleBackColor = false;
            // 
            // cmbSetNewDepart
            // 
            this.cmbSetNewDepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSetNewDepart.FormattingEnabled = true;
            this.cmbSetNewDepart.Location = new System.Drawing.Point(152, 97);
            this.cmbSetNewDepart.Name = "cmbSetNewDepart";
            this.cmbSetNewDepart.Size = new System.Drawing.Size(162, 24);
            this.cmbSetNewDepart.TabIndex = 13;
            // 
            // txtNewSalary
            // 
            this.txtNewSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewSalary.Location = new System.Drawing.Point(152, 149);
            this.txtNewSalary.Name = "txtNewSalary";
            this.txtNewSalary.Size = new System.Drawing.Size(162, 22);
            this.txtNewSalary.TabIndex = 8;
            // 
            // btnExtend
            // 
            this.btnExtend.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnExtend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtend.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnExtend.Location = new System.Drawing.Point(415, 433);
            this.btnExtend.Name = "btnExtend";
            this.btnExtend.Size = new System.Drawing.Size(250, 47);
            this.btnExtend.TabIndex = 14;
            this.btnExtend.Text = "Gia hạn";
            this.btnExtend.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(394, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "GIA HẠN HỢP ĐỒNG";
            // 
            // cmbEmployID
            // 
            this.cmbEmployID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmployID.FormattingEnabled = true;
            this.cmbEmployID.Location = new System.Drawing.Point(127, 37);
            this.cmbEmployID.Name = "cmbEmployID";
            this.cmbEmployID.Size = new System.Drawing.Size(121, 24);
            this.cmbEmployID.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tên nhân viên :";
            // 
            // txtEmployName
            // 
            this.txtEmployName.Location = new System.Drawing.Point(127, 82);
            this.txtEmployName.Name = "txtEmployName";
            this.txtEmployName.Size = new System.Drawing.Size(121, 22);
            this.txtEmployName.TabIndex = 10;
            // 
            // frmGiaHanHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1046, 492);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnExtend);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGiaHanHopDong";
            this.Text = "frmGiaHanHopDong";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPositionID;
        private System.Windows.Forms.ComboBox cmbDepartID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbIdentitfyID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUnchange;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSetNewPos;
        private System.Windows.Forms.TextBox txtNewSalary;
        private System.Windows.Forms.ComboBox cmbSetNewDepart;
        private System.Windows.Forms.Button btnExtend;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEmployID;
        private System.Windows.Forms.TextBox txtEmployName;
        private System.Windows.Forms.Label label9;
    }
}