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
