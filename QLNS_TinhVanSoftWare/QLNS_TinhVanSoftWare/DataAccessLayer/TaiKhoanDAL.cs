using System;
using System.Collections.Generic;

using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Text.RegularExpressions;

namespace QLNS_TinhVanSoftWare.DataAccessLayer
{
    public class TaiKhoanDAL
    {
        private string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public DataTable findAll()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from vv_TaiKhoan", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("vv_TaiKhoan"))
                        {
                            ad.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }
        public bool insert(string maTK, string tenTK, string matKhau, string tinhTrang, string maNV, string maQuyen)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ThemTaiKhoan";
                    cmd.Parameters.AddWithValue("@PK_sMaTK", maTK);
                    cmd.Parameters.AddWithValue("@s_Taikhoan", tenTK);
                    cmd.Parameters.AddWithValue("@s_Matkhau", matKhau);
                    cmd.Parameters.AddWithValue("@s_Tinhtrang", tinhTrang);
                    cmd.Parameters.AddWithValue("@FK_sMaNV", maNV);
                    cmd.Parameters.AddWithValue("@FK_sMaquyen", maQuyen);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        public bool updateTaiKhoan(string maTK, string tenTK, string matKhau, string tinhTrang, string maNV, string maQuyen)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_SuaTaiKhoan";
                    cmd.Parameters.AddWithValue("@PK_sMaTK", maTK);
                    cmd.Parameters.AddWithValue("@s_Taikhoan", tenTK);
                    cmd.Parameters.AddWithValue("@s_Matkhau", matKhau);
                    cmd.Parameters.AddWithValue("@s_Tinhtrang", tinhTrang);
                    cmd.Parameters.AddWithValue("@FK_sMaNV", maNV);
                    cmd.Parameters.AddWithValue("@FK_sMaquyen", maQuyen);
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }
        public bool deleteTaiKhoan(string MaTK)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_XoaTaiKhoan";
                    cmd.Parameters.AddWithValue("@PK_sMaTK", MaTK);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }
        public bool Check_MaTaiKhoan(string MaTaiKhoan)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand("select * from tbl_Taikhoan", cnn))
                {
                    cnn.Open();
                    using (SqlDataReader rd = command.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            if (rd["PK_sMaTK"].Equals(MaTaiKhoan))
                                return false;
                        }
                        rd.Close();
                    }
                    cnn.Close();
                }
            }
            return true;
        }
        public bool Check_TaiKhoan(string TenTK)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand("select * from tbl_Taikhoan", cnn))
                {
                    cnn.Open();
                    using (SqlDataReader rd = command.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            if (rd["s_Taikhoan"].Equals(TenTK))
                                return false;
                        }
                        rd.Close();
                    }
                    cnn.Close();
                }
            }
            return true;
        }
        public int login(string tenTK, string matKhau)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                String sql = "SELECT * FROM vv_TaiKhoanNhanVienQuyen WHERE [Tên tài khoản] = '" + tenTK + "'";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("vv_TaiKhoanNhanVienQuyen"))
                        {
                            ad.Fill(dt);
                            if (dt.Rows.Count == 0)
                                return 0; //Tên đăng nhập không tồn tại
                            else
                            {
                                foreach (DataRow dr in dt.Rows)
                                {
                                    if (dr["Mật khẩu"].Equals(matKhau))
                                    {
                                        Program.maTK = dr["Mã TK"].ToString();
                                        Program.maQuyen = dr["Mã Quyền"].ToString();
                                        Program.tenTK = dr["Tên tài khoản"].ToString();
                                        Program.tenNV = dr["Tên NV"].ToString();
                                        return 1; //Đúng mật khẩu và tên đăng nhập 
                                    }
                                    else
                                        return 2; //Đúng tên dăng nhập nhưng Sai mật khẩu 
                                }
                            }
                        }
                    }
                    return -1;
                }
            }
        }
        /*public bool CheckTrangThai(string TenTK)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "getTaiKhoanTheoTen";
                    cmd.Parameters.AddWithValue("@s_Taikhoan", TenTK);
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
            return false;
        }*/
        public bool changePassword(string maTK, string matKhau)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_DoiMatKhau";
                    cmd.Parameters.AddWithValue("@PK_sMaTK", maTK);
                    cmd.Parameters.AddWithValue("@s_Matkhau", matKhau);
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

    }
}
