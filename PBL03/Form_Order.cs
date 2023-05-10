using Guna.UI2.WinForms;
using PBL03.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL03
{
    public partial class Form_Order : Form
    {
        private OrderFood_BLL bll;
        private Bill_BLL bill;
        private int progress = 0;
        public Form_Order()
        {
            InitializeComponent();
            this.AutoScroll = false;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bll = new OrderFood_BLL();
            bill = new Bill_BLL();
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            flowLayout_Food.Visible = false;
            ProgressIndicator_Load.Visible = true;
            CirclePictureBox_GIF.Visible = true;
            ProgressIndicator_Load.AnimationSpeed = 70;
            progress = 0;
            ProgressIndicator_Load.Start();
            timer2.Start();

            flowLayout_Food.Controls.Clear();
            pnStast.Height = btnFood.Height;
            pnStast.Top = btnFood.Top;
            bll.getFood_BLL(flowLayout_Food);
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                tbSearch.Text = "Search for menu";
                tbSearch.ForeColor = Color.DimGray;
            }
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            if (tbSearch.Text == "Search for menu")
            {
                tbSearch.Text = "";
                tbSearch.ForeColor = Color.DimGray;
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            flowLayout_Food.Visible = false;
            ProgressIndicator_Load.Visible = true;
            CirclePictureBox_GIF.Visible = true;
            ProgressIndicator_Load.AnimationSpeed = 70;
            progress = 0;
            ProgressIndicator_Load.Start();
            timer2.Start();

            flowLayout_Food.Controls.Clear();
            pnStast.Height = btnDrink.Height;
            pnStast.Top = btnDrink.Top;
            bll.getDrink_BLL(flowLayout_Food);
        }

        private void btnCream_Click(object sender, EventArgs e)
        {
            flowLayout_Food.Visible = false;
            ProgressIndicator_Load.Visible = true;
            CirclePictureBox_GIF.Visible = true;
            ProgressIndicator_Load.AnimationSpeed = 70;
            progress = 0;
            ProgressIndicator_Load.Start();
            timer2.Start();

            flowLayout_Food.Controls.Clear();
            pnStast.Height = btnCream.Height;
            pnStast.Top = btnCream.Top;
            bll.getCreams_BLL(flowLayout_Food);
        }

        private void btnSubtotal_Click(object sender, EventArgs e)
        {
            double subtotal = 0;
            double total = 0;
            int kh = Convert.ToInt32(lbNumberCustomer.Text);
            if (ckbVoucher.Checked)
            {
                if (kh >= 5 && kh <= 10)
                {
                    lbVoucher.Text = "5 %";
                }
                else if (kh > 10)
                {
                    lbVoucher.Text = "10 %";
                }
                else if (kh < 5)
                {
                    lbVoucher.Text = "0 %";
                }    
            }
            else
            {
                lbVoucher.Text = "0 %";
            }    
            foreach (UserControl_Order uo in flowLayout_Order.Controls)
            {
                string t = uo.lbPrice.Text;
                int endIndex = t.IndexOf(" ");
                string st = t.Substring(0, endIndex);
                subtotal += Convert.ToDouble(st) * (double)uo.numericquantity.Value;
            }
            string vc = lbVoucher.Text;
            int percent = vc.IndexOf(" ");
            string voucher = vc.Substring(0, percent);
            total = subtotal - subtotal * Convert.ToDouble(voucher) / 100;
            lbSubtotal.Text = subtotal.ToString() + " VND";
            lbTotal.Text = total.ToString() + " VND";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                DateTime dt = DateTime.Now;
                string t = lbSubtotal.Text;
                int endIndex = t.IndexOf(" ");
                string st = t.Substring(0, endIndex);
                float sub = Convert.ToSingle(st);
                bll.orderMeal_BLL(flowLayout_Order);
                bill.addBill_BLL(dt, lbTable.Text, sub);
                MessageBox.Show("Đã lưu order vào hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DateTime dt = DateTime.Now;
                string t = lbSubtotal.Text;
                int endIndex = t.IndexOf(" ");
                string st = t.Substring(0, endIndex);
                float sub = Convert.ToSingle(st);
                bll.updateMeal_BLL(flowLayout_Order, lbTable.Text);
                bill.updateBill_BLL(dt, lbTable.Text, sub);
                MessageBox.Show("Đã cập nhật order vào hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            printPreviewDialog_Bill.Document = print_Bill;
            printPreviewDialog_Bill.ShowDialog();
        }

        private void print_Bill_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("\t\t\tBill Order", new Font("Consolas", 20, FontStyle.Regular), Brushes.Black, new Point(10, 10));
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progress += 1;
            if (progress == 20)
            {
                timer1.Stop();
                ProgressIndicator_Load.Visible = false;
                CirclePictureBox_GIF.Visible = false;
                flowLayout_Food.Visible = true;
            } 
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void DragForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
