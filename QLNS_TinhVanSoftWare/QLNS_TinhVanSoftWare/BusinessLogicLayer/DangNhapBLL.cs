using QLNS_TinhVanSoftWare.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_TinhVanSoftWare.BusinessLogicLayer
{
    public class DangNhapBLL
    {
        DangNhapDAL dangNhapDAL = new DangNhapDAL();

        public int login(string tenTK, string matKhau)
        {
            using (DataTable dt = dangNhapDAL.login(tenTK))
            {
                if (dt.Rows.Count == 0)
                    return 0; //Tên đăng nhập không tồn tại
                else
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (String.Equals(dr["s_Matkhau"].ToString(), matKhau, StringComparison.InvariantCultureIgnoreCase))
                        {
                            if (check_TrangThai(tenTK))
                            {
                                Program.maQuyen = dr["FK_sMaquyen"].ToString();
                                Program.tenTK = dr["s_Taikhoan"].ToString();
                                Program.mK = dr["s_Matkhau"].ToString();
                                return 1; //Đúng mật khẩu và tên đăng nhập
                            }
                            else
                                return -2; // Tài khoản đang bị khóa
                           
                        }
                        else
                            return 2; //Đúng tên dăng nhập nhưng Sai mật khẩu 
                    }
                }
            }
            return -1;
        }

        public bool check_TrangThai(string s_Taikhoan)
        {
            return dangNhapDAL.check_TrangThai(s_Taikhoan);
        }
    }
}
