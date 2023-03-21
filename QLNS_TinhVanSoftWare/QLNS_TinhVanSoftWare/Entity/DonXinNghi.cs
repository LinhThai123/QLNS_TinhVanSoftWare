using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_TinhVanSoftWare.Entity
{
    class DonXinNghi
    {
        public string PK_sMaDon { get; set; }
        public DateTime dNgayLap { get; set; }
        public string sLoaiDon { get; set; }
        public DateTime dNgayBatDau { get; set; }
        public DateTime dNgayKetThuc { get; set; }
        public string FK_sMaNV { get; set; }
        public string FK_sMaCV { get; set; }
        public string FK_sMaPB { get; set; }
        public string sLyDo { get; set; }
    }
}