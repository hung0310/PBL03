using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL03.DAL
{
    internal class ChamCong_DAL
    {
        public List<string> getNameEmployee_DAL()
        {
            List<string> names = new List<string>();
            using(var db = new PBL3Entities1())
            {
                var query = from ws in db.WorkSchedules
                            join em in db.Employees on ws.IDEmployee equals em.ID_Employee
                            select em.Name_Employee;
                foreach(var item in query)
                {
                    names.Add(item);
                }
            }
            return names;
        }
        public string getIDEmployee(string nameEmployee)
        {
            using (var db = new PBL3Entities1())
            {
                var query = db.Employees.SingleOrDefault(p => p.Name_Employee.Contains(nameEmployee));
                return query.ID_Employee;
            }
        }
        public int getIDSchedule_DAL(string nameEmployee)
        {
            string idEmployee = getIDEmployee(nameEmployee);
            using (var db = new PBL3Entities1())
            {
                var query = db.WorkSchedules.SingleOrDefault(p=> p.IDEmployee == idEmployee);
                return query.ID_Schedule;
            }
        }
        public int getIDShift_DAL(string nameEmployee)
        {
            string idEmployee = getIDEmployee(nameEmployee);
            using (var db = new PBL3Entities1())
            {
                var query = db.WorkSchedules.SingleOrDefault(p => p.IDEmployee == idEmployee);
                return query.IDShift;
            }
        }
        public List<DateTime> GetDaysOfWeek(int week, int year)
        {
            List<DateTime> daysOfWeek = new List<DateTime>();
            CultureInfo culture = CultureInfo.CurrentCulture;
            Calendar calendar = culture.Calendar;
            // Xác định ngày đầu tiên của tuần và năm đã cho
            DateTime startDate = new DateTime(year, 1, 1);
            startDate = startDate.AddDays((week - 1) * 7);
            while (calendar.GetWeekOfYear(startDate, culture.DateTimeFormat.CalendarWeekRule, culture.DateTimeFormat.FirstDayOfWeek) != week)
            {
                startDate = startDate.AddDays(1);
            }
            // Duyệt qua 7 ngày trong tuần
            for (int i = 1; i <= 7; i++)
            {
                DateTime currentDay = startDate.AddDays(i);
                daysOfWeek.Add(currentDay);
            }

            return daysOfWeek;
        }
        public List<DateTime> getWorkDayOfEmployee_DAL(int idSchedule, int day)
        {
            List<DateTime> days = new List<DateTime>();
            List<DateTime> dayinweek = GetDaysOfWeek(day, DateTime.Now.Year);
            using(var db = new PBL3Entities1())
            {
                var query = db.TimeSheets.Where(p => p.IDSchedule == idSchedule).Select(p => p.WorkDay).ToList();
                foreach(var item in query)
                {
                    foreach(DateTime d in dayinweek)
                    {
                        if(d == item)
                        {
                            days.Add(item);
                        }
                    }
                }
            }
            return days;
        }
        public void Add_WorkDay_DAL(string nameEmployee, DateTime now)
        {
            int id = getIDSchedule_DAL(nameEmployee);
            using(var db = new PBL3Entities1())
            {
                TimeSheet ts = new TimeSheet
                {
                    IDSchedule = id,
                    WorkDay = now,
                };
                db.TimeSheets.Add(ts);
                db.SaveChanges();
            }
        }
        public int SumWorkDay_DAL(string nameEmployee)
        {
            int id = getIDSchedule_DAL(nameEmployee);
            using(var db = new PBL3Entities1())
            {
                var query = db.TimeSheets
                    .Join(db.WorkSchedules, p => p.IDSchedule, c => c.ID_Schedule, (p, c) => new { TimeSheet = p, WorkSchedule = c })
                    .Where(p=> p.TimeSheet.IDSchedule == id)
                    .Count();
                return query;
            }
        }
        public string getShiftWork_DAL(string nameEmployee)
        {
            int id = getIDShift_DAL(nameEmployee);
            using (var db = new PBL3Entities1())
            {
                var query = db.WorkSchedules
                    .Join(db.ShiftWorks, p => p.IDShift, c => c.ID_Shift, (p, c) => new { WorkSchedule = p, ShiftWork = c })
                    .Where(p => p.ShiftWork.ID_Shift == id)
                    .Select(p => p.ShiftWork.NameShift); 
                return query.FirstOrDefault()?.ToString(); 
            }
        }
        public DateTime getMaxDay_DAL()
        {
            using(var db = new PBL3Entities1())
            {
                var query = db.TimeSheets.Max(p => p.WorkDay);
                return query;
            }
        }
        public int GetWeekNumberOfDate(DateTime date)
        {
            CultureInfo ci = CultureInfo.CurrentCulture;
            Calendar calendar = ci.Calendar;
            CalendarWeekRule calendarWeekRule = ci.DateTimeFormat.CalendarWeekRule;
            DayOfWeek firstDayOfWeek = ci.DateTimeFormat.FirstDayOfWeek;

            return calendar.GetWeekOfYear(date, calendarWeekRule, firstDayOfWeek);
        }
        public List<string> getWeekOfDays_DAL()
        {
            List<string> list = new List<string>();
            using(var db = new PBL3Entities1())
            {
                var query = db.TimeSheets.Select(p=> p.WorkDay).ToList();
                foreach(var item in query)
                {
                    string week = GetWeekNumberOfDate(item).ToString();
                    list.Add(week);
                }
            }
            return list.Distinct().ToList();
        }
        public bool CheckExistOfDay_DAL(string nameEmployee, DateTime date)
        {
            int idSchedule = getIDSchedule_DAL(nameEmployee);
            using (var db = new PBL3Entities1())
            {
                var query = db.TimeSheets.Where(p => p.IDSchedule == idSchedule && p.WorkDay == date).Select(p => p.WorkDay);
                if (query.Any()) return false;
                else return true;
            }
        }
        public float getSalary_DAL(string nameEmployee)
        {
            using(var db = new PBL3Entities1())
            {
                var query = db.Employees.Where(p => p.Name_Employee.Contains(nameEmployee)).Select(p => p.Salary);
                return query.FirstOrDefault();
            }
        }
        public void DeleteWorkDayOfEmployee_DAL(string nameEmployee)
        {
            int idSchedule = getIDSchedule_DAL(nameEmployee);
            using(var db = new PBL3Entities1())
            {
                var query = db.TimeSheets.Where(p => p.IDSchedule == idSchedule);
                db.TimeSheets.RemoveRange(query);
                db.SaveChanges();
            }
        }
    }
}
