using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_TinhVanSoftWare.PresentationLayer
{
    public partial class frmBoNhiem : Form
    {
        BusinessLogicLayer.HopDongBLL hopDongBLL = new BusinessLogicLayer.HopDongBLL();
        BusinessLogicLayer.BoNhiemBLL boNhiemBLL = new BusinessLogicLayer.BoNhiemBLL();
        public frmBoNhiem()
        {
            InitializeComponent();
        }

        private void findAll()
        {
            DataTable t = hopDongBLL.findAll();
            t.Columns.Add("STT");
            for (int i = 0; i < t.Rows.Count; i++)
                t.Rows[i]["STT"] = i + 1;
            dgvBoNhiem.DataSource = t;
            dgvBoNhiem.Columns["STT"].DisplayIndex = 0;
        }

        private void getNhanVien()
        {
            DataTable t = hopDongBLL.getNhanVien();
            DataView view = new DataView(t);
            view.Sort = "PK_sMaNV";
            cmbNhanVien.DataSource = view;
            cmbNhanVien.DisplayMember = "nhanVien";
            cmbNhanVien.ValueMember = "PK_sMaNV";
        }

        private void getPhongBan()
        {
            DataTable t = hopDongBLL.getPhongBan();
            DataView view = new DataView(t);
            view.Sort = "PK_sMaPB";
            cmbPhongBan.DataSource = view;
            cmbPhongBan.DisplayMember = "sTenPB";
            cmbPhongBan.ValueMember = "PK_sMaPB";
        }

        private void getChucVu()
        {
            DataTable t = hopDongBLL.getChucVu();
            DataView view = new DataView(t);
            view.Sort = "PK_sMaCV";
            cmbChucVu.DataSource = view;
            cmbChucVu.DisplayMember = "sTenCV";
            cmbChucVu.ValueMember = "PK_sMaCV";
        }

        private void dgvBoNhiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }

        private void frmBoNhiem_Load(object sender, EventArgs e)
        {
            findAll();
            getNhanVien();
            getPhongBan();
            getChucVu();
            cmbNhanVien.Text = "";
            cmbChucVu.Text = "";
            cmbPhongBan.Text = "";
            nmrLuongMoi.Value = 10000;
        }
    }
}
