using Guna.UI2.AnimatorNS;
using Microsoft.ReportingServices.Interfaces;
using PBL03.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL03
{
    public partial class FormChamCong : Form
    {
        private ChamCong_BLL bll;
        private int flag = 0;
        public FormChamCong()
        {
            InitializeComponent();
            bll = new ChamCong_BLL();
            cbbWeek.Items.AddRange(bll.getWeekOfDays_BLL().ToArray());
            lbWeek.Text = "Tuần: " + GetWeekNumberOfDate(DateTime.Now); 
            if(DateTime.Now.Day == 6)
            {
                btnMail.Visible = true;
            }
                        List<string> danhSachTen = bll.getNameEmployee_BLL();
            dtgvShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewTextBoxColumn tenColumn = (DataGridViewTextBoxColumn)dtgvShow.Columns["Name"];
            foreach (string ten in danhSachTen)
            {
                tenColumn.DataGridView.Rows.Add(ten);
            }
        }
        private void btnChamCong_Click(object sender, EventArgs e)
        {
            string nameEmployee = dtgvShow.SelectedRows[0].Cells[0].Value.ToString();
            DateTime datenow = DateTime.Now;
            DateTime currentDate = datenow.Date;
            if (bll.CheckExistOfDay_BLL(nameEmployee, currentDate))
            {
                bll.Add_WorkDay_BLL(nameEmployee, currentDate);
                MessageBox.Show("Đã chấm công thành công cho thu ngân " + nameEmployee);
            }
            else
            {
                DialogResult result = MessageBox.Show("Nhân viên này đã được điểm danh vào ngày này. Nếu nhân viên này đang làm thêm ca, bạn có thể chọn YES để cộng thêm ngày làm cho nhân viên này. Nếu không hãy chọn NO để hủy", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int weekCurrent = GetWeekNumberOfDate(currentDate);
                    int weekMaxInDB = GetWeekNumberOfDate(bll.getMaxDay_BLL());
                    if (weekCurrent == weekMaxInDB)
                    {
                        bll.Add_WorkDay_BLL(nameEmployee, currentDate);
                        MessageBox.Show("Đã chấm công thành công cho thu ngân " + nameEmployee);
                    }
                    else
                    {
                        dtgvShow.Rows.Clear();
                        List<string> danhSachTen = bll.getNameEmployee_BLL();
                        DataGridViewTextBoxColumn tenColumn = (DataGridViewTextBoxColumn)dtgvShow.Columns["Name"];
                        foreach (string ten in danhSachTen)
                        {
                            tenColumn.DataGridView.Rows.Add(ten);
                        }
                        bll.Add_WorkDay_BLL(nameEmployee, currentDate);
                        DayOfWeek currentDayOfWeek = currentDate.DayOfWeek;
                        foreach (DataGridViewColumn column in dtgvShow.Columns)
                        {
                            if (column.Name == currentDayOfWeek.ToString())
                            {
                                // Tìm thấy cột có tên trùng khớp
                                // Duyệt qua các hàng trong DataGridView
                                foreach (DataGridViewRow row in dtgvShow.Rows)
                                {
                                    if (row.Cells["Name"].Value.ToString() == nameEmployee)
                                    {
                                        // Tìm thấy hàng có tên trùng khớp
                                        // Thay đổi giá trị của ô tương ứng
                                        row.Cells[column.Index].Value = "X";
                                        break; // Thoát khỏi vòng lặp hàng
                                    }
                                }
                                break; // Thoát khỏi vòng lặp cột
                            }
                        }
                    }
                }
            }
        }
        //Lấy được số tuần của ngày
        public int GetWeekNumberOfDate(DateTime date)
        {
            CultureInfo ci = CultureInfo.CurrentCulture;
            Calendar calendar = ci.Calendar;
            CalendarWeekRule calendarWeekRule = ci.DateTimeFormat.CalendarWeekRule;
            DayOfWeek firstDayOfWeek = ci.DateTimeFormat.FirstDayOfWeek;

            return calendar.GetWeekOfYear(date, calendarWeekRule, firstDayOfWeek);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbShiftWork.Text = string.Empty;
            lbSumWorkDay.Text = string.Empty;
            string nameEmployee = dtgvShow.SelectedRows[0].Cells[0].Value.ToString();
            lbName.Text = "Tên nhân viên: " + nameEmployee;
            lbSumWorkDay.Text = "Số ngày làm: " + bll.SumWorkDay_BLL(nameEmployee).ToString();
            lbShiftWork.Text = "Ca làm: " + bll.getShiftWork_BLL(nameEmployee);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string nameEmployee = dtgvShow.SelectedRows[0].Cells[0].Value.ToString();
            bll.Add_WorkDay_BLL(nameEmployee, dtpkEditWorkDay.Value);
            MessageBox.Show("Đã chấm công thành công cho thu ngân " + nameEmployee);
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            string week = cbbWeek.SelectedItem.ToString();
            //int week = Convert.ToInt32(cbbWeek.SelectedItem.ToString());
            //List<DateTime> daysOfWeek = GetDaysOfWeek(week, 2023);
            //foreach (DateTime day in daysOfWeek)
            //{
            //    MessageBox.Show("" + day);
            //}
            //DateTime day = DateTime.Now;
            //List<DateTime> days = GetDaysInSameWeek(day);
            //foreach(DateTime date in days)
            //{
            //    MessageBox.Show("" + date);
            //}
            //MessageBox.Show("" + GetWeekNumberOfDate(day));
            dtgvShow.Rows.Clear();
            List<string> danhSachTen = bll.getNameEmployee_BLL();
            dtgvShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewTextBoxColumn tenColumn = (DataGridViewTextBoxColumn)dtgvShow.Columns["Name"];
            foreach (string ten in danhSachTen)
            {
                tenColumn.DataGridView.Rows.Add(ten);
            }
            foreach (string ten in danhSachTen)
            {
                int id = bll.getIDSchedule_BLL(ten);
                List<DateTime> days = bll.getWorkDayOfEmployee_BLL(id, Convert.ToInt32(week));
                foreach (var item in days)
                {
                    DayOfWeek currentDayOfWeek = item.DayOfWeek;
                    foreach (DataGridViewColumn column in dtgvShow.Columns)
                    {
                        if (column.Name == currentDayOfWeek.ToString())
                        {
                            // Tìm thấy cột có tên trùng khớp
                            // Duyệt qua các hàng trong DataGridView
                            foreach (DataGridViewRow row in dtgvShow.Rows)
                            {
                                if (row.Cells["Name"].Value.ToString() == ten)
                                {
                                    // Tìm thấy hàng có tên trùng khớp
                                    // Thay đổi giá trị của ô tương ứng
                                    row.Cells[column.Index].Value = "X";
                                    break; // Thoát khỏi vòng lặp hàng
                                }
                            }
                            break; // Thoát khỏi vòng lặp cột
                        }
                    }
                }
            }
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            ++flag;
            if (flag % 2 != 0)
            {
                FlowLayout_Salary.Visible = true;
                FlowLayout_Salary.Controls.Clear();
                List<string> ten = bll.getNameEmployee_BLL();
                foreach (var item in ten)
                {
                    float salary = bll.getSalary_BLL(item);
                    int sumWorkDay = bll.SumWorkDay_BLL(item);
                    string shiftwork = bll.getShiftWork_BLL(item);
                    float sumSalary = salary * sumWorkDay * 5;
                    if(sumWorkDay > 1)
                    {
                        UserControl_ChamCong ucc = new UserControl_ChamCong();
                        ucc.lbName.Text = "Tên: " + item;
                        ucc.lbShiftWork.Text = "Ca làm: " + shiftwork;
                        ucc.lbSumWorkDay.Text = "Tổng số ngày làm: " + sumWorkDay.ToString();
                        ucc.lbSumSalary.Text = "Tổng tiền lương: " + sumSalary.ToString() + " VND";
                        FlowLayout_Salary.Controls.Add(ucc);
                    }
                }
            }
            else
            {
                FlowLayout_Salary.Visible = false;
            }
        }
    }
}
