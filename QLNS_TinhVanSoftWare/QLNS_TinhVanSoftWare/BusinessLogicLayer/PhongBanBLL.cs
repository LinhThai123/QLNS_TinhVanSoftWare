﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_TinhVanSoftWare.BusinessLogicLayer
{
    public class PhongBanBLL
    {

        DataAccessLayer.PhongBanDAL phongBanDAL = new DataAccessLayer.PhongBanDAL();

        public DataTable findAll()
        {
            return phongBanDAL.findAll();
        }

        public bool insert(string PK_sMaPB, string sTenPB, string sMota)
        {
            return phongBanDAL.insert(PK_sMaPB, sTenPB, sMota);
        }

        public bool update(string PK_sMaPB, string sTenPB, string sMota)
        {
            return phongBanDAL.update(PK_sMaPB, sTenPB, sMota);
        }

        public bool deleteById(string PK_sMaPB)
        {
            return phongBanDAL.deleteById(PK_sMaPB);
        }


        public DataTable searchById(String PK_sMaPB)
        {
            return phongBanDAL.searchById(PK_sMaPB);
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