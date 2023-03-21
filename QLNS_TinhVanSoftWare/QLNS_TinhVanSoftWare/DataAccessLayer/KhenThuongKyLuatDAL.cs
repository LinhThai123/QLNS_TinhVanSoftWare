using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_TinhVanSoftWare.DataAccessLayer
{
    public class KhenThuongKyLuatDAL
    {
        private string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        //load toàn bảng 
        public DataTable findAll()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM vv_Khenthuong_Kyluat", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("vv_Khenthuong_Kyluat"))
                        {
                            ad.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        //Thêm khen thưởng kỉ luật
        public bool themKhenThuong(string maQD, DateTime ngayLap, string loaiQuyetDinh, string maNV, string mucKhenThuong, string lyDo)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "themKhenThuong";
                    cmd.Parameters.AddWithValue("@MaQD", maQD);
                    cmd.Parameters.AddWithValue("@Ngaylap", ngayLap);
                    cmd.Parameters.AddWithValue("@Loaiquyetdinh", loaiQuyetDinh);
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    cmd.Parameters.AddWithValue("@Muckhenthuong", mucKhenThuong);
                    cmd.Parameters.AddWithValue("@Lydo", lyDo);
                    
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }


        public bool suaKhenThuong(string maQD, DateTime ngayLap, string loaiQuyetDinh, string maNV, string mucKhenThuong, string lyDo)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "suaKhenThuong";
                    cmd.Parameters.AddWithValue("@MaQD", maQD);
                    cmd.Parameters.AddWithValue("@Ngaylap", ngayLap);
                    cmd.Parameters.AddWithValue("@Loaiquyetdinh", loaiQuyetDinh);
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    cmd.Parameters.AddWithValue("@Muckhenthuong", mucKhenThuong);
                    cmd.Parameters.AddWithValue("@Lydo", lyDo);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }

        public bool xoaKhenThuong(string maQD)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "xoaKhenThuong";
                    cmd.Parameters.AddWithValue("@MaQD", maQD);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }
        public DataTable timKhenThuong(String maQD)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                String sql = "SELECT * FROM vv_Khenthuong_Kyluat WHERE [Mã SP] LIKE '" + maQD + "' ";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("vv_Khenthuong_Kyluat"))
                        {
                            ad.Fill(dt);
                            return dt;
                        }
                    }
                }
            }

        }
}
