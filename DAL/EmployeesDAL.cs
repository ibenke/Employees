using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class EmployeesDAL
    {
        public List<Employees> GetAllEmployees()
        {
            var db = new EmployeesDbContext();
            return db.Employees.ToList();
        }
    }
}
