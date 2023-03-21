using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_TinhVanSoftWare.BusinessLogicLayer
{
    public class HopDongBLL
    {
        DataAccessLayer.HopDongDAL hopDongDAL = new DataAccessLayer.HopDongDAL();

        public DataTable findAll()
        {
            return hopDongDAL.findAll();
        }

        public DataTable getNhanVien()
        {
            return hopDongDAL.getNhanVien();
        }

        public DataTable getPhongBan()
        {
            return hopDongDAL.getPhongBan();
        }

        public DataTable getChucVu()
        {
            return hopDongDAL.getChucVu();
        }

        public bool insert(DateTime dNgaykyhd, DateTime dNgayhethan, string FK_sMaNV, string FK_sMaCV, string FK_sMaPB, double fLuongcb)
        {
            return hopDongDAL.insert(dNgaykyhd, dNgayhethan, FK_sMaNV, FK_sMaCV, FK_sMaPB, fLuongcb);
        }

        public bool update(string PK_sMaHD, DateTime dNgaykyhd, DateTime dNgayhethan, string FK_sMaNV, string FK_sMaCV, string FK_sMaPB, double fLuongcb)
        {
            return hopDongDAL.update( PK_sMaHD,  dNgaykyhd,  dNgayhethan,  FK_sMaNV,  FK_sMaCV,  FK_sMaPB,  fLuongcb);
        }

        public bool chucVu_PhongBan(string PK_sMaNV, string FK_sMaCV, string FK_sMaPB, double fLuongcb)
        {
            return hopDongDAL.chucVu_PhongBan(PK_sMaNV, FK_sMaCV, FK_sMaPB, fLuongcb);
        }

        public bool deleteById(string PK_sMaKH)
        {
            return hopDongDAL.deleteById(PK_sMaKH);
        }


        public DataTable searchById(String PK_sMaKH)
        {
            return hopDongDAL.searchById(PK_sMaKH);
        }
    }
}