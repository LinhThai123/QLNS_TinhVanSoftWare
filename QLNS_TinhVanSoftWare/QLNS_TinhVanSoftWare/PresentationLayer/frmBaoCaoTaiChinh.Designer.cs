
namespace QLNS_TinhVanSoftWare.PresentationLayer
{
    partial class frmBaoCaoTaiChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoTaiChinh));
            this.grbBCTC = new System.Windows.Forms.GroupBox();
            this.rpBaoCaoTaiChinh = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnReport = new System.Windows.Forms.Button();
            this.cmbNam = new System.Windows.Forms.ComboBox();
            this.cmbThang = new System.Windows.Forms.ComboBox();
            this.lblNam = new System.Windows.Forms.Label();
            this.lblThang = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.grbBCTC.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBCTC
            // 
            this.grbBCTC.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grbBCTC.Controls.Add(this.rpBaoCaoTaiChinh);
            this.grbBCTC.Controls.Add(this.btnReport);
            this.grbBCTC.Controls.Add(this.cmbNam);
            this.grbBCTC.Controls.Add(this.cmbThang);
            this.grbBCTC.Controls.Add(this.lblNam);
            this.grbBCTC.Controls.Add(this.lblThang);
            this.grbBCTC.Controls.Add(this.label13);
            this.grbBCTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBCTC.Location = new System.Drawing.Point(12, 25);
            this.grbBCTC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbBCTC.Name = "grbBCTC";
            this.grbBCTC.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbBCTC.Size = new System.Drawing.Size(1262, 503);
            this.grbBCTC.TabIndex = 28;
            this.grbBCTC.TabStop = false;
            this.grbBCTC.Text = "BÁO CÁO TÀI CHÍNH";
            // 
            // rpBaoCaoTaiChinh
            // 
            this.rpBaoCaoTaiChinh.ActiveViewIndex = -1;
            this.rpBaoCaoTaiChinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpBaoCaoTaiChinh.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpBaoCaoTaiChinh.Location = new System.Drawing.Point(16, 137);
            this.rpBaoCaoTaiChinh.Name = "rpBaoCaoTaiChinh";
            this.rpBaoCaoTaiChinh.Size = new System.Drawing.Size(1211, 293);
            this.rpBaoCaoTaiChinh.TabIndex = 63;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.MintCream;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(970, 59);
            this.btnReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(123, 35);
            this.btnReport.TabIndex = 62;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = false;
            // 
            // cmbNam
            // 
            this.cmbNam.FormattingEnabled = true;
            this.cmbNam.Location = new System.Drawing.Point(568, 57);
            this.cmbNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNam.Name = "cmbNam";
            this.cmbNam.Size = new System.Drawing.Size(237, 32);
            this.cmbNam.TabIndex = 49;
            // 
            // cmbThang
            // 
            this.cmbThang.FormattingEnabled = true;
            this.cmbThang.Location = new System.Drawing.Point(133, 57);
            this.cmbThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(237, 32);
            this.cmbThang.TabIndex = 48;
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNam.Location = new System.Drawing.Point(455, 65);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(60, 24);
            this.lblNam.TabIndex = 18;
            this.lblNam.Text = "Năm :";
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThang.Location = new System.Drawing.Point(26, 65);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(75, 24);
            this.lblThang.TabIndex = 12;
            this.lblThang.Text = "Tháng :";
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
            // frmBaoCaoTaiChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1287, 539);
            this.Controls.Add(this.grbBCTC);
            this.Name = "frmBaoCaoTaiChinh";
            this.Text = "frmBaoCaoTaiChinh";
            this.Load += new System.EventHandler(this.frmBaoCaoTaiChinh_Load);
            this.grbBCTC.ResumeLayout(false);
            this.grbBCTC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBCTC;
        private System.Windows.Forms.ComboBox cmbNam;
        private System.Windows.Forms.ComboBox cmbThang;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnReport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpBaoCaoTaiChinh;
    }
}