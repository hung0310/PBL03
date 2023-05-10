using PBL03.BLL.DangNhap_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL03
{
    public partial class Form_ForgotPassword : Form
    {
        public Form_ForgotPassword()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form_Information_Validation fi = new Form_Information_Validation();
            fi.Show();
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbNewPassword.Text == tbConfirmPass.Text)
            {
                if ((MessageBox.Show("Bạn có muốn đổi mật khẩu không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    string hashpassword = BCrypt.Net.BCrypt.HashPassword(tbConfirmPass.Text);
                    Login_BLL.Instance.ChangePass(tbUsername.Text, hashpassword);
                    MessageBox.Show("Đổi mật khẩu thành công, mời bạn đăng nhập lại !");
                    this.Dispose();
                }
            }
            else MessageBox.Show("Xác nhận mật khẩu không trùng khớp. Vui lòng nhập lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
