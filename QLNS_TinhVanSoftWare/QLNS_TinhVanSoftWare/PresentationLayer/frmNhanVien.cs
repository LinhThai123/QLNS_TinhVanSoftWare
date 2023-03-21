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
    public partial class frmNhanVien : Form
    {
        NhanVienBLL nhanVienBLL = new NhanVienBLL();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void findAll()
        {
            DataTable t = nhanVienBLL.findAll();
            t.Columns.Add("STT");
            for (int i = 0; i < t.Rows.Count; i++)
                t.Rows[i]["STT"] = i + 1;
            dgvNhanVien.DataSource = t;
            dgvNhanVien.Columns["STT"].DisplayIndex = 0;
        }

        private void loadData(DataTable dsTimkiem)
        {
            dgvNhanVien.DataSource = dsTimkiem;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            loadData(nhanVienBLL.searchById(txtID.Text));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string b = txtID.Text;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (nhanVienBLL.deleteById(b))
                {
                    btnReset_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            findAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            string PK_sMaNV = dt.ToString("MMddhhmmss");

            string sTenNV = txtEmployee.Text;
            DateTime dNgaysinh = dtpBirthDay.Value;
            string sGioitinh = cmbSex.Text;
            string sCCCD = txtIdentify.Text;
            string sDiachi = txtAddress.Text;
            string sSDT = txtPhone.Text;
            string sEmail = txtEmail.Text;
            DateTime dNgayvaolam = dtpWorkingDay.Value;
            if (sTenNV != "" && sCCCD != "" && sDiachi != "" && sSDT != "" && sEmail != "" && sGioitinh != "")
            {
                DateTimeOffset now = DateTimeOffset.UtcNow;
                string PK_sMabonhiem = "QDBN" + now.ToUnixTimeMilliseconds().ToString();
                MessageBox.Show(PK_sMaNV + " - " + sTenNV + " - " + dNgaysinh + " - " + sGioitinh + " - " + sCCCD + " - " + sDiachi + " - " + sSDT + " - " + sEmail + " - " + dNgayvaolam);
               //nhanVienBLL.insert(PK_sMaNV, sTenNV, dNgaysinh, sGioitinh, sCCCD, sDiachi, sSDT, sEmail, dNgayvaolam);
               MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmNhanVien_Load (sender, e);
            }
            else
                MessageBox.Show("Vui lòng nhập tất cả các trường dữ liệu ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtEmployee.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            cmbSex.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
            dtpBirthDay.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
            txtIdentify.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
            txtAddress.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
            txtPhone.Text = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
            txtEmail.Text = dgvNhanVien.CurrentRow.Cells[7].Value.ToString();
            dtpWorkingDay.Text = dgvNhanVien.CurrentRow.Cells[8].Value.ToString();
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtIdentify_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {

        }

        private void cmbSex_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtEmployee_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtID_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
