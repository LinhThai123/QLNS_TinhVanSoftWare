﻿using System;
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

        public bool update(string tenTK, string matKhau, string tinhTrang, string maQuyen)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_SuaTaiKhoan";
                    cmd.Parameters.AddWithValue("@s_Taikhoan", tenTK);
                    cmd.Parameters.AddWithValue("@s_Matkhau", matKhau);
                    cmd.Parameters.AddWithValue("@s_Tinhtrang", tinhTrang);
                    cmd.Parameters.AddWithValue("@FK_sMaquyen", maQuyen);
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }
        public bool delete(string tenTK)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_XoaTaiKhoan";
                    cmd.Parameters.AddWithValue("@s_Taikhoan", tenTK);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }
        public bool check_TenTaiKhoan(string TenTK)
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

        public DataTable searchByName(string s_Taikhoan)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                String sql = "SELECT * FROM vv_TaiKhoan " +
                    "WHERE [Tên tài khoản] LIKE N'%" + s_Taikhoan + "%'";

                using (SqlCommand cmd = new SqlCommand(sql, cnn))
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

    }
}
