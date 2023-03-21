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
    public class NhanVienDAL
    {
        private string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public DataTable findAll()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM vv_NhanVien where [Tình trạng] != N'Nghỉ làm'", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("vv_NhanVien"))
                        {
                            ad.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        public bool insert(string PK_sMaNV, string sTenNV, DateTime dNgaysinh, string sGioitinh, string sCCCD, string sDiachi, string sSDT, string sEmail, DateTime dNgayvaolam)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ThemHopDong";
                    cmd.Parameters.AddWithValue("@PK_sMaNV", PK_sMaNV);
                    cmd.Parameters.AddWithValue("@sTenNV", sTenNV);
                    cmd.Parameters.AddWithValue("@dNgaysinh", dNgaysinh);
                    cmd.Parameters.AddWithValue("@sGioitinh", sGioitinh);
                    cmd.Parameters.AddWithValue("@sCCCD", sCCCD);
                    cmd.Parameters.AddWithValue("@sDiachi", sDiachi);
                    cmd.Parameters.AddWithValue("@sSDT", sSDT);
                    cmd.Parameters.AddWithValue("@sEmail", sEmail);
                    cmd.Parameters.AddWithValue("@fLuongcb", dNgayvaolam);
                    cmd.Parameters.AddWithValue("@sTinhtrang", "Đang làm việc");
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }


        public bool update(string PK_sMaHD, DateTime dNgaykyhd, DateTime dNgayhethan, string FK_sMaNV, string FK_sMaCV, string FK_sMaPB, double fLuongcb)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_SuaHopDong";
                    cmd.Parameters.AddWithValue("@PK_sMaHD", PK_sMaHD);
                    cmd.Parameters.AddWithValue("@dNgaykyhd", dNgaykyhd);
                    cmd.Parameters.AddWithValue("@dNgayhethan", dNgayhethan);
                    cmd.Parameters.AddWithValue("@FK_sMaNV", FK_sMaNV);
                    cmd.Parameters.AddWithValue("@FK_sMaCV", FK_sMaCV);
                    cmd.Parameters.AddWithValue("@FK_sMaPB", FK_sMaPB);
                    cmd.Parameters.AddWithValue("@fLuongcb", fLuongcb);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        public bool deleteById(string PK_sMaNV)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_XoaNhanVien";
                    cmd.Parameters.AddWithValue("@PK_sMaNV", PK_sMaNV);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }

        public DataTable searchById(string PK_sMaNV)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                String sql = "SELECT * FROM vv_NhanVien " +
                    "WHERE [Mã nhân viên] LIKE N'%" + PK_sMaNV + "%' ";

                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("vv_NhanVien"))
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
