using PBL03.BLL.DangNhap_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PBL03
{
    public partial class FormLogin : Form
    {
        private int progress = 0;
        public FormLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Transparent;
            btnLogin.ForeColor = Color.LightBlue;
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.SandyBrown;
            btnLogin.ForeColor = Color.Black;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(tbUsername.Text == "" && tbPassword.Text == "")
            {
                lb_invalid_username.Visible = true;
                lb_invalid_password.Visible = true;
            } else if(tbPassword.Text == "")
            {
                lb_invalid_password.Visible = true;
            } else if(tbUsername.Text == "")
            {
                lb_invalid_username.Visible = true;
            } else
            {
                Login_BLL.Instance.dangnhap(tbUsername.Text, tbPassword.Text);
            }
        }

        private void lbForgotPassword_Click(object sender, EventArgs e)
        {
            Form_ForgotPassword fg = new Form_ForgotPassword();
            fg.Show();
        }

        private void btnHidePassword_Enter(object sender, EventArgs e)
        {
            btnHidePassword.BackColor = Color.SandyBrown;
            btnHidePassword.ForeColor = Color.Black;
        }

        private void btnHidePassword_Leave(object sender, EventArgs e)
        {
            btnHidePassword.BackColor = Color.Transparent;
            btnHidePassword.ForeColor = Color.LightBlue;
        }

        private void btnShowPassword_Leave(object sender, EventArgs e)
        {
            btnShowPassword.BackColor = Color.Transparent;
            btnShowPassword.ForeColor = Color.LightBlue;
        }

        private void btnShowPassword_Enter(object sender, EventArgs e)
        {
            btnShowPassword.BackColor = Color.Transparent;
            btnShowPassword.ForeColor = Color.LightBlue;
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '\0';
            btnShowPassword.Visible = false;
            btnHidePassword.Visible = true;
        }

        private void btnHidePassword_Click(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '●';
            btnShowPassword.Visible = true;
            btnHidePassword.Visible = false;
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            lb_invalid_username.Visible = false;
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            lb_invalid_password.Visible = false;
        }
    }
}
