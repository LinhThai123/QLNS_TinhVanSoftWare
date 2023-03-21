using QLNS_TinhVanSoftWare.DataAccessLayer;
using QLNS_TinhVanSoftWare.Entity;
using System;
using System.Collections.Generic;
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

        public bool ThemDonXinNghi(DonXinNghi donXinNghi)
        {
            return _donXinNghiDAL.ThemDonXinNghi(donXinNghi);
        }
        public bool SuaDonXinNghi(DonXinNghi donXinNghi)
        {
            return _donXinNghiDAL.SuaDonXinNghi(donXinNghi);
        }
        public bool XoaDonXinNghi(string PK_sMaDon)
        {
            return _donXinNghiDAL.XoaDonXinNghi(PK_sMaDon);
        }

        public List<DonXinNghi> LayDanhSachDonXinNghi()
        {
            return _donXinNghiDAL.LayDanhSachDonXinNghi();
        }
        public List<DonXinNghi> TimKiemDonXinNghi( string loaiDon, string maNV, string maCV, string maPB, string lyDo)
        {
            return _donXinNghiDAL.TimKiemDonXinNghi( loaiDon, maNV, maCV, maPB, lyDo);
        }
    }
}
