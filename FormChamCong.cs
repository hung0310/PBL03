using Guna.UI2.WinForms;
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
using Excel = Microsoft.Office.Interop.Excel;

namespace PBL03
{
    public partial class FormChamCong : Form
    {
        private ChamCong_BLL bll;
        public FormChamCong()
        {
            InitializeComponent();
            bll = new ChamCong_BLL();
            List<string> danhSachTen = bll.getNameEmployee_BLL();
            DataGridViewTextBoxColumn tenColumn = (DataGridViewTextBoxColumn)dtgvShow.Columns["Name"];
            foreach (string ten in danhSachTen)
            {
                tenColumn.DataGridView.Rows.Add(ten);
            }
            foreach(string ten in danhSachTen)
            {
                int id = bll.getIDSchedule_BLL(ten);
                List<DateTime> days = bll.getWorkDayOfEmployee_BLL(id);
                foreach(var item in days)
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

        // Code để đọc dữ liệu từ tệp Excel và hiển thị trên DataGridView
        //private void LoadDataFromExcel(string filePath, Guna2DataGridView dataGridView)
        //{
        //    Excel.Application excelApp = new Excel.Application();
        //    Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);
        //    Excel.Worksheet worksheet = workbook.Sheets[1];

        //    // Lấy vùng dữ liệu sử dụng trong tệp Excel
        //    Excel.Range usedRange = worksheet.UsedRange;
        //    int rowCount = usedRange.Rows.Count;
        //    int columnCount = usedRange.Columns.Count;

        //    // Xóa dữ liệu hiện có trên DataGridView (nếu có)
        //    dataGridView.Rows.Clear();

        //    // Lặp qua các dòng và cột để lấy dữ liệu từ tệp Excel
        //    for (int row = 1; row <= rowCount; row++)
        //    {
        //        List<object> rowData = new List<object>();
        //        for (int column = 1; column <= columnCount; column++)
        //        {
        //            Excel.Range cell = usedRange.Cells[row, column];
        //            object cellValue = cell.Value2;
        //            rowData.Add(cellValue);
        //        }
        //        dataGridView.Rows.Add(rowData.ToArray());
        //    }

        //    // Đóng tệp Excel và giải phóng tài nguyên
        //    workbook.Close();
        //    excelApp.Quit();
        //    System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
        //    System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
        //    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
        //}

        //private void btnSelectFile_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog open = new OpenFileDialog();
        //    open.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
        //    open.Title = "Chọn file Excel";
        //    if (open.ShowDialog() == DialogResult.OK)
        //    {
        //        string selectedFilePath = open.FileName;
        //        LoadDataFromExcel(selectedFilePath, dtgvShow);
        //    }
        //}

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            string nameEmployee = dtgvShow.SelectedRows[0].Cells[0].Value.ToString();
            DateTime currentDate = DateTime.Now;
            bll.Add_WorkDay_BLL(nameEmployee, currentDate);
            MessageBox.Show("Đã chấm công thành công cho thu ngân " + nameEmployee);
        }
    }
}
