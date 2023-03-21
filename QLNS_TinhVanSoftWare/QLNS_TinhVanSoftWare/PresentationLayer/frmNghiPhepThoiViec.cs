using QLNS_TinhVanSoftWare.BusinessLogicLayer;

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
            this.dgvNghilamthoiviec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNghilamthoiviec_CellClick);

        }

        // Đổ dữ liệu vào combobox Loại Đơn

        public void HienThiLoaiDon()
        {

            NghiPhepBBL phepThoiViecBLL = new NghiPhepBBL();
            DataTable dt = phepThoiViecBLL.LayDanhSachLoaiDon();
            cmbType.DataSource = dt;
            cmbType.DisplayMember = "sLoaiDon";
            cmbType.ValueMember = "sLoaiDon";
        }

        // Đổ dữ liệu vào combobox Tên NV
        public void HienThiMaNV()
        {

            NghiPhepBBL phepThoiViecBLL = new NghiPhepBBL();
            DataTable dt = phepThoiViecBLL.LayDanhSachMaNV();
            cmbIDName.DataSource = dt;
            cmbIDName.DisplayMember = "sTenNV";
            cmbIDName.ValueMember = "FK_sMaNV";
        }
        // Đổ dữ liệu vào combobox Phòng ban
        public void HienThiPhongBan()
        {

            NghiPhepBBL phepThoiViecBLL = new NghiPhepBBL();
            DataTable dt = phepThoiViecBLL.LayDanhSachPhongBan();
            cmbDepartment.DataSource = dt;
            cmbDepartment.DisplayMember = "sTenPB";
            cmbDepartment.ValueMember = "PK_sMaPB";
        }
        // Đổ dữ liệu vào combobox Chức vụ
        public void HienThiChucVu()
        {

            NghiPhepBBL phepThoiViecBLL = new NghiPhepBBL();
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
            DateTimeOffset now = DateTimeOffset.UtcNow;
            string PK_DNP = "DNP" + now.Millisecond.ToString();

            if (nghiPhepBBL.ThemDonXinNghi(PK_DNP, dtpNgayLap.Value, cmbType.SelectedValue.ToString(), dtpStartday.Value, dtpEndday.Value, cmbIDName.SelectedValue.ToString(), cmbPosition.SelectedValue.ToString(), cmbDepartment.SelectedValue.ToString(), rtbReason.Text ))
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


            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNghilamthoiviec.Rows[e.RowIndex];


                dtpNgayLap.Value = DateTime.Parse(row.Cells["dNgayLap"].Value.ToString());
                cmbType.Text = row.Cells["sLoaiDon"].Value.ToString();
                dtpStartday.Value = DateTime.Parse(row.Cells["dNgayBatDau"].Value.ToString());
                dtpEndday.Value = DateTime.Parse(row.Cells["dNgayKetThuc"].Value.ToString());
                cmbIDName.Text = row.Cells["FK_sMaNV"].Value.ToString();
                cmbPosition.Text = row.Cells["FK_sMaCV"].Value.ToString();
                cmbDepartment.Text = row.Cells["FK_sMaPB"].Value.ToString();
                rtbReason.Text = row.Cells["sLyDo"].Value.ToString();
            }


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

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void dgvNghilamthoiviec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
   

}
   



   
