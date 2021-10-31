using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.DanhMuc
{
    public partial class frmBanHang : Form
    {
        public static string userName = "";
        public frmBanHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn đăng xuất không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Close();
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout fabout = new frmAbout();
            fabout.ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            frmAccountProfile facount = new frmAccountProfile();
            this.Hide();
            facount.ShowDialog();
            this.Show();

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin fAdmin = new frmAdmin();
            this.Hide();
            fAdmin.ShowDialog();
            this.Show();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            lblDangNhap.Text = "Xin chào : " + userName;
        }
    }
}
