using QLNS_TinhVanSoftWare.BusinessLogicLayer;
using QLNS_TinhVanSoftWare.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_TinhVanSoftWare.PresentationLayer
{
    public partial class frmNghiPhepThoiViec : Form
    {
        private NghiPhepBBL nghiPhepBBL = new NghiPhepBBL();

        public frmNghiPhepThoiViec()
        {
            InitializeComponent();
        }

        // Đổ dữ liệu vào combobox Loại Đơn

        public void HienThiLoaiDon()
        {

            NghiPhepThoiViecBLL phepThoiViecBLL = new NghiPhepThoiViecBLL();
            DataTable dt = phepThoiViecBLL.LayDanhSachLoaiDon();
            cmbType.DataSource = dt;
            cmbType.DisplayMember = "sLoaiDon";
            cmbType.ValueMember = "sLoaiDon";
        }

        // Đổ dữ liệu vào combobox Tên NV
        public void HienThiMaNV()
        {

            NghiPhepThoiViecBLL phepThoiViecBLL = new NghiPhepThoiViecBLL();
            DataTable dt = phepThoiViecBLL.LayDanhSachMaNV();
            cmbIDName.DataSource = dt;
            cmbIDName.DisplayMember = "sTenNV";
            cmbIDName.ValueMember = "FK_sMaNV";
        }
        // Đổ dữ liệu vào combobox Phòng ban
        public void HienThiPhongBan()
        {

            NghiPhepThoiViecBLL phepThoiViecBLL = new NghiPhepThoiViecBLL();
            DataTable dt = phepThoiViecBLL.LayDanhSachPhongBan();
            cmbDepartment.DataSource = dt;
            cmbDepartment.DisplayMember = "sTenPB";
            cmbDepartment.ValueMember = "PK_sMaPB";
        }
        // Đổ dữ liệu vào combobox Chức vụ
        public void HienThiChucVu()
        {

            NghiPhepThoiViecBLL phepThoiViecBLL = new NghiPhepThoiViecBLL();
            DataTable dt = phepThoiViecBLL.LayDanhSachChucVu();
            cmbPosition.DataSource = dt;
            cmbPosition.DisplayMember = "sTenCV";
            cmbPosition.ValueMember = "PK_sMaCV";
        }

      
        private void frmNghiPhepThoiViec_Load(object sender, EventArgs e)
        {

            HienThiLoaiDon();
            HienThiMaNV();
            HienThiPhongBan();
            HienThiChucVu();
            LoadDanhSachDonXinNghi();



        }
        private void LoadDanhSachDonXinNghi()
        {
            dgvNghilamthoiviec.DataSource = nghiPhepBBL.LayDanhSachDonXinNghi();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            

        }
        // Thêm 1 đơn nghỉ
        private void btnCreate_Click(object sender, EventArgs e)
        {
            DonXinNghi donXinNghi = new DonXinNghi
            {
                PK_sMaDon = "DON00077", 
                dNgayLap = dtpNgayLap.Value,
                sLoaiDon = cmbType.SelectedItem.ToString(),
                dNgayBatDau = dtpStartday.Value,
                dNgayKetThuc = dtpEndday.Value,
                FK_sMaNV = cmbIDName.SelectedValue.ToString(),
                FK_sMaCV = cmbPosition.SelectedValue.ToString(),
                FK_sMaPB = cmbDepartment.SelectedValue.ToString(),
                sLyDo = rtbReason.Text
            };

            if (nghiPhepBBL.ThemDonXinNghi(donXinNghi))
            {
                MessageBox.Show("Thêm đơn xin nghỉ thành công!");
                LoadDanhSachDonXinNghi();
            }
            else
            {
                MessageBox.Show("Thêm đơn xin nghỉ thất bại!");
            }
        }

        private void dgvNghilamthoiviec_CellClick(object sender, DataGridViewCellEventArgs e)
        {

          
           

     
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
           /* string maDon =;*/
          string  loaiDon = cmbType.SelectedValue.ToString();
          string  maNV = cmbIDName.SelectedValue.ToString(); 
           string maCV = cmbPosition.SelectedValue.ToString(); 
           string maPB = cmbDepartment.SelectedValue.ToString();
           string lyDo = rtbReason.Text;



            dgvNghilamthoiviec.DataSource = nghiPhepBBL.TimKiemDonXinNghi( loaiDon, maNV, maCV, maPB, lyDo);
        }
    }
   

}
   



   
