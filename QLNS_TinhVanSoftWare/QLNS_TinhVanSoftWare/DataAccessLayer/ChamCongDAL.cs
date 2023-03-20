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
    class ChamCongDAL
    {
        private SqlConnection connection;

        public ChamCongDAL()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }
        // Phương thức mở kết nối
        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
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

    /*    // Phương thức thêm tài khoản
        public bool ThemTaiKhoan(string maNV, string taiKhoan, string matKhau, string quyen)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("sp_ThemTaiKhoan", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maNV", maNV);
            cmd.Parameters.AddWithValue("@taiKhoan", taiKhoan);
            cmd.Parameters.AddWithValue("@matKhau", matKhau);
            cmd.Parameters.AddWithValue("@quyen", quyen);

            int result = cmd.ExecuteNonQuery();
            CloseConnection();
            return result > 0;
        }


        // Phương thức sửa tài khoản
        public bool SuaTaiKhoan(string maNV, string taiKhoan, string matKhau, string quyen)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("sp_SuaTaiKhoan", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maNV", maNV);
            cmd.Parameters.AddWithValue("@taiKhoan", taiKhoan);
            cmd.Parameters.AddWithValue("@matKhau", matKhau);
            cmd.Parameters.AddWithValue("@quyen", quyen);

            int result = cmd.ExecuteNonQuery();
            CloseConnection();
            return result > 0;
        }
        // Phương thức xóa tài khoản
        public bool XoaTaiKhoan(string maNV)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("sp_XoaTaiKhoan", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maNV", maNV);

            int result = cmd.ExecuteNonQuery();
            CloseConnection();
            return result > 0;
        }
*/



  /*      // kiểm tra đăng nhập
        public bool KiemTraDangNhap(string taiKhoan, string matKhau)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("sp_KiemTraDangNhap", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@taiKhoan", taiKhoan);
            cmd.Parameters.AddWithValue("@matKhau", matKhau);

            int result = (int)cmd.ExecuteScalar();
            CloseConnection();
            return result > 0;
        }*/

        // đổ dữ liệu ra combobox
        public DataTable LayDanhSachMaNhanVien()
        {
            OpenConnection();
            DataTable dt = new DataTable();
            string query = "SELECT PK_sMaNV,sTenNV FROM tbl_NhanVien;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dt);
            CloseConnection();
            return dt;
        }

    }
}
