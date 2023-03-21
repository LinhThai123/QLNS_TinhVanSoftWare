using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_TinhVanSoftWare.BusinessLogicLayer
{
    class ChucVuBLL
    {

        DataAccessLayer.ChucVuDAL chucVuDAL = new DataAccessLayer.ChucVuDAL();

        public DataTable findAll()
        {
            return chucVuDAL.findAll();
        }

        public bool insert(string PK_sMaCV, string sTenCV, string fHSL)
        {
            return chucVuDAL.insert( PK_sMaCV,  sTenCV,  fHSL);
        }

        public bool update(string PK_sMaCV, string sTenCV, string fHSL)
        {
            return chucVuDAL.update(PK_sMaCV, sTenCV, fHSL);
        }

        public bool deleteById(string PK_sMaCV)
        {
            return chucVuDAL.deleteById(PK_sMaCV);
        }


        public DataTable searchById(String PK_sMaCV)
        {
            return chucVuDAL.searchById(PK_sMaCV);
        }

        internal void insert(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        internal void update(string v1, string v2)
        {
            throw new NotImplementedException();
        }
    }
}
