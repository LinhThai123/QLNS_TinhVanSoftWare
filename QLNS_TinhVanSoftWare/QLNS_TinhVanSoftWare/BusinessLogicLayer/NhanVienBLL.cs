using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_TinhVanSoftWare.BusinessLogicLayer
{
    class NhanVienBLL
    {
        DataAccessLayer.NhanVienDAL nhanVienDAL = new DataAccessLayer.NhanVienDAL();
        public DataTable layDSNhanVien()
        {
            return nhanVienDAL.layDSNhanVien();
        }
    }
}
