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
    public partial class frmBoNhiem : Form
    {
        HopDongBLL hopDongBLL = new HopDongBLL();
        BoNhiemBLL boNhiemBLL = new BoNhiemBLL();
        public frmBoNhiem()
        {
            InitializeComponent();
        }

        private void findAll()
        {
            DataTable t = boNhiemBLL.findAll();
            t.Columns.Add("STT");
            for (int i = 0; i < t.Rows.Count; i++)
                t.Rows[i]["STT"] = i + 1;
            dgvBoNhiem.DataSource = t;
            dgvBoNhiem.Columns["STT"].DisplayIndex = 0;
        }

        private void getNhanVien()
        {
            DataTable t = hopDongBLL.getNhanVien();
            DataView view = new DataView(t);
            view.Sort = "PK_sMaNV";
            cmbNhanVien.DataSource = view;
            cmbNhanVien.DisplayMember = "nhanVien";
            cmbNhanVien.ValueMember = "PK_sMaNV";
        }

        private void getPhongBan()
        {
            DataTable t = hopDongBLL.getPhongBan();
            DataView view = new DataView(t);
            view.Sort = "PK_sMaPB";
            cmbPhongBan.DataSource = view;
            cmbPhongBan.DisplayMember = "sTenPB";
            cmbPhongBan.ValueMember = "PK_sMaPB";
        }

        private void getChucVu()
        {
            DataTable t = hopDongBLL.getChucVu();
            DataView view = new DataView(t);
            view.Sort = "PK_sMaCV";
            cmbChucVu.DataSource = view;
            cmbChucVu.DisplayMember = "sTenCV";
            cmbChucVu.ValueMember = "PK_sMaCV";
        }

        private void dgvBoNhiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbNhanVien.Text = dgvBoNhiem.CurrentRow.Cells[3].Value.ToString() + " - " + dgvBoNhiem.CurrentRow.Cells[4].Value.ToString();
            cmbChucVu.Text = dgvBoNhiem.CurrentRow.Cells[5].Value.ToString();
            cmbPhongBan.Text = dgvBoNhiem.CurrentRow.Cells[6].Value.ToString();
            dtpNgayHieuLuc.Text = dgvBoNhiem.CurrentRow.Cells[2].Value.ToString();
            txtMabonhiem.Text = dgvBoNhiem.CurrentRow.Cells[0].Value.ToString();
            nmrLuongMoi.Text = dgvBoNhiem.CurrentRow.Cells[7].Value.ToString();
            txtNoiDung.Text = dgvBoNhiem.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cmbNhanVien.Text != "" && cmbChucVu.Text != "" && cmbPhongBan.Text != "" && txtNoiDung.Text != "")
            {
                DateTimeOffset now = DateTimeOffset.UtcNow;
                string PK_sMabonhiem = "QDBN" + now.ToUnixTimeMilliseconds().ToString();
                boNhiemBLL.insert(PK_sMabonhiem, DateTime.Parse(DateTime.Now.ToShortDateString()), DateTime.Parse(dtpNgayHieuLuc.Value.ToShortDateString()), cmbNhanVien.SelectedValue.ToString(), cmbChucVu.SelectedValue.ToString(),
                cmbPhongBan.SelectedValue.ToString(), float.Parse(nmrLuongMoi.Value.ToString()),txtNoiDung.Text);
                MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmBoNhiem_Load(sender, e);
            }
            else
                MessageBox.Show("Vui lòng nhập tất cả các trường dữ liệu ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cmbNhanVien.Text != "" && cmbChucVu.Text != "" && cmbPhongBan.Text != "" && txtNoiDung.Text != "")
            {
                boNhiemBLL.update(txtMabonhiem.Text, DateTime.Parse(DateTime.Now.ToShortDateString()), DateTime.Parse(dtpNgayHieuLuc.Value.ToShortDateString()), cmbNhanVien.SelectedValue.ToString(), cmbChucVu.SelectedValue.ToString(),
                cmbPhongBan.SelectedValue.ToString(), float.Parse(nmrLuongMoi.Value.ToString()), txtNoiDung.Text);
                MessageBox.Show("Sửa thành công" + nmrLuongMoi.Text, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmBoNhiem_Load(sender, e);
            }
            else
                MessageBox.Show("Vui lòng nhập tất cả các trường dữ liệu ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmBoNhiem_Load(sender, e);
        }

        private void frmBoNhiem_Load(object sender, EventArgs e)
        {
            findAll();
            getNhanVien();
            getPhongBan();
            getChucVu();
            cmbNhanVien.Text = "";
            cmbChucVu.Text = "";
            cmbPhongBan.Text = "";
            nmrLuongMoi.Value = 10000;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
