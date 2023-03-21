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
    }
}
