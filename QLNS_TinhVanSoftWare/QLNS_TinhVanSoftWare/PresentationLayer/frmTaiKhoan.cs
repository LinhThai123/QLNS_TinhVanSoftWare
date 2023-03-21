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
    public partial class frmTaiKhoan : Form
    {
       
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();

        QuyenBLL quyenBLL = new BusinessLogicLayer.QuyenBLL();

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

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            string MaNV = cbMaNV.SelectedValue.ToString();
            string MaTK = txtMaTK.Text;
            string TenTK = txtTenTK.Text;
            string MK = txtMK.Text; 
            string tinhTrang = txtTinhTrang.Text;
            string maQuyen = cbMaQuyen.SelectedValue.ToString(); 

            if (cbMaNV.Text != "" && txtMaTK.Text != "" && txtTenTK.Text != "" 
                && txtTinhTrang.Text != "" && cbMaQuyen.Text != "" && txtMK.Text != "")
            {
                if (taiKhoanBLL.Check_MaTaiKhoan( txtMaTK.Text))
                {
                    taiKhoanBLL.insert(MaTK, TenTK, MK, tinhTrang, MaNV, maQuyen);
                    MessageBox.Show("Thêm tài khoản thành công" ,"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmTaiKhoan_Load(sender, e); 
                }
                else
                {
                    MessageBox.Show("Tài khoản đã tồn tại! Vui lòng thêm tài khoản khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ các thông tin ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void hienTenQuyen()
        {
            DataTable t = quyenBLL.layDSQuyen();
            DataView view = new DataView(t);
            view.Sort = "PK_sMaquyen";
            cbMaQuyen.DataSource = view;
            cbMaQuyen.DisplayMember = "sTenquyen";
            cbMaQuyen.ValueMember = "PK_sMaquyen";

        }

        public void hienTenNhanVien()
        {
            DataTable t = nhanVienBLL.layDSNhanVien();
            DataView view = new DataView(t);
            view.Sort = "PK_sMaNV";
            cbMaNV.DataSource = view;
            cbMaNV.DisplayMember = "sTenNV";
            cbMaNV.ValueMember = "PK_sMaNV";

        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            findAll();
            hienTenQuyen();
            hienTenNhanVien();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string maTK = txtMaTK.Text;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (taiKhoanBLL.deleteTaiKhoan(maTK))
                {
                    button5_Click(sender, e); 
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtMaTK.Text = "";
            txtMK.Text = "";
            txtTenTK.Text = "";
            txtTinhTrang.Text = "";         
            frmTaiKhoan_Load(sender, e);
        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaTK.Text = dgvTaiKhoan.CurrentRow.Cells[0].Value.ToString();
            cbMaNV.SelectedValue = dgvTaiKhoan.CurrentRow.Cells[1].Value.ToString();
            txtMK.Text = dgvTaiKhoan.CurrentRow.Cells[3].Value.ToString();
            txtTinhTrang.Text = dgvTaiKhoan.CurrentRow.Cells[5].Value.ToString();
            cbMaQuyen.SelectedValue = dgvTaiKhoan.CurrentRow.Cells[4].Value.ToString();
            txtTenTK.Text = dgvTaiKhoan.CurrentRow.Cells[2].Value.ToString(); 
        }
    }
}
