using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace QLNS_TinhVanSoftWare.PresentationLayer
{
    public partial class frmBaoCaoTaiChinh : Form
    {
        public frmBaoCaoTaiChinh()
        {
            InitializeComponent();
        }

        private void frmBaoCaoTaiChinh_Load(object sender, EventArgs e)
        {

            ReportDocument report = new ReportDocument();
            report.Load(@"E:\NhapMon\QLNS_TinhVanSoftWare\QLNS_TinhVanSoftWare\QLNS_TinhVanSoftWare\PresentationLayer\rpBaoCaoTaiChinh.rpt");
            rpBaoCaoTaiChinh.ReportSource = report;
            rpBaoCaoTaiChinh.Refresh();
        }
    }
}
