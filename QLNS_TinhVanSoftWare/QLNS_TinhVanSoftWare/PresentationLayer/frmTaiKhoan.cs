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
       
        BusinessLogicLayer.TaiKhoanBLL taiKhoanBLL = new BusinessLogicLayer.TaiKhoanBLL();

        BusinessLogicLayer.QuyenBLL quyenBLL = new BusinessLogicLayer.QuyenBLL(); 

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
            if (cbMaNV.Text != "" && txtMaTK.Text != "" && txtTenTK.Text != "" 
                && txtTinhTrang.Text != "" && cbMaQuyen.Text != "" && txtMK.Text != "")
            {
                if (taiKhoanBLL.Check_MaTaiKhoan( txtMaTK.Text))
                {
                    taiKhoanBLL.insert(cbMaNV.Text, txtMaTK.Text, txtTenTK.Text, txtTinhTrang.Text, cbMaQuyen.Text, txtMK.Text);
                    MessageBox.Show("Thêm tài khoản thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmTaiKhoan_Load(sender, e); 
                }
                else
                {
                    MessageBox.Show("Tài đã tồn tại! Vui lòng thêm tài khoản khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            cbMaQuyen.ValueMember = "sTenquyen";

        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            findAll();
            hienTenQuyen();
        }
    }
}
