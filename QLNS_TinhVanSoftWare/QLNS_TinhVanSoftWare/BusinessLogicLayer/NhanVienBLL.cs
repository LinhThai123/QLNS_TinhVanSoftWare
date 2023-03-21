using QLNS_TinhVanSoftWare.DataAccessLayer;
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
        NhanVienDAL nhanVienDAL = new NhanVienDAL();

        public DataTable findAll()
        {
            return nhanVienDAL.findAll();
        }
        public bool check_ID(string PK_sMaNV)
        {
            return nhanVienDAL.check_ID(PK_sMaNV);
        }

        public bool IsValidVietNamPhoneNumber(string sSDT)
        {
            return nhanVienDAL.IsValidVietNamPhoneNumber(sSDT);
        }

        public bool insert(string PK_sMaNV, string sTenNV, DateTime dNgaysinh, string sGioitinh, string sCCCD, string sDiachi, string sSDT, string sEmail, DateTime dNgayvaolam)
        {
            return nhanVienDAL.insert(PK_sMaNV, sTenNV, dNgaysinh, sGioitinh, sCCCD, sDiachi, sSDT, sEmail, dNgayvaolam);
        }

        public bool update(string PK_sMaNV, string sTenNV, DateTime dNgaysinh, string sGioitinh, string sCCCD, string sDiachi, string sSDT, string sEmail, DateTime dNgayvaolam)
        {
            return nhanVienDAL.update(PK_sMaNV, sTenNV, dNgaysinh, sGioitinh, sCCCD, sDiachi, sSDT, sEmail, dNgayvaolam);
        }

        public bool deleteById(string PK_sMaNV)
        {
            return nhanVienDAL.deleteById(PK_sMaNV);
        }


        public DataTable searchById(String PK_sMaNV)
        {
            return nhanVienDAL.searchById(PK_sMaNV);
        }
    }
}
