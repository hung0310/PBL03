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
    public partial class FormMain : Form
    {
        private int progress = 0;
        public FormMain()
        {
            InitializeComponent();
            this.AutoScroll = false;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            pnStast.Height = btnMenu.Height;
            pnStast.Top = btnMenu.Top;
            pnShow.Controls.Clear();

            //pnShow.Visible = false;
            //ProgressIndicator_Load.Visible = true;
            //CirclePictureBox_GIF.Visible = true;
            //ProgressIndicator_Load.AnimationSpeed = 70;
            //progress = 0;
            //ProgressIndicator_Load.Start();
            //timer1.Start();

            Form_Menu mn = new Form_Menu();
            mn.TopLevel = false;
            pnShow.Controls.Add(mn);
            mn.Size = pnShow.Size;
            mn.Show();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            pnStast.Height = btnQLNV.Height;
            pnStast.Top = btnQLNV.Top;
            pnShow.Controls.Clear();

            //pnShow.Visible = false;
            //ProgressIndicator_Load.Visible = true;
            //CirclePictureBox_GIF.Visible = true;
            //ProgressIndicator_Load.AnimationSpeed = 70;
            //progress = 0;
            //ProgressIndicator_Load.Start();
            //timer1.Start();

            Form_MEmployee me = new Form_MEmployee();
            me.TopLevel = false;
            pnShow.Controls.Add(me);
            me.Size = pnShow.Size;
            me.Show();
        }

        private void btnStatus_Table_Click(object sender, EventArgs e)
        {
            pnStast.Height = btnStatus_Table.Height;
            pnStast.Top = btnStatus_Table.Top;
            pnShow.Controls.Clear();

            //pnShow.Visible = false;
            //ProgressIndicator_Load.Visible = true;
            //CirclePictureBox_GIF.Visible = true;
            //ProgressIndicator_Load.AnimationSpeed = 70;
            //progress = 0;
            //ProgressIndicator_Load.Start();
            //timer1.Start();

            Form_StatusTable fst = new Form_StatusTable();
            fst.TopLevel = false;
            fst.Size = pnShow.Size;
            pnShow.Controls.Add(fst);
            fst.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            FormChangePassword fm = new FormChangePassword();
            fm.tbUsername.Text = lbNameUser.Text;
            fm.Show();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            pnStast.Height = btnPay.Height;
            pnStast.Top = btnPay.Top;
            pnShow.Controls.Clear();

            //pnShow.Visible = false;
            //ProgressIndicator_Load.Visible = true;
            //CirclePictureBox_GIF.Visible = true;
            //ProgressIndicator_Load.AnimationSpeed = 70;
            //progress = 0;
            //ProgressIndicator_Load.Start();
            //timer1.Start();

            FormPay fp = new FormPay();
            fp.TopLevel = false;
            fp.Size = pnShow.Size;
            pnShow.Controls.Add(fp);
            fp.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progress += 1;
            if (progress == 20)
            {
                timer1.Stop();
                ProgressIndicator_Load.Visible = false;
                CirclePictureBox_GIF.Visible = false;
                pnShow.Visible = true;
            }
        }
    }
}
