using System;
using System.Collections.Generic;

using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

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
        public bool insert(string maTK, string tenTK, string matKhau, string tinhTrang, string maQuyen , string maNV)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "insertAccount";
                    cmd.Parameters.AddWithValue("@MaTK", maTK);
                    cmd.Parameters.AddWithValue("@TaiKhoan", tenTK);
                    cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                    cmd.Parameters.AddWithValue("@TinhTrang", tinhTrang);
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    cmd.Parameters.AddWithValue("@MaQuyen", maQuyen);
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
    }
}
