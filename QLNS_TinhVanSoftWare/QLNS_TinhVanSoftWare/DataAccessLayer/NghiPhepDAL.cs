
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_TinhVanSoftWare.DataAccessLayer
{
    class NghiPhepDAL
    {
        private SqlConnection GetConnection()
        {
            string connectionString = "Data Source=DESKTOP-96D4EUK\\ADMIN;Initial Catalog=QuanLyNhanVien;Integrated Security=True";
            return new SqlConnection(connectionString);
        }
        private SqlConnection connection;

        public NghiPhepDAL()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }
        // Hàm thêm đơn xin nghỉ
        public Boolean ThemDonXinNghi(string maDon, DateTime ngayLap, string loaiDon, DateTime ngayBatDau, DateTime ngayKetThuc, string maNV, string maCV, string maPB, string lyDo)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("sp_ThemDonXinNghi", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@PK_sMaDon", maDon); // Thêm dòng này
                    cmd.Parameters.AddWithValue("@dNgayLap", ngayLap);
                    cmd.Parameters.AddWithValue("@sLoaiDon", loaiDon);
                    cmd.Parameters.AddWithValue("@dNgayBatDau", ngayBatDau);
                    cmd.Parameters.AddWithValue("@dNgayKetThuc", ngayKetThuc);
                    cmd.Parameters.AddWithValue("@FK_sMaNV", maNV);
                    cmd.Parameters.AddWithValue("@FK_sMaCV", maCV);
                    cmd.Parameters.AddWithValue("@FK_sMaPB", maPB);
                    cmd.Parameters.AddWithValue("@sLyDo", lyDo);

                    int result = cmd.ExecuteNonQuery();

                    return result > 0;
                }
            }
        }

       
        // Hàm xóa đơn xin nghỉ
        public bool XoaDonXinNghi(string PK_sMaDon)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("sp_XoaDonXinNghi", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PK_sMaDon", PK_sMaDon);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

     

        // Phương thức đóng kết nối
        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        // Phương thức mở kết nối
        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public DataTable LayDanhSachLoaiDon()
        {
            OpenConnection();
            DataTable dt = new DataTable();
            string query = "SELECT sLoaidon FROM tbl_Donxinnghi;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dt);
            CloseConnection();
            return dt;
        }
        public DataTable LayDanhSachMaNV()
        {
            OpenConnection();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM tbl_DonXinNghi join tbl_Nhanvien on tbl_Donxinnghi.FK_sMaNV = tbl_Nhanvien.PK_sMaNV";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            dataAdapter.Fill(dt);
            CloseConnection();
            return dt;

        }

        public DataTable LayDanhSachPhongBan()
        {
            OpenConnection();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM tbl_Phongban";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            dataAdapter.Fill(dt);
            CloseConnection();
            return dt;

        }
        public DataTable LayDanhSachChucVu()
        {
            OpenConnection();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM tbl_Chucvu";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            dataAdapter.Fill(dt);
            CloseConnection();
            return dt;

        }
        public DataTable LayDanhSachDonXinNghi()
        {
            OpenConnection();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM tbl_DonXinNghi";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            dataAdapter.Fill(dt);
            CloseConnection();
            return dt;

        }

        public DataTable TimKiemDonXinNghi( string loaiDon, string maNV, string maCV, string maPB, string lyDo)
        {
            DataTable dtDonXinNghi = new DataTable();

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("sp_TimKiemDonXinNghi", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

               
                    cmd.Parameters.AddWithValue("@LoaiDon", "%" + loaiDon + "%");
                    cmd.Parameters.AddWithValue("@MaNV", "%" + maNV + "%");
                    cmd.Parameters.AddWithValue("@MaCV", "%" + maCV + "%");
                    cmd.Parameters.AddWithValue("@MaPB", "%" + maPB + "%");
                    cmd.Parameters.AddWithValue("@LyDo", "%" + lyDo + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dtDonXinNghi);
                    }
                }
            }

            return dtDonXinNghi;
        }



    }
}
