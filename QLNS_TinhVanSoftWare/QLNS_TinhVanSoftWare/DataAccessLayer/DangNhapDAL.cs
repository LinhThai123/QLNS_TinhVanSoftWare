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
    public class DangNhapDAL
    {
        private string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public DataTable login(string taiKhoan)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                String sql = "SELECT * FROM tbl_Taikhoan, tbl_Nhanvien WHERE tbl_Taikhoan.FK_sMaNV = tbl_Nhanvien.PK_sMaNV and tbl_Taikhoan.s_Taikhoan = '" + taiKhoan + "'";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("tbl_Taikhoan"))
                        {
                            ad.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        public bool check_TrangThai(string s_Taikhoan)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand("select * from tbl_Taikhoan where s_Taikhoan = '" + s_Taikhoan +"'", cnn))
                {
                    cnn.Open();
                    using (SqlDataReader rd = command.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            if (rd["s_Tinhtrang"].Equals("Khóa"))
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
