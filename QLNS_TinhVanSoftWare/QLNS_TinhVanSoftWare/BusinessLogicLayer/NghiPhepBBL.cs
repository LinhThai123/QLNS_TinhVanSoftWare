using QLNS_TinhVanSoftWare.DataAccessLayer;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_TinhVanSoftWare.BusinessLogicLayer
{
    class NghiPhepBBL
    {
        private NghiPhepDAL _donXinNghiDAL;

        public NghiPhepBBL()
        {
            _donXinNghiDAL = new NghiPhepDAL();
        }

        public Boolean ThemDonXinNghi(string maDon, DateTime ngayLap, string loaiDon, DateTime ngayBatDau, DateTime ngayKetThuc, string maNV, string maCV, string maPB, string lyDo)
        {
            return _donXinNghiDAL.ThemDonXinNghi(maDon, ngayLap, loaiDon, ngayBatDau, ngayKetThuc, maNV, maCV, maPB, lyDo);
        }

        public DataTable LayDanhSachLoaiDon()
        {
            return _donXinNghiDAL.LayDanhSachLoaiDon();
        }
        public DataTable LayDanhSachMaNV()
        {
            return _donXinNghiDAL.LayDanhSachMaNV();
        }
        public DataTable LayDanhSachPhongBan()
        {
            return _donXinNghiDAL.LayDanhSachPhongBan();
        }
        public DataTable LayDanhSachChucVu()
        {
            return _donXinNghiDAL.LayDanhSachChucVu();
        }
        public DataTable LayDanhSachDonXinNghi()
        {
            return _donXinNghiDAL.LayDanhSachDonXinNghi();
        }
        public DataTable TimKiemDonXinNghi( string loaiDon, string maNV, string maCV, string maPB, string lyDo)
        {
            return _donXinNghiDAL.TimKiemDonXinNghi( loaiDon, maNV, maCV, maPB, lyDo);
        }

    }
}
