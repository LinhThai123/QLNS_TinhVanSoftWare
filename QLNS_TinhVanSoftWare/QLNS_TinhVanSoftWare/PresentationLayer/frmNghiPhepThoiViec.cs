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
    public partial class frmNghiPhepThoiViec : Form
    {
        public frmNghiPhepThoiViec()
        {
            InitializeComponent();
        }

        public void HienThiLoaiDon()
        {

            NghiPhepThoiViecBLL phepThoiViecBLL = new NghiPhepThoiViecBLL();
            DataTable dt = phepThoiViecBLL.LayDanhSachLoaiDon();
            cmbType.DataSource = dt;
            cmbType.DisplayMember = "sLoaiDon";
            cmbType.ValueMember = "sLoaiDon";
        }

        public void HienThiMaNV()
        {

            NghiPhepThoiViecBLL phepThoiViecBLL = new NghiPhepThoiViecBLL();
            DataTable dt = phepThoiViecBLL.LayDanhSachMaNV();
            cmbIDName.DataSource = dt;
            cmbIDName.DisplayMember = "sTenNV";
            cmbIDName.ValueMember = "FK_sMaNV";
        }

        public void HienThiPhongBan()
        {

            NghiPhepThoiViecBLL phepThoiViecBLL = new NghiPhepThoiViecBLL();
            DataTable dt = phepThoiViecBLL.LayDanhSachPhongBan();
            cmbDepartment.DataSource = dt;
            cmbDepartment.DisplayMember = "sTenPB";
            cmbDepartment.ValueMember = "PK_sMaPB";
        }

        private void frmNghiPhepThoiViec_Load(object sender, EventArgs e)
        {
            HienThiLoaiDon();
            HienThiMaNV();
            HienThiPhongBan();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
