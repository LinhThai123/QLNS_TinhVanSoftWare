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

        //Hiển thị dữ liệu ở DataGridView
        private void LoadDataIntoDataGridView()
        {
            // Thay đổi chuỗi kết nối này để phù hợp với cấu hình SQL Server của bạn
            string connectionString = @"Data Source=DESKTOP-96D4EUK\ADMIN;Initial Catalog=QuanLyNhanVien;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Thay đổi truy vấn này để lấy dữ liệu từ bảng bạn muốn
                string query = "SELECT * FROM tbl_Donxinnghi";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Gán dữ liệu từ DataTable vào DataGridView
                dgvNghilamthoiviec.DataSource = dataTable;
            }
        }


        // Hoặc bạn có thể thay đổi tên cột dựa trên chỉ mục của cột
        private void CustomizeColumnHeaders()
        {

            dgvNghilamthoiviec.Columns[0].HeaderText = "Mã Đơn";
            dgvNghilamthoiviec.Columns[1].HeaderText = "Ngày lập";
            dgvNghilamthoiviec.Columns[2].HeaderText = "Loại đơn";
            dgvNghilamthoiviec.Columns[3].HeaderText = "Ngày bắt đầu";
            dgvNghilamthoiviec.Columns[4].HeaderText = "Ngày kết thúc";
            dgvNghilamthoiviec.Columns[5].HeaderText = "Mã NV";
            dgvNghilamthoiviec.Columns[6].HeaderText = "Phòng ban";
            dgvNghilamthoiviec.Columns[7].HeaderText = "Chức vụ";
            dgvNghilamthoiviec.Columns[8].HeaderText = "Lý do";
            dgvNghilamthoiviec.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void frmNghiPhepThoiViec_Load(object sender, EventArgs e)
        {
            cmbType.Enabled = false;
            cmbIDName.Enabled = false;
            cmbDepartment.Enabled = false;
            cmbPosition.Enabled = false;
            dtpEndday.Enabled = false;
            dtpStartday.Enabled = false;
            btnUpdate.Enabled = false;
            btnFind.Enabled = false;
            btnDelete.Enabled = false;
            btnReset.Enabled = false;
            btnCreate.Enabled = false;
            cmbStatus.Enabled = false;
            btnAdd.Enabled = true;
            rtbReason.Enabled = false;

            HienThiLoaiDon();
            HienThiMaNV();
            HienThiPhongBan();
            HienThiChucVu();
            LoadDataIntoDataGridView();
            CustomizeColumnHeaders();
            
            btnFind_Click(sender,e);



        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cmbType.Enabled = true;
            cmbIDName.Enabled = true;
            cmbDepartment.Enabled = true;
            cmbPosition.Enabled = true;
            dtpEndday.Enabled = true;
            dtpStartday.Enabled = true;
            btnUpdate.Enabled = true;
            btnFind.Enabled = true;
            btnDelete.Enabled = true;
            btnReset.Enabled = true;
            btnCreate.Enabled = true;
            cmbStatus.Enabled = true;
            rtbReason.Enabled = true;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string loaiDon = cmbType.Text.Trim();
            string TenNV = cmbIDName.Text.Trim();
            string phongBan = cmbDepartment.Text.Trim();
            string chucVu = cmbPosition.Text.Trim();
            string ngayBD = dtpStartday.Value.ToString("yyyy-MM-dd");
            string ngayKT = dtpEndday.Value.ToString("yyyy-MM-dd");
            string ngayLap = dtpNgayLap.Value.ToString("yyyy-MM-dd");
            string lyDo = rtbReason.Text.Trim();



            string connectionString = @"Data Source=DESKTOP-96D4EUK\ADMIN;Initial Catalog=QuanLyNhanVien;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"select * from tbl_Donxinnghi  where (sLoaidon = @loaiDon)
                            And(FK_sMaNV= @TenNV)or(convert(date,dNgaylap)=@ngayLap)";


                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@loaiDon", loaiDon);
                command.Parameters.AddWithValue("@TenNV", TenNV);
                command.Parameters.AddWithValue("@ngayLap", ngayLap);


                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Gán dữ liệu từ DataTable vào DataGridView
                dgvNghilamthoiviec.DataSource = dataTable;

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbType.Text="";
            cmbIDName.Text="";
            cmbDepartment.Text= "";
            cmbPosition.Text="";
            dtpEndday.Text="";
            dtpStartday.Text="";
            cmbStatus.Text="";
            cmbStatus.Text="";

        }
    }
}
