using MVC1.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC1.DataAccess
{
    public class DAL
    {
        PASSEntities db = new PASSEntities();

        public List<Employee> GetEmployees()
        {
            return db.Employees.Where(x=>x.isActive == "Y").Take(20).ToList();
        }

        public Employee GetEmployeeById(long id)
        {
            return db.Employees.Where(x => x.employeeId == id).SingleOrDefault();
        }
        public bool PostEmployee(VolunteerTimeSheet emp)
        {
                db.VolunteerTimeSheets.Add(emp);
            int i = db.SaveChanges();
            if (i == 1) { return true; }
            else { return false; }
        }
    }
}