using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace QLNS_TinhVanSoftWare.DataAccessLayer
{
    class BienBanDanhGiaDAL
    {
        private string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        //load toàn bảng 
        public DataTable findAll()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM vv_Bienban", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("vv_Bienban"))
                        {
                            ad.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        //Thêm biên bản
        public bool themBienBan(string maBienBan, DateTime ngayLap, string maNV, string maCV, string maPB, string noidungDG)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "themBienBan";
                    cmd.Parameters.AddWithValue("@Mabienban", maBienBan);
                    cmd.Parameters.AddWithValue("@Ngaylap", ngayLap);
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    cmd.Parameters.AddWithValue("@MaCV", maCV);
                    cmd.Parameters.AddWithValue("@MaPB", maPB);
                    cmd.Parameters.AddWithValue("@NoidungDG", noidungDG);

                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }


        public bool suaBienBan(string maBienBan, DateTime ngayLap, string maNV, string maCV, string maPB, string noidungDG)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "suaBienBan";
                    cmd.Parameters.AddWithValue("@Mabienban", maBienBan);
                    cmd.Parameters.AddWithValue("@Ngaylap", ngayLap);
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    cmd.Parameters.AddWithValue("@MaCV", maCV);
                    cmd.Parameters.AddWithValue("@MaPB", maPB);
                    cmd.Parameters.AddWithValue("@NoidungDG", noidungDG);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }

        public bool xoaBienBan(string maBienBan)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "xoaBienBan";
                    cmd.Parameters.AddWithValue("Mabienban", maBienBan);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }


        public DataTable timBienBan(String maBienBan)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                String sql = "SELECT * FROM vv_Bienban WHERE [Mã biên bản] LIKE '" + maBienBan + "' ";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("vv_Bienban"))
                        {
                            ad.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

    }
}
