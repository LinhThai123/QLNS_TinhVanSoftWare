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
    public class ChucVuDAL
    {

        private string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public DataTable findAll()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM vv_Chucvu", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("vv_Chucvu"))
                        {
                            ad.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        public bool insert(string sTenCV, string fHSL, string sMota)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ThemChucVu";
                    cmd.Parameters.AddWithValue("@sTenCV", sTenCV);
                    cmd.Parameters.AddWithValue("@fHSL", fHSL);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }



        public bool update(string PK_sMaCV, string sTenCV, string fHSL)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_SuaChucVu";
                    cmd.Parameters.AddWithValue("@PK_sMaCV", PK_sMaCV);
                    cmd.Parameters.AddWithValue("@sTenCV", sTenCV);
                    cmd.Parameters.AddWithValue("@fHSL", fHSL);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        public bool deleteById(string PK_sMaCV)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_XoaChucVu";
                    cmd.Parameters.AddWithValue("@PK_sMaCV", PK_sMaCV);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }

        public DataTable searchById(string PK_sMaCV)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                String sql = "SELECT * FROM vv_Chucvu " +
                    "WHERE [Mã Chức vụ] LIKE N'%" + PK_sMaCV + "%' ";

                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("vv_Chucvu"))
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
