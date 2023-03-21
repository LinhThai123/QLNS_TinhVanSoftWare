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
    public partial class frmKhenThuongKyLuat : Form
    {
        KhenThuongKyLuatBLL khenThuongKyLuatBLL = new KhenThuongKyLuatBLL();
        string maQD = "";

        //nhanVienBLL nhanVienBLL = new nhanVienBLL();
        public frmKhenThuongKyLuat()
        {
            InitializeComponent();
        }
        private void btnThemKTKL_Click(object sender, EventArgs e)
        {
            bool check = true;

            if (txtMaQD.Text == "")
            {
                errorProviderKhenThuongKyLuat.SetError(txtMaQD, "Tên khen thưởng - kỷ luật không được bỏ trống");
                check = false;
            }
            else
                errorProviderKhenThuongKyLuat.SetError(txtMaQD, "");

            if (dNgaylap.Text == "")
            {
                errorProviderKhenThuongKyLuat.SetError(dNgaylap, "Ngày lập không được bỏ trống");
                check = false;
            }


            if (cmbLoaiQD.Text == "")
            {
                errorProviderKhenThuongKyLuat.SetError(cmbLoaiQD, "Loại quyết định không được bỏ trống");
                check = false;
            }



            if (cmbMucKhenKy.Text == "")
            {
                errorProviderKhenThuongKyLuat.SetError(cmbMucKhenKy, "Mức khen thưởng - kỷ luật không được bỏ trống");
                check = false;
            }
            else
                errorProviderKhenThuongKyLuat.SetError(cmbMucKhenKy, "");


            if (txtLydo.Text == "")
            {
                errorProviderKhenThuongKyLuat.SetError(txtLydo, "Lý do không được bỏ trống");
                check = false;
            }
            else
                errorProviderKhenThuongKyLuat.SetError(txtLydo, "");



            /*if (cmbTenCV.Text == "")
            {
                errorProviderKhenThuongKyLuat.SetError(cmbTenCV, "Tên chức vụ không được bỏ trống");
                check = false;
            }
            else if (chucVuBLL.checkExistsByName(txtTenNV.Text))
            {
                errorProviderKhenThuongKyLuat.SetError(cmbTenCV, "Tên chức vụ không tồn tại");
                check = false;
            }
            else
                errorProviderKhenThuongKyLuat.SetError(cmbTenCV, "");
            */

            // bỏ cmt dùng Ctrl+K+U

            if (check)
            {
                if (khenThuongKyLuatBLL.themKhenThuong(txtMaQD.Text,
                    dNgaylap.Value,
                    cmbLoaiQD.SelectedValue.ToString(),
                    cmbMaNV.SelectedValue.ToString(),
                    cmbMucKhenKy.SelectedValue.ToString(),
                    txtLydo.Text))
                {
                    MessageBox.Show("Thêm khen thưởng - kỷ luật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    errorProviderKhenThuongKyLuat.Clear();
                    loadDataToDataGridView(dgvKhenThuongKyLuat, khenThuongKyLuatBLL.findAll());
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        //Hàm cập nhật (sửa) 
        private void btnCNhapKTKL_Click(object sender, EventArgs e)
        {
            bool check = true;

            if (txtMaQD.Text == "")
            {
                errorProviderKhenThuongKyLuat.SetError(txtMaQD, "Tên sản phẩm không được bỏ trống");
                check = false;
            }
            else
                errorProviderKhenThuongKyLuat.SetError(txtMaQD, "");


            if (dNgaylap.Text == "")
            {
                errorProviderKhenThuongKyLuat.SetError(dNgaylap, "Ngày lập không được bỏ trống");
                check = false;
            }


            if (cmbLoaiQD.Text == "")
            {
                errorProviderKhenThuongKyLuat.SetError(cmbLoaiQD, "Loại quyết định không được bỏ trống");
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


            if (cmbMucKhenKy.Text == "")
            {
                errorProviderKhenThuongKyLuat.SetError(cmbMucKhenKy, "Mức khen thưởng - kỷ luật không được bỏ trống");
                check = false;
            }
            else
                errorProviderKhenThuongKyLuat.SetError(cmbMucKhenKy, "");


            if (txtLydo.Text == "")
            {
                errorProviderKhenThuongKyLuat.SetError(txtLydo, "Lý do không được bỏ trống");
                check = false;
            }
            else
                errorProviderKhenThuongKyLuat.SetError(txtLydo, "");



            if (check)
            {
                if (khenThuongKyLuatBLL.suaKhenThuong(txtMaQD.Text,
                     dNgaylap.Value,
                     cmbLoaiQD.SelectedValue.ToString(),
                     cmbMaNV.SelectedValue.ToString(),
                     cmbMucKhenKy.SelectedValue.ToString(),
                     txtLydo.Text))
                {
                    MessageBox.Show("Sửa khen thưởng - kỷ luật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataToDataGridView(dgvKhenThuongKyLuat, khenThuongKyLuatBLL.findAll());
                }
                else
                    MessageBox.Show("Sửa sản phẩm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void xoaKhenThuong(object sender, EventArgs e)
        {

        }
        private void timKhenThuong(object sender, EventArgs e)
        {
            bool check = true;

            if (txtMaQD.Text == "" && dNgaylap.Text == "" && cmbLoaiQD.Text == "" && cmbMaNV.Text == "" && cmbMucKhenKy.Text == "" && txtLydo.Text == "")
            {
                MessageBox.Show("Bạn cần nhập thông tin muốn tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                check = false;
            }


            if (check)
            {
                DataTable dt = khenThuongKyLuatBLL.timKhenThuong(txtMaQD.Text);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                loadDataToDataGridView(dgvKhenThuongKyLuat, dt);
            }

        }

        private void loadDataToDataGridView(DataGridView dgv, DataTable dt)
        {
            dgv.DataSource = dt;
            dgv.AutoResizeColumns();
        }
    }
}
