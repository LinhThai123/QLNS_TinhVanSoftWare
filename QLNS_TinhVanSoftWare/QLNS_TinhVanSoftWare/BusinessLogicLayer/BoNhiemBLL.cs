using QLNS_TinhVanSoftWare.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_TinhVanSoftWare.BusinessLogicLayer
{
    public class BoNhiemBLL
    {
        BoNhiemDAL boNhiemDAL = new BoNhiemDAL();
        HopDongDAL hopDongDAL = new HopDongDAL();

        public DataTable findAll()
        {
            return boNhiemDAL.findAll();
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

        public bool insert(string PK_sMabonhiem, DateTime dNgaylap, DateTime dNgayhethan, string FK_sMaNV, string FK_sMaCV, string FK_sMaPB, double fLuongmoi, string sNoiDung)
        {
            return boNhiemDAL.insert(PK_sMabonhiem,dNgaylap, dNgayhethan, FK_sMaNV, FK_sMaCV, FK_sMaPB, fLuongmoi, sNoiDung);
        }

        public bool update(string PK_sMabonhiem, DateTime dNgaylap, DateTime dNgayhethan, string FK_sMaNV, string FK_sMaCV, string FK_sMaPB, double fLuongmoi, string sNoiDung)
        {
            return boNhiemDAL.update(PK_sMabonhiem, dNgaylap, dNgayhethan, FK_sMaNV, FK_sMaCV, FK_sMaPB, fLuongmoi, sNoiDung);
        }

        public bool deleteById(string PK_sMabonhiem)
        {
            return boNhiemDAL.deleteById(PK_sMabonhiem);
        }


        public DataTable searchById(String PK_sMabonhiem)
        {
            return boNhiemDAL.searchById(PK_sMabonhiem);
        }
    }
}
