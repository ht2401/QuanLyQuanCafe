using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{

    public partial class frmLogin : Form
    {
        Module.DataAcess dtBase = new Module.DataAcess();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có thực sự muốn thoát không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                Close();
            }    
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtAccount.Text.Trim() == "" || txtPassWord.Text.Trim() == "")
            {
                MessageBox.Show("Vui Lòng nhập tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (txtPassWord.Text.Trim() == "")
                {
                    txtPassWord.Focus();
                }    
                if(txtAccount.Text.Trim() == "")
                {
                    txtAccount.Focus();
                }    
                return;
            } 
            
            DataTable dtAccount = dtBase.DataReader("Select * from tblAccount where UserName = '"+ txtAccount.Text +"' and PassWord = '"+ txtPassWord.Text +"' ");
            if(dtAccount.Rows.Count > 0)
            {
                string displayname = txtAccount.Text;
                DanhMuc.frmBanHang f = new DanhMuc.frmBanHang();
                DanhMuc.frmBanHang.userName = displayname;
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác vui lòng nhập lại !", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAccount.Text = "";
                txtPassWord.Text = "";
                txtAccount.Focus();
            }    
           
        }
    }
}
