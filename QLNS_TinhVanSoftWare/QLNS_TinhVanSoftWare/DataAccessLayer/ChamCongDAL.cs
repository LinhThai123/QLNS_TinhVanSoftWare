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