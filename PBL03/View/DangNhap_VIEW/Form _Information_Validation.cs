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
using System.Xml.Linq;

namespace PBL03
{
    public partial class Form_Information_Validation : Form
    {
        public Form_Information_Validation()
        {
            InitializeComponent();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Login_BLL.Instance.CheckInfor(tbUsername.Text, tbNameEmployee.Text, tbPhonenumber.Text, tbAddress.Text) == true)
            {
                Form_ForgotPassword fg = new Form_ForgotPassword();
                fg.tbUsername.Text = tbUsername.Text;
                fg.tbUsername.Enabled = false;
                fg.Show();
                this.Dispose();
            }
            else MessageBox.Show("Bạn đã nhập sai thông tin, mời bạn nhập lại");
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormLogin flg = new FormLogin();
            flg.Show();
            this.Close();
        }
    }
}
