using PBL03.BLL;
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
    public partial class UserControl_ChamCong : UserControl
    {
        private ChamCong_BLL bll;
        public UserControl_ChamCong()
        {
            InitializeComponent();
            this.AutoScroll = false;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bll = new ChamCong_BLL();
        }

        private void btnPayWage_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận hoàn tất thanh toán lương", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Visible = false;
                string name = this.lbName.Text;
                string nameEmployee = name.Substring(name.IndexOf(':') + 2);
                MessageBox.Show("Thanh toán thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                bll.DeleteWorkDayOfEmployee_BLL(nameEmployee);
            }
        }
    }
}
