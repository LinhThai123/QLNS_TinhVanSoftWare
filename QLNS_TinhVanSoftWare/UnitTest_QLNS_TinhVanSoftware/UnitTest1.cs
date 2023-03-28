using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLNS_TinhVanSoftWare.BusinessLogicLayer;
using QLNS_TinhVanSoftWare.DataAccessLayer;
using System;

namespace UnitTest_QLNS_TinhVanSoftware
{
    [TestClass]
    public class UnitTest1
    {
        //NhanVienDAL nhanVienDAL = new NhanVienDAL();
        [TestMethod]
        public void TestMethod_Update_NhanVien()
        {
            NhanVienBLL nhanVienBLL = new NhanVienBLL();
            //bool a = nhanVienBLL.check_ID("NV00001");
            bool v = nhanVienBLL.update("NV00001", "sTenNV", DateTime.Parse("01/01/2001"), "sGioitinh", "sCCCD", "sDiachi", "sSDT", "sEmail", DateTime.Parse("01/01/2001"));
           
            Assert.IsTrue(v);
        }
    }
}
