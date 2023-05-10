using Guna.UI2.WinForms;
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
    public partial class Form_QuanLyThuNgan : Form
    {
        public Form_QuanLyThuNgan()
        {
            InitializeComponent();
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            pnMenu.Visible = true;
            btnHomeDown.Visible = true;
            btnHomeUp.Visible = false;
            btnExpand.Visible = false;
            btnCollapse.Visible = true;
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            pnMenu.Visible = false;
            btnHomeUp.Visible = true;
            btnExpand.Visible = true;
            btnHomeDown.Visible = false;
            btnCollapse.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dtgvShow.Visible = false;
            pnDisplayFunction.Visible = true;
            pnDisplayFunction.Controls.Clear();
            Form_Update fu = new Form_Update();
            fu.TopLevel = false;
            pnDisplayFunction.Controls.Add(fu);
            fu.Size = pnDisplayFunction.Size;
            fu.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dtgvShow.Visible = false;
            pnDisplayFunction.Visible = true;
            pnDisplayFunction.Controls.Clear();
            Form_Update fu = new Form_Update();
            fu.TopLevel = false;
            pnDisplayFunction.Controls.Add(fu);
            fu.Size = pnDisplayFunction.Size;
            fu.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pnDisplayFunction.Visible = false;
            dtgvShow.Visible = true;
        }
    }
}
