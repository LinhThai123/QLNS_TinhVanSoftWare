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
    public partial class frmChucVu : Form
    {
        ChucVuBLL chucVuBLL = new ChucVuBLL();
        public frmChucVu()
        {
            InitializeComponent();
        }
       
        
        private void findAll()
        {
            DataTable t = chucVuBLL.findAll();
            t.Columns.Add("STT");
            for (int i = 0; i < t.Rows.Count; i++)
                t.Rows[i]["STT"] = i + 1;
            dgvChucvu.DataSource = t;
            dgvChucvu.Columns["STT"].DisplayIndex = 0;
        }
        private void frmChucVu_Load(object sender, EventArgs e)
        {
            findAll();
            txtMaCV.Text = "";
            txtTenCV.Text = "";
            txtHSL.Text = "";

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaCV.Text.Length == 0 && txtTenCV.Text != "")
            {
                chucVuBLL.insert(txtMaCV.Text.ToString(), txtTenCV.Text.ToString(), txtHSL.Text.ToString());
                frmChucVu_Load(sender, e);
                MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Vui lòng nhập tất cả các trường dữ liệu ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMaCV.Text.Length == 0 && txtTenCV.Text != "")
            {
                chucVuBLL.update(txtMaCV.Text.ToString(), txtTenCV.Text.ToString());

                frmChucVu_Load(sender, e);
                MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Vui lòng nhập tất cả các trường dữ liệu ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmChucVu_Load(sender, e);
        }

        private void dgvChucvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
