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
    public partial class frmHopDong : Form
    {
        HopDongBLL hopDongBLL = new HopDongBLL();
        public frmHopDong()
        {
            InitializeComponent();
        }

        private void findAll()
        {
            DataTable t = hopDongBLL.findAll();
            t.Columns.Add("STT");
            for (int i = 0; i < t.Rows.Count; i++)
                t.Rows[i]["STT"] = i + 1;
            dgvHopDong.DataSource = t;
            dgvHopDong.Columns["STT"].DisplayIndex = 0;
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
            cmbPhongban.DataSource = view;
            cmbPhongban.DisplayMember = "sTenPB";
            cmbPhongban.ValueMember = "PK_sMaPB";
        }

        private void getChucVu()
        {
            DataTable t = hopDongBLL.getChucVu();
            DataView view = new DataView(t);
            view.Sort = "PK_sMaCV";
            cmbChucvu.DataSource = view;
            cmbChucvu.DisplayMember = "sTenCV";
            cmbChucvu.ValueMember = "PK_sMaCV";
        }

        private void frmHopDong_Load(object sender, EventArgs e)
        {
            findAll();
            getNhanVien();
            getPhongBan();
            getChucVu();
            cmbNhanVien.Text = "";
            cmbChucvu.Text = "";
            cmbPhongban.Text = "";
            nmrThoiHan.Value = 1;
            nmrLuongCB.Value = 10000;
            txtMaHD.Text = "";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cmbNhanVien.Text != "" && cmbChucvu.Text != "" && cmbPhongban.Text != "")
            {
                hopDongBLL.insert(DateTime.Parse(DateTime.Now.ToShortDateString()), DateTime.Parse(DateTime.Now.AddYears(int.Parse(nmrThoiHan.Value.ToString())).ToShortDateString()), cmbNhanVien.SelectedValue.ToString(), cmbChucvu.SelectedValue.ToString(),
                cmbPhongban.SelectedValue.ToString(), float.Parse(nmrLuongCB.Value.ToString()));
                frmHopDong_Load(sender, e);
                MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Vui lòng nhập tất cả các trường dữ liệu ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void cmbNhanVien_Validating(object sender, CancelEventArgs e)
        {
            if (cmbNhanVien.Text == "")
            {
                errorProvider1.SetError(cmbNhanVien, "Không được để trống");
            }
            else
                errorProvider1.SetError(cmbNhanVien, "");
        }

        private void cmbChucvu_Validating(object sender, CancelEventArgs e)
        {
            if (cmbChucvu.Text == "")
            {
                errorProvider1.SetError(cmbChucvu, "Không được để trống");
            }
            else
                errorProvider1.SetError(cmbChucvu, "");
        }

        private void cmbPhongban_Validating(object sender, CancelEventArgs e)
        {
            if (cmbPhongban.Text == "")
            {
                errorProvider1.SetError(cmbPhongban, "Không được để trống");
            }
            else
                errorProvider1.SetError(cmbPhongban, "");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmHopDong_Load(sender,e);
        }

        private void dgvHopDong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbNhanVien.Text = dgvHopDong.CurrentRow.Cells[3].Value.ToString() + " - " + dgvHopDong.CurrentRow.Cells[4].Value.ToString();
            cmbChucvu.Text = dgvHopDong.CurrentRow.Cells[5].Value.ToString();
            cmbPhongban.Text = dgvHopDong.CurrentRow.Cells[6].Value.ToString();
            txtMaHD.Text = dgvHopDong.CurrentRow.Cells[0].Value.ToString();
            try
            {
                int a = DateTime.Parse(dgvHopDong.CurrentRow.Cells[2].Value.ToString()).Year - DateTime.Parse(dgvHopDong.CurrentRow.Cells[1].Value.ToString()).Year;
                nmrThoiHan.Text = a.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Không có giá trị, vui lòng chọn vị trí khác");
            }
            nmrLuongCB.Text = dgvHopDong.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string b = txtMaHD.Text;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (hopDongBLL.deleteById(b))
                {
                    btnLamMoi_Click(sender, e);
                    frmHopDong_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (cmbNhanVien.Text != "" && cmbChucvu.Text != "" && cmbPhongban.Text != "")
            {
                hopDongBLL.update(txtMaHD.Text,DateTime.Parse(DateTime.Now.ToShortDateString()), DateTime.Parse(DateTime.Now.AddYears(int.Parse(nmrThoiHan.Value.ToString())).ToShortDateString()), cmbNhanVien.SelectedValue.ToString(), cmbChucvu.SelectedValue.ToString(),
                cmbPhongban.SelectedValue.ToString(), float.Parse(nmrLuongCB.Value.ToString()));
                frmHopDong_Load(sender, e);
                MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Vui lòng nhập tất cả các trường dữ liệu ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void loadData(DataTable dsTimkiem)
        {
            dgvHopDong.DataSource = dsTimkiem;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            loadData(hopDongBLL.searchById(txtMaHD.Text));
        }
    }
}