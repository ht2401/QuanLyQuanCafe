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
    public partial class frmAdmin : Form
    {
        public static string virtual_account = "";
        Module.DataAcess dtBase = new Module.DataAcess();
        public frmAdmin()
        {
            InitializeComponent();
            LoadAccount();
        }

        /*-----------------Phần Account-----------------*/
        void LoadAccount()
        {
            dgvAccount.DataSource = dtBase.DataReader("select * from tblAccount");
            dgvAccount.Columns[0].HeaderText = "Tên đăng nhập";
            dgvAccount.Columns[1].HeaderText = "Tên hiển thị";
            dgvAccount.Columns[2].HeaderText = "Mật khẩu";
            dgvAccount.Columns[3].HeaderText = "Quyền truy cập";
            txtNameAc.Text = "";
            txtNameShow.Text = "";
            cboType.Text = "";
            txtFindAcc.Text = "";
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNameAc.Text = dgvAccount.CurrentRow.Cells[0].Value.ToString();
                txtNameShow.Text = dgvAccount.CurrentRow.Cells[1].Value.ToString();
                if (int.Parse(dgvAccount.CurrentRow.Cells[3].Value.ToString()) == 1)
                {
                    cboType.Text = "Quản lý";
                }
                else
                {
                    cboType.Text = "Nhân viên";
                }    
            }
            catch
            {

            }
        }

        private void btnAddAc_Click(object sender, EventArgs e)
        {
            //Kiểm tra nhập dữ liệu
            if (txtNameAc.Text.Trim() == "" || txtNameShow.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                txtNameAc.Focus();
                return;
            }

            //kiểm tra trường hợp trùng mã
            DataTable dtAcc = dtBase.DataReader("Select * from tblAccount where UserName = '" + txtNameAc.Text + "'");
            if(dtAcc.Rows.Count > 0)
            {
                MessageBox.Show("Đã tồn tài khoản vui lòng nhập tài khoản khác !");
                txtNameAc.Text = "";
                txtNamefood.Focus();
                return;
            }

            //...
            string typeAcc = "";
            if (cboType.Text == "Quản lý")
            {
                typeAcc = "1";
            }
            if(cboType.Text == "Nhân viên")
            {
                typeAcc = "0";
            }    
            dtBase.UpdateData("insert into tblAccount values(N'"+txtNameAc.Text+"', N'"+txtNameShow.Text+"', '1', N'"+typeAcc+"')");
            frmSetPassWord formSetPass = new frmSetPassWord();
            MessageBox.Show(txtNameAc.Text);
            frmSetPassWord.virtual_account = txtNameAc.Text;
            formSetPass.ShowDialog();
            LoadAccount();
        }

        private void btnFixAc_Click(object sender, EventArgs e)
        {
            string typeAcc = "";
            if (cboType.Text == "Quản lý")
            {
                typeAcc = "1";
            }
            if (cboType.Text == "Nhân viên")
            {
                typeAcc = "0";
            }
            dtBase.UpdateData("update tblAccount set DisplayName = '" + txtNameAc.Text + "', Type = '" + typeAcc + "' where UserName = '"+txtNameAc.Text+"'");
        }
        private void btnDeleteAc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa tài khoản" + txtNameAc.Text + " không ?", "Thông báo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtBase.UpdateData("Delete from tblAccount where UserName = '" + txtNameAc.Text + "'");
                LoadAccount();
            }
        }

        private void btnViewAc_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btnSetPass_Click(object sender, EventArgs e)
        {
            frmSetPassWord fsetPW = new frmSetPassWord();
            fsetPW.ShowDialog();
        }

        private void btnFindAc_Click(object sender, EventArgs e)
        {
            dgvAccount.DataSource = dtBase.DataReader("Select * from tblAccount where UserName like '%" + txtFindAcc.Text + "%' or DisplayName like '%" + txtFindAcc.Text + "%'");
        }
        //
        //
        //
        //----------------------------------------------------------------------//

        //--------------Phần bàn ăn-----------------//

    }
}
