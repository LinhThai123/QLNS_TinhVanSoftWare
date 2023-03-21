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
        string maBienBan = "";
        public frmBienBanDanhGia()
        {
            InitializeComponent();
        }


        //themBienban
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


            //if (cmbMaCV.Text == "")
            //{
            //    errorProviderBienBanDanhGia.SetError(cmbMaCV, "Mã chức vụ không được bỏ trống");
            //    check = false;
            //}
            //else
            //    errorProviderBienBanDanhGia.SetError(cmbMaCV, "");

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

        private void btnSuaDanhGia_Click(object sender, EventArgs e)
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



            /*if (cmbMaNV.Text == "")
            {
                errorProviderKhenThuongKyLuat.SetError(cmbMaNV, "Mã nhân viên không được bỏ trống");
                check = false;
            }
            else if (nhanVienBLL.checkExistsByName(cmbMaNV.Text))
            {
                errorProviderKhenThuongKyLuat.SetError(cmbMaNV, "Mã nhân viên không tồn tại");
                check = false;
            }
            else
                errorProviderKhenThuongKyLuat.SetError(cmbMaNV, "");
            */


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
                if (bienBanDanhGiaBLL.suaBienBan(txtMabienban.Text,
                    dNgaylap.Value,
                    cmbMaNV.SelectedValue.ToString(),
                    cmbMaCV.SelectedValue.ToString(),
                    cmbMaPB.SelectedValue.ToString(),
                    rtbNoiDungDG.Text))
                {
                    MessageBox.Show("Sửa khen thưởng - kỷ luật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataToDataGridView(dgvBienBanDanhGia, bienBanDanhGiaBLL.findAll());
                }
                else
                    MessageBox.Show("Sửa sản phẩm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (bienBanDanhGiaBLL.xoaBienBan(maBienBan))
                {
                    MessageBox.Show("Xóa biên bản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataToDataGridView(dgvBienBanDanhGia, bienBanDanhGiaBLL.findAll());
                }
                else
                    MessageBox.Show("Xóa biên bản thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            bool check = true;

            if (txtMabienban.Text == "" && dNgaylap.Text == "" && cmbMaNV.Text == "" && cmbMaCV.Text == "" && cmbMaPB.Text == "" && rtbNoiDungDG.Text == "")
            {
                MessageBox.Show("Bạn cần nhập thông tin muốn tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                check = false;
            }


            if (check)
            {
                DataTable dt = bienBanDanhGiaBLL.timBienBan(txtMabienban.Text);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                loadDataToDataGridView(dgvBienBanDanhGia, dt);
            }
        }
    }
}