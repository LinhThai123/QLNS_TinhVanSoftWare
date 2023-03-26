using QLNS_TinhVanSoftWare.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_TinhVanSoftWare.BusinessLogicLayer
{
    class DoiMatKhauBLL
    {
        DoiMatKhauDAL doiMatKhauDAL = new DoiMatKhauDAL();
        public bool changePassword(string tenTK, string matKhau)
        {
            return doiMatKhauDAL.changePassword(tenTK, matKhau);
        }
    }
}
