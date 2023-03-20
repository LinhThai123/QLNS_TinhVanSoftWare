using QLNS_TinhVanSoftWare.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_TinhVanSoftWare.BusinessLogicLayer
{
    class NghiPhepThoiViecBLL
    {
        private NghiPhepThoiViecDAL NghiPhepThoiViecDAL = new NghiPhepThoiViecDAL();
        public DataTable LayDanhSachLoaiDon()
        {
            return NghiPhepThoiViecDAL.LayDanhSachLoaiDon();
        }
        public DataTable LayDanhSachMaNV()
        {
            return NghiPhepThoiViecDAL.LayDanhSachMaNV();
        }
        public DataTable LayDanhSachPhongBan()
        {
            return NghiPhepThoiViecDAL.LayDanhSachPhongBan();
        }
    }
}
