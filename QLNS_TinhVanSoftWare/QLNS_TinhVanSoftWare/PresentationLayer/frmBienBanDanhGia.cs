using QLNS_TinhVanSoftWare.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_TinhVanSoftWare.PresentationLayer
{
    public partial class frmBienBanDanhGia : Form
    {

        BienBanDanhGiaBLL bienBanDanhGiaBLL = new BienBanDanhGiaBLL();
        string maQD = "";
        public frmBienBanDanhGia()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool check = true;

            if (txtMabienban.Text == "")
            {
                errorProviderBienBanDanhGia.SetError(txtMabienban, "Mã biên bản không được bỏ trống");
                check = false;
            }
            else
                errorProviderBienBanDanhGia.SetError(txtMabienban, "");

            if (dNgaylap.Text == "")
            {
                errorProviderBienBanDanhGia.SetError(dNgaylap, "Ngày lập không được bỏ trống");
                check = false;
            }


            //if (cmbMaNV.Text == "")
            //{
            //    errorProviderBienBanDanhGia.SetError(cmbMaNV, "Mã NV không được bỏ trống");
            //    check = false;
            //}



            if (cmbMaCV.Text == "")
            {
                errorProviderBienBanDanhGia.SetError(cmbMaCV, "Mã chức vụ không được bỏ trống");
                check = false;
            }
            else
                errorProviderBienBanDanhGia.SetError(cmbMaCV, "");

            //if (cmbMaPB.Text == "")
            //{
            //    errorProviderBienBanDanhGia.SetError(cmbMaPB, "Mã phòng ban không được bỏ trống");
            //    check = false;
            //}
            //else
            //    errorProviderBienBanDanhGia.SetError(cmbMaPB, "");


            if (cmbTrangThai.Text == "")
            {
                errorProviderBienBanDanhGia.SetError(cmbTrangThai, "Trạng thái không được bỏ trống");
                check = false;
            }
            else
                errorProviderBienBanDanhGia.SetError(cmbTrangThai, "");

            if (rtbNoiDungDG.Text == "")
            {
                errorProviderBienBanDanhGia.SetError(rtbNoiDungDG, "Nội dunh không được bỏ trống");
                check = false;
            }
            else
                errorProviderBienBanDanhGia.SetError(rtbNoiDungDG, "");

            if (check)
            {
                if (bienBanDanhGiaBLL.themBienBan(txtMabienban.Text,
                    dNgaylap.Value,
                    cmbMaNV.SelectedValue.ToString(),
                    cmbMaCV.SelectedValue.ToString(),
                    cmbMaPB.SelectedValue.ToString(),
                    rtbNoiDungDG.Text))
                {
                    MessageBox.Show("Thêm biên bản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    errorProviderBienBanDanhGia.Clear();
                    loadDataToDataGridView(dgvBienBanDanhGia, bienBanDanhGiaBLL.findAll());
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loadDataToDataGridView(DataGridView dgv, DataTable dt)
        {
            dgv.DataSource = dt;
            dgv.AutoResizeColumns();
        }



    }
}
