using QLNS_TinhVanSoftWare.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_TinhVanSoftWare.PresentationLayer
{
    public partial class frmPhongBan : Form
    {
        PhongBanBLL phongBanBLL = new PhongBanBLL();
        public frmPhongBan()
        {
            InitializeComponent();
        }
        private void findAll()
        {
            DataTable t = phongBanBLL.findAll();
            t.Columns.Add("STT");
            for (int i = 0; i < t.Rows.Count; i++)
                t.Rows[i]["STT"] = i + 1;
            dgvPhongban.DataSource = t;
            dgvPhongban.Columns["STT"].DisplayIndex = 0;
        }
        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            findAll();
            cmbTenPB.Text = "";
            cmbMota.Text = "";

        }
        

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            if (cmbTenPB.Text.Length == 0 && cmbMota.Text != "" )
            {
                phongBanBLL.insert( cmbTenPB.Text.ToString(), cmbMota.Text.ToString());
                frmPhongBan_Load(sender, e);
                MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Vui lòng nhập tất cả các trường dữ liệu ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmPhongBan_Load(sender, e);
        }

        private void dgvPhongban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbTenPB.Text = dgvPhongban.CurrentRow.Cells[3].Value.ToString() + " - " + dgvPhongban.CurrentRow.Cells[4].Value.ToString();
            cmbMota.Text = dgvPhongban.CurrentRow.Cells[5].Value.ToString();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string b = cmbTenPB.Text;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (phongBanBLL.deleteById(b))
                {
                    btnLamMoi_Click(sender, e);
                    frmPhongBan_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbTenPB.Text != "" && cmbMota.Text != "")
            {
                phongBanBLL.update(cmbTenPB.Text.ToString(), cmbMota.Text.ToString());

                frmPhongBan_Load(sender, e);
                MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Vui lòng nhập tất cả các trường dữ liệu ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        private void loadData(DataTable dsTimkiem)
        {
            dgvPhongban.DataSource = dsTimkiem;
        }
        private void btnSeach_Click(object sender, EventArgs e)
        {
            loadData(phongBanBLL.searchById(cmbTenPB.Text));
        }








        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PhongBan_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point(
                this.ClientSize.Width / 2 - panel1.Size.Width / 2,
                this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;

            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width,
            panel1.Height, 30, 30));
        }
    }
}
