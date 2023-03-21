using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                    cmd.CommandText = "sp_ThemNhanVien";
                    cmd.Parameters.AddWithValue("@PK_sMaNV", PK_sMaNV);
                    cmd.Parameters.AddWithValue("@sTenNV", sTenNV);
                    cmd.Parameters.AddWithValue("@dNgaysinh", dNgaysinh);
                    cmd.Parameters.AddWithValue("@sGioitinh", sGioitinh);
                    cmd.Parameters.AddWithValue("@sCCCD", sCCCD);
                    cmd.Parameters.AddWithValue("@sDiachi", sDiachi);
                    cmd.Parameters.AddWithValue("@sSDT", sSDT);
                    cmd.Parameters.AddWithValue("@sEmail", sEmail);
                    cmd.Parameters.AddWithValue("@dNgayvaolam", dNgayvaolam);
                    cmd.Parameters.AddWithValue("@sTinhtrang", "Đang làm việc");
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        public bool check_ID(string PK_sMaNV)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand("select * from tbl_Nhanvien", cnn))
                {
                    cnn.Open();
                    using (SqlDataReader rd = command.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            if (rd["PK_sMaNV"].Equals(PK_sMaNV))
                                return false;
                        }
                        rd.Close();
                    }
                    cnn.Close();
                }
            }
            return true;
        }

        public bool update(string PK_sMaNV, string sTenNV, DateTime dNgaysinh, string sGioitinh, string sCCCD, string sDiachi, string sSDT, string sEmail, DateTime dNgayvaolam)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_SuaNhanVien";
                    cmd.Parameters.AddWithValue("@PK_sMaNV", PK_sMaNV);
                    cmd.Parameters.AddWithValue("@sTenNV", sTenNV);
                    cmd.Parameters.AddWithValue("@dNgaysinh", dNgaysinh);
                    cmd.Parameters.AddWithValue("@sGioitinh", sGioitinh);
                    cmd.Parameters.AddWithValue("@sCCCD", sCCCD);
                    cmd.Parameters.AddWithValue("@sDiachi", sDiachi);
                    cmd.Parameters.AddWithValue("@sSDT", sSDT);
                    cmd.Parameters.AddWithValue("@sEmail", sEmail);
                    cmd.Parameters.AddWithValue("@dNgayvaolam", dNgayvaolam);
                    cmd.Parameters.AddWithValue("@sTinhtrang", "Đang làm việc");
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

        public DataTable searchByIdOrName(string PK_sMaNV, string sTenNV)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                String sql = "SELECT * FROM vv_NhanVien " +
                    "WHERE [Họ tên] LIKE N'%" + sTenNV + "%' and [Mã nhân viên] LIKE N'%" + PK_sMaNV + "%' ";

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
        public bool IsValidVietNamPhoneNumber(string phoneNum)
        {
            if (string.IsNullOrEmpty(phoneNum))
                return false;
            string sMailPattern = @"^((01(\d){8})|(03(\d){8})|(07(\d){8})|(08(\d){8})|(09(\d){8}))$";
            return Regex.IsMatch(phoneNum.Trim(), sMailPattern);
        }

        public DataTable layDSNhanVien()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from tbl_NhanVien", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tbl_NhanVien");
                        ad.Fill(tb);
                        return tb;
                    }
                }
            }
        }
    }
}
