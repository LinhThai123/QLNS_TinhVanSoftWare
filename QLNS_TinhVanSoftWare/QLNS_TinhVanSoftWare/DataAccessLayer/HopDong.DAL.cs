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
    public class HopDongDAL
    {
        private string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public DataTable findAll()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM vv_HopDong", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("vv_HopDong"))
                        {
                            ad.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        public bool insert(DateTime dNgaykyhd, DateTime dNgayhethan, string FK_sMaNV, string FK_sMaCV, string FK_sMaPB, double fLuongcb)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ThemHopDong";
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

        public DataTable getNhanVien()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM vv_getNhanVien", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("vv_getNhanVien");
                        ad.Fill(tb);
                        return tb;
                    }
                }
            }
        }

        public DataTable getChucVu()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Chucvu", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tbl_Chucvu");
                        ad.Fill(tb);
                        return tb;
                    }
                }
            }
        }

        public DataTable getPhongBan()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Phongban", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tbl_Phongban");
                        ad.Fill(tb);
                        return tb;
                    }
                }
            }
        }

        public bool update(string PK_sMaKH, string sTenKH, string sSDT)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_SuaTTKhachHang";
                    cmd.Parameters.AddWithValue("@PK_sMaKH", PK_sMaKH);
                    cmd.Parameters.AddWithValue("@sTenKH", sTenKH);
                    cmd.Parameters.AddWithValue("@sSDT", sSDT);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }

        public bool deleteById(string PK_sMaHD)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_XoaHopDong";
                    cmd.Parameters.AddWithValue("@PK_sMaHD", PK_sMaHD);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }

        public DataTable searchById(string PK_sMaKH)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                String sql = "SELECT * FROM vv_Khachhang " +
                    "WHERE [Mã KH] LIKE N'%" + PK_sMaKH + "%' ";

                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("vv_Khachhang"))
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