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
    class NghiPhepThoiViecDAL
    {
        private SqlConnection connection;

        public NghiPhepThoiViecDAL()
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
    }
}
