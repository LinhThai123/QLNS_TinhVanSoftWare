using QLNS_TinhVanSoftWare.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_TinhVanSoftWare.PresentationLayer
{
    public partial class frmTaiKhoan : Form
    {

        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();

        QuyenBLL quyenBLL = new QuyenBLL();

        NhanVienBLL nhanVienBLL = new NhanVienBLL();

        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void findAll()
        {
            DataTable t = taiKhoanBLL.findAll();
            t.Columns.Add("STT");
            for (int i = 0; i < t.Rows.Count; i++)
                t.Rows[i]["STT"] = i + 1;
            dgvTaiKhoan.DataSource = t;
            dgvTaiKhoan.Columns["STT"].DisplayIndex = 0;
        }

        public void hienTenQuyen()
        {
            DataTable t = quyenBLL.layDSQuyen();
            DataView view = new DataView(t);
            view.Sort = "PK_sMaquyen";
            cmbMaQuyen.DataSource = view;
            cmbMaQuyen.DisplayMember = "sTenquyen";
            cmbMaQuyen.ValueMember = "PK_sMaquyen";

        }

        private void getNhanVien()
        {
            DataTable t = nhanVienBLL.getNhanVien();
            DataView view = new DataView(t);
            view.Sort = "PK_sMaNV";
            cmbMaNV.DataSource = view;
            cmbMaNV.DisplayMember = "nhanVien";
            cmbMaNV.ValueMember = "PK_sMaNV";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaNV = cmbMaNV.Text;
            if (MaNV != "")
                MaNV = cmbMaNV.SelectedValue.ToString();
            string TenTK = txtTenTK.Text;
            string MK = txtMK.Text;
            string tinhTrang = cmbTinhTrang.Text;
            string maQuyen = cmbMaQuyen.SelectedValue.ToString();

            DateTimeOffset now = DateTimeOffset.UtcNow;
            string s_Taikhoan = "TK" + now.ToUnixTimeMilliseconds().ToString();

            switch (taiKhoanBLL.insert(s_Taikhoan, TenTK, MK, tinhTrang, MaNV, maQuyen))
            {
                case 1:
                    MessageBox.Show("Thêm tài khoản thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoi_Click(sender, e);
                    break;
                case -1:
                    MessageBox.Show("Không được để trống !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case -2:
                    MessageBox.Show("Tên tài khoản không được trùng !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case -3:
                    MessageBox.Show("Mật khẩu phải có từ 6 ký tự trở lên !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            findAll();
            hienTenQuyen();
            getNhanVien();
            cmbTinhTrang.SelectedIndex = 0;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tenTK = txtTenTK.Text;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (taiKhoanBLL.delete(tenTK))
                {
                    btnLamMoi_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMK.Text = "";
            txtTenTK.Text = "";
            frmTaiKhoan_Load(sender, e);
        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbMaNV.SelectedValue = dgvTaiKhoan.CurrentRow.Cells[1].Value.ToString();
            txtMK.Text = dgvTaiKhoan.CurrentRow.Cells[4].Value.ToString();
            cmbTinhTrang.Text = dgvTaiKhoan.CurrentRow.Cells[6].Value.ToString();
            cmbMaQuyen.Text = dgvTaiKhoan.CurrentRow.Cells[5].Value.ToString();
            txtTenTK.Text = dgvTaiKhoan.CurrentRow.Cells[3].Value.ToString();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string tenTk = txtTenTK.Text;
            string tinhTrang = cmbTinhTrang.Text;
            string MK = txtMK.Text;
            string maQuyen = cmbMaQuyen.SelectedValue.ToString();

            switch (taiKhoanBLL.update(tenTk, MK, tinhTrang, maQuyen))
            {
                case 1:
                    MessageBox.Show("Cập nhật Thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoi_Click(sender, e);
                    break;
                case -1:
                    MessageBox.Show("Không được để trống !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case -2:
                    MessageBox.Show("Không thể sửa Tên tài khoản !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case -3:
                    MessageBox.Show("Mật khẩu phải có từ 6 ký tự trở lên !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void loadData(DataTable dsTimkiem)
        {
            dgvTaiKhoan.DataSource = dsTimkiem;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            loadData(taiKhoanBLL.searchByName(txtTenTK.Text));
        }

        private void txtTenTK_Validating(object sender, CancelEventArgs e)
        {

            if (txtTenTK.Text == "")
            {
                errorProvider1.SetError(txtTenTK, "Không được để trống");
            }
            else
                errorProvider1.SetError(txtTenTK, "");
        }

        private void txtMK_Validating(object sender, CancelEventArgs e)
        {

            if (txtMK.Text == "")
            {
                errorProvider1.SetError(txtMK, "Không được để trống");
            }
            else
                errorProvider1.SetError(txtMK, "");
        }
    }
}
