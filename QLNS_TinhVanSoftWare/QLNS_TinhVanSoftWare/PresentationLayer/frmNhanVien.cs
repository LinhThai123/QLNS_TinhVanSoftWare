using QLNS_TinhVanSoftWare.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            loadData(nhanVienBLL.searchByIdOrName(txtID.Text, txtEmployee.Text));
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
            txtID.Text = "";
            txtEmployee.Text = "";
            cmbSex.Text = "";
            dtpBirthDay.Text = "";
            txtIdentify.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            dtpWorkingDay.Text = "";
        }

        private bool check_Age()
        {
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(dtpBirthDay.Value.ToString("yyyyMMdd"));
            int age = (now - dob) / 10000;
            if (age < 18) return false;
            else return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string PK_sMaNV = txtID.Text;
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
                if (nhanVienBLL.check_ID(PK_sMaNV))
                {
                    if (check_Age())
                    {
                        string pattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
                        if (Regex.IsMatch(txtEmail.Text, pattern) && sCCCD.Length == 12 && sSDT.Length == 10 && nhanVienBLL.IsValidVietNamPhoneNumber(txtPhone.Text))
                        {
                            nhanVienBLL.insert(PK_sMaNV, sTenNV, dNgaysinh, sGioitinh, sCCCD, sDiachi, sSDT, sEmail, dNgayvaolam);
                            MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmNhanVien_Load(sender, e);
                        }
                    }
                    else
                        MessageBox.Show("Chưa đủ 18 tuổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Mã nhân viên không được trùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Vui lòng nhập tất cả các trường dữ liệu ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string PK_sMaNV = txtID.Text;
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
                if (!nhanVienBLL.check_ID(PK_sMaNV))
                {
                    if (check_Age())
                    {
                        string pattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
                        if (Regex.IsMatch(txtEmail.Text, pattern) && sCCCD.Length == 12 && sSDT.Length == 10 && nhanVienBLL.IsValidVietNamPhoneNumber(txtPhone.Text))
                        {
                            nhanVienBLL.update(PK_sMaNV, sTenNV, dNgaysinh, sGioitinh, sCCCD, sDiachi, sSDT, sEmail, dNgayvaolam);
                            MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmNhanVien_Load(sender, e);
                        }
                        else
                            MessageBox.Show("Định dạng dữ liệu không đúng, vui lòng kiểm tra lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Chưa đủ 18 tuổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Nhân viên này không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Vui lòng nhập tất cả các trường dữ liệu ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            string pattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            if (txtEmail.Text == "")
            {
                errorProvider1.SetError(txtEmail, "Không được để trống !");
            }
            else
            {
                if (Regex.IsMatch(txtEmail.Text, pattern))
                {
                    errorProvider1.SetError(txtEmail, "");
                }
                else
                    errorProvider1.SetError(txtEmail, "Không phải Email");
            }
        }

        private void txtIdentify_Validating(object sender, CancelEventArgs e)
        {
            if (txtIdentify.Text == "")
            {
                errorProvider1.SetError(txtIdentify, "Không được để trống !");
            }
            else if (txtIdentify.Text.Length != 12)
                errorProvider1.SetError(txtIdentify, "CCCD phải có 12 số");
            else
                errorProvider1.SetError(txtIdentify, "");
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (txtPhone.Text == "")
            {
                errorProvider1.SetError(txtPhone, "Không được để trống !");
            }
            else if (txtPhone.Text.Length != 10)
                errorProvider1.SetError(txtPhone, "Số Điện Thoại chỉ có 10 số");
            else if (!nhanVienBLL.IsValidVietNamPhoneNumber(txtPhone.Text))
                errorProvider1.SetError(txtPhone, "Không phải số điện thoại Việt Nam");
            else
                errorProvider1.SetError(txtPhone, "");
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (txtAddress.Text == "")
            {
                errorProvider1.SetError(txtAddress, "Không được để trống");
            }
            else
                errorProvider1.SetError(txtAddress, "");
        }

        private void cmbSex_Validating(object sender, CancelEventArgs e)
        {
            if (cmbSex.Text == "")
            {
                errorProvider1.SetError(cmbSex, "Không được để trống");
            }
            else
                errorProvider1.SetError(cmbSex, "");
        }

        private void txtEmployee_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmployee.Text == "")
            {
                errorProvider1.SetError(txtEmployee, "Không được để trống");
            }
            else
                errorProvider1.SetError(txtEmployee, "");
        }

        private void txtID_Validating(object sender, CancelEventArgs e)
        {
            if (txtID.Text == "")
            {
                errorProvider1.SetError(txtID, "Không được để trống");
            }
            else
                errorProvider1.SetError(txtID, "");
        }

        private void txtIdentify_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
