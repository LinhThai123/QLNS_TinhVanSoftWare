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
    public partial class frmChamCong : Form
    {
        public frmChamCong()
        {
            InitializeComponent();
        }
        public void HienThiMaNhanVien()
        {
            ChamCongBLL nhanVienBBL = new ChamCongBLL();
            DataTable dt = nhanVienBBL.LayDanhSachMaNhanVien();
            cmbMaNv.DataSource = dt;
            cmbMaNv.DisplayMember = "PK_sMaNV";
            cmbMaNv.ValueMember = "PK_sMaNV";

            

        }

        private void cmbMaNv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmChamCong_Load(object sender, EventArgs e)
        {
            HienThiMaNhanVien();
            LoadDataIntoDataGridView();
            CustomizeColumnHeaders();
           

        }
        private void CustomizeColumnHeaders()
        {
            /*// Thay đổi tên cột dựa trên tên cột trong cơ sở dữ liệu
            dataGridView1.Columns["ColumnNameFromDatabase"].HeaderText = "Tên cột mới";*/

            // Hoặc bạn có thể thay đổi tên cột dựa trên chỉ mục của cột
            dgvChamCong.Columns[0].HeaderText = "Mã chấm công";
            dgvChamCong.Columns[1].HeaderText = "Mã NV";
            dgvChamCong.Columns[2].HeaderText = "Ngày chấm công";
            dgvChamCong.Columns[3].HeaderText = "Giờ vào";
            dgvChamCong.Columns[4].HeaderText = "Giờ ra";
            dgvChamCong.Columns[5].HeaderText = "Số giờ làm";
            dgvChamCong.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        private void LoadDataIntoDataGridView()
        {
            // Thay đổi chuỗi kết nối này để phù hợp với cấu hình SQL Server của bạn
            string connectionString = @"Data Source=DESKTOP-96D4EUK\ADMIN;Initial Catalog=QuanLyNhanVien;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Thay đổi truy vấn này để lấy dữ liệu từ bảng bạn muốn
                string query = "SELECT * FROM tbl_Chamcong";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Gán dữ liệu từ DataTable vào DataGridView
                dgvChamCong.DataSource = dataTable;
            }
        }

        private void dtpNgayChamCong_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpNgayChamCong.Value;
            
        }

        private void dgvChamCong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maNhanVien = cmbMaNv.Text.Trim();
            string ngayChamCong = dtpNgayChamCong.Value.ToString("yyyy-MM-dd");


            string connectionString = @"Data Source=DESKTOP-96D4EUK\ADMIN;Initial Catalog=QuanLyNhanVien;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT * FROM tbl_ChamCong WHERE
                            (FK_sMaNV = @MaNhanVien )
                            AND (CONVERT(date, dNgaychamcong) = @NgayChamCong)";


                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                command.Parameters.AddWithValue("@NgayChamCong", dtpNgayChamCong.Value);


                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Gán dữ liệu từ DataTable vào DataGridView
                dgvChamCong.DataSource = dataTable;
            }
        }
    }
}
