using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_TinhVanSoftWare.BusinessLogicLayer
{
    class BienBanDanhGiaBLL
    {
        BienBanDanhGiaBLL bienBanDanhGiaDAL = new BienBanDanhGiaBLL();

        public DataTable findAll()
        {
            return bienBanDanhGiaDAL.findAll();
        }

        public bool themBienBan(string maBienBan, DateTime ngayLap, string maNV, string maCV, string maPB, string noidungDG)
        {
            return bienBanDanhGiaDAL.themBienBan(maBienBan, ngayLap, maNV, maCV, maPB, noidungDG);
        }


        public bool suaBienBan(string maBienBan, DateTime ngayLap, string maNV, string maCV, string maPB, string noidungDG)
        {
            return bienBanDanhGiaDAL.suaBienBan(maBienBan, ngayLap, maNV, maCV, maPB, noidungDG);
        }

        public bool xoaBienBan(string maBienBan)
        {
            return bienBanDanhGiaDAL.xoaBienBan(maBienBan);
        }

        public DataTable timBienBan(string maBienBan)
        {
            return bienBanDanhGiaDAL.timBienBan(maBienBan);
        }
    }
}
