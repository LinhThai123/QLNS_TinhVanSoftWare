using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_TinhVanSoftWare.BusinessLogicLayer
{
    class KhenThuongKyLuatBLL
    {
        KhenThuongKyLuatBLL khenThuongKyLuatDAL = new KhenThuongKyLuatBLL();

        public DataTable findAll()
        {
            return khenThuongKyLuatDAL.findAll();
        }

        public bool themKhenThuong(string maQD, DateTime ngayLap, string loaiQuyetDinh, string maNV, string mucKhenThuong, string lyDo)
        {
            return khenThuongKyLuatDAL.themKhenThuong(maQD, ngayLap, loaiQuyetDinh, maNV, mucKhenThuong, lyDo);
        }


        public bool suaKhenThuong(string maQD, DateTime ngayLap, string loaiQuyetDinh, string maNV, string mucKhenThuong, string lyDo)
        {
            return khenThuongKyLuatDAL.suaKhenThuong(maQD, ngayLap, loaiQuyetDinh, maNV, mucKhenThuong, lyDo);
        }

        public bool xoaKhenThuong(string maQD)
        {
            return khenThuongKyLuatDAL.xoaKhenThuong(maQD);
        }

        public DataTable timKhenThuong(String maQD)
        {
            return khenThuongKyLuatDAL.timKhenThuong(maQD);
        }
    }
}
