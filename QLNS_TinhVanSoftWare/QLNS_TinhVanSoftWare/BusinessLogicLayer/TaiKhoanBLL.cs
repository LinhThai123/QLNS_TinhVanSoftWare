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

        public bool insert(string maTK, string tenTK, string matKhau, string tinhTrang, string maNV, string maQuyen)
        {
            return taiKhoanDAL.insert(maTK, tenTK, matKhau, tinhTrang, maNV, maQuyen); 
        }
        public bool updateTaiKhoan (string maTK, string tenTK, string matKhau, string tinhTrang, string maNV, string maQuyen)
        {
            return taiKhoanDAL.updateTaiKhoan(maTK, tenTK, matKhau, tinhTrang, maNV, maQuyen);
        }
        public bool deleteTaiKhoan(string MaTK)
        {
            return taiKhoanDAL.deleteTaiKhoan(MaTK); 
        }

        public bool Check_MaTaiKhoan( string MaTaiKhoan)
        {
            return taiKhoanDAL.Check_MaTaiKhoan(MaTaiKhoan); 
        }
        public bool Check_TaiKhoan (string TenTK)
        {
            return taiKhoanDAL.Check_TaiKhoan(TenTK);
        }
        public int login(string tenTK, string matKhau)
        {
            return taiKhoanDAL.login(tenTK, matKhau);
        }

        public bool changePassword(string maTK, string matKhau)
        {
            return taiKhoanDAL.changePassword(maTK, matKhau); 
        }
    }
}
