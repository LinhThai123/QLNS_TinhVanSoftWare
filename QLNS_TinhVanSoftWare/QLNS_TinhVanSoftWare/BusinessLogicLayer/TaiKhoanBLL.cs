using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_TinhVanSoftWare.BusinessLogicLayer
{
    class TaiKhoanBLL
    {
        DataAccessLayer.TaiKhoanDAL taiKhoanDAL = new DataAccessLayer.TaiKhoanDAL();

        public DataTable findAll()
        {
            return taiKhoanDAL.findAll();
        }

        public int insert(string maTK, string tenTK, string matKhau, string tinhTrang, string maNV, string maQuyen)
        {
            if (tenTK != "" && matKhau != "" && maNV != "")
            {
                if (Check_TenTaiKhoan(tenTK))
                {
                    if (matKhau.Length >= 6)
                    {
                        taiKhoanDAL.insert(maTK, tenTK, matKhau, tinhTrang, maNV, maQuyen);
                        return 1;
                    }
                    else return -3;
                }
                else return -2;
            }
            else return -1;
        }
        public int update(string tenTK, string matKhau, string tinhTrang, string maQuyen)
        {
            if (tenTK != "" && matKhau != "")
            {
                if (!Check_TenTaiKhoan(tenTK))
                {
                    if (matKhau.Length >= 6)
                    {
                        taiKhoanDAL.update(tenTK, matKhau, tinhTrang, maQuyen);
                        return 1;
                    }
                    else return -3;
                }
                else return -2;
            }
            else return -1;
        }
        public bool delete(string tenTK)
        {
            return taiKhoanDAL.delete(tenTK);
        }

        public bool Check_TenTaiKhoan(string TenTK)
        {
            return taiKhoanDAL.check_TenTaiKhoan(TenTK);
        }

        public DataTable searchByName(string s_Taikhoan)
        {
            return taiKhoanDAL.searchByName(s_Taikhoan);
        }

    }
}
