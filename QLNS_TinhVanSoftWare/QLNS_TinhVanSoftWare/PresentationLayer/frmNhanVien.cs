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
        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            findAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

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
            cmbStatus.Text = dgvNhanVien.CurrentRow.Cells[9].Value.ToString();
        }
    }
}
