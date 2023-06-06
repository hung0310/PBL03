using PBL03.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL03.BLL
{
    internal class ChamCong_BLL
    {
        private ChamCong_DAL dal;
        public ChamCong_BLL()
        {
            dal = new ChamCong_DAL();
        }
        public List<string> getNameEmployee_BLL()
        {
            return dal.getNameEmployee_DAL();
        }
        public int getIDSchedule_BLL(string nameEmployee)
        {
            return dal.getIDSchedule_DAL(nameEmployee);
        }
        public List<DateTime> getWorkDayOfEmployee_BLL(int idSchedule, int day)
        {
            return dal.getWorkDayOfEmployee_DAL(idSchedule, day);
        }
        public void Add_WorkDay_BLL(string nameEmployee, DateTime now)
        {
            dal.Add_WorkDay_DAL(nameEmployee, now);
        }
        public int SumWorkDay_BLL(string nameEmployee)
        {
            return dal.SumWorkDay_DAL(nameEmployee);
        }
        public string getShiftWork_BLL(string nameEmployee)
        {
            return dal.getShiftWork_DAL(nameEmployee);
        }
        public DateTime getMaxDay_BLL()
        {
            return dal.getMaxDay_DAL();
        }
        public List<string> getWeekOfDays_BLL()
        {
            return dal.getWeekOfDays_DAL();
        }
        public bool CheckExistOfDay_BLL(string nameEmployee, DateTime date)
        {
            return dal.CheckExistOfDay_DAL(nameEmployee, date);
        }
        public float getSalary_BLL(string nameEmployee)
        {
            return dal.getSalary_DAL(nameEmployee);
        }
        public void DeleteWorkDayOfEmployee_BLL(string nameEmployee)
        {
            dal.DeleteWorkDayOfEmployee_DAL(nameEmployee);
        }
    }
}
