using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using PBL03.BLL.Cashier_BLL;
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
    public partial class FormChangePassword : Form
    {
        public FormChangePassword()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string hasspassword = BCrypt.Net.BCrypt.HashPassword(tbOldPassword.Text);


            if (BCrypt.Net.BCrypt.Verify(tbOldPassword.Text, Cashier_BLL.Instance.getPassword(tbUsername.Text)))
            {
                if (tbNewPassword.Text == tbConfirmPassword.Text)
                {
                    if ((MessageBox.Show("Bạn có muốn thay đổi mật khẩu không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        string hasspassword2 = BCrypt.Net.BCrypt.HashPassword(tbConfirmPassword.Text);
                        Cashier_BLL.Instance.ChangePassword(tbUsername  .Text, hasspassword2);
                        MessageBox.Show("Thay đổi mật khẩu thành công !");
                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới và mật khẩu xác nhận không giống nhau !");
                }
            }
            else
            {
                MessageBox.Show("Bạn nhập sai mật khẩu !");
            }
        }
    }
}
