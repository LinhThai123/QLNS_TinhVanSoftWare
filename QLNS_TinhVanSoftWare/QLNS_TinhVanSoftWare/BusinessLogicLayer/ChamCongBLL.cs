using QLNS_TinhVanSoftWare.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_TinhVanSoftWare.BusinessLogicLayer
{
    class ChamCongBLL
    {
        private ChamCongDAL chamCongDAL = new ChamCongDAL();
        public DataTable LayDanhSachMaNhanVien()
        {
            return chamCongDAL.LayDanhSachMaNhanVien();
        }

    }
}
