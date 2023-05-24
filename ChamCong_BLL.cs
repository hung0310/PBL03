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
        public List<DateTime> getWorkDayOfEmployee_BLL(int idSchedule)
        {
            return dal.getWorkDayOfEmployee_DAL(idSchedule);
        }
        public void Add_WorkDay_BLL(string nameEmployee, DateTime now)
        {
            dal.Add_WorkDay_DAL(nameEmployee, now);
        }
    }
}
