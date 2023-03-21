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
    class PhongBanDAL
    {

        private string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public DataTable findAll()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM vv_PhongBan", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("vv_PhongBan"))
                        {
                            ad.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        public bool insert(string sTenPB, string sMota, string sMota1)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ThemPhongBan";
                    cmd.Parameters.AddWithValue("@sTenPB", sTenPB);
                    cmd.Parameters.AddWithValue("@sMota", sMota);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }



        public bool update(string PK_sMaPB, string sTenPB, string sMota)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_SuaHopDong";
                    cmd.Parameters.AddWithValue("@PK_sMaPB", PK_sMaPB);
                    cmd.Parameters.AddWithValue("@sTenPB", sTenPB);
                    cmd.Parameters.AddWithValue("@sMota", sMota);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        public bool deleteById(string PK_sMaPB)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_XoaPhongBan";
                    cmd.Parameters.AddWithValue("@PK_sMaPB", PK_sMaPB);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }

        public DataTable searchById(string PK_sMaPB)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                String sql = "SELECT * FROM vv_PhongBan " +
                    "WHERE [Mã Phong Ban] LIKE N'%" + PK_sMaPB + "%' ";

                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("vv_PhongBan"))
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
