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
        DataAccessLayer.BoNhiemDAL boNhiemDAL = new DataAccessLayer.BoNhiemDAL();

        public DataTable findAll()
        {
            return boNhiemDAL.findAll();
        }

        public DataTable getNhanVien()
        {
            return boNhiemDAL.getNhanVien();
        }

        public DataTable getPhongBan()
        {
            return boNhiemDAL.getPhongBan();
        }

        public DataTable getChucVu()
        {
            return boNhiemDAL.getChucVu();
        }

        public bool insert(DateTime dNgaykyhd, DateTime dNgayhethan, string FK_sMaNV, string FK_sMaCV, string FK_sMaPB, double fLuongcb)
        {
            return boNhiemDAL.insert(dNgaykyhd, dNgayhethan, FK_sMaNV, FK_sMaCV, FK_sMaPB, fLuongcb);
        }

        public bool update(string PK_sMaHD, DateTime dNgaykyhd, DateTime dNgayhethan, string FK_sMaNV, string FK_sMaCV, string FK_sMaPB, double fLuongcb)
        {
            return boNhiemDAL.update(PK_sMaHD, dNgaykyhd, dNgayhethan, FK_sMaNV, FK_sMaCV, FK_sMaPB, fLuongcb);
        }

        public bool deleteById(string PK_sMaKH)
        {
            return boNhiemDAL.deleteById(PK_sMaKH);
        }


        public DataTable searchById(String PK_sMaKH)
        {
            return boNhiemDAL.searchById(PK_sMaKH);
        }
    }
}
