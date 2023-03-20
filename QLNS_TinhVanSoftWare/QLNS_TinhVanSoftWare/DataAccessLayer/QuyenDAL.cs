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
   
    class QuyenDAL
    {
        private string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public DataTable layDSQuyen()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from tbl_Quyen", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tbl_Quyen");
                        ad.Fill(tb);
                        return tb;
                    }
                }
            }
        }
    }
}
