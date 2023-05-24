using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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
        public List<DateTime> getWorkDayOfEmployee_DAL(int idSchedule)
        {
            List<DateTime> days = new List<DateTime>();
            using(var db = new PBL3Entities1())
            {
                var query = from ws in db.WorkSchedules
                            join ts in db.TimeSheets on ws.ID_Schedule equals ts.IDSchedule
                            where ts.IDSchedule == idSchedule
                            select ts.WorkDay;
                foreach(var item in query)
                {
                    days.Add(item);
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
    }
}
