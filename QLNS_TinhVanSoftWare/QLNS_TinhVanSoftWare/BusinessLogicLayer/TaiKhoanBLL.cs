using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_TinhVanSoftWare.BusinessLogicLayer
{
    class TaiKhoanBLL
    {
        DataAccessLayer.TaiKhoanDAL TaiKhoanDAL = new DataAccessLayer.TaiKhoanDAL();

        public bool insert(string maTK, string tenTK, string matKhau,string tinhTrang, string maNV, string maQuyen)
        {
            return TaiKhoanDAL.insert(maTK, tenTK, matKhau, tinhTrang, maNV, maQuyen); 
        }
        public bool Check_MaTaiKhoan(string constr, string MaTaiKhoan)
        {
            return TaiKhoanDAL.Check_MaTaiKhoan(constr, MaTaiKhoan); 
        }

    }
}
