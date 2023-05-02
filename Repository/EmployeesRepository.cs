using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository
{
    public class EmployeesRepository : IEmployeesRepository
    {
        //private readonly EmployeesDbContext _employeesDbContext;
        private DAL.EmployeesDAL _DAL;

        public EmployeesRepository()
        {
            _DAL = new DAL.EmployeesDAL();
        }

        public List<Employees> GetAllEmployees()
        {

            return _DAL.GetAllEmployees();
        }


        /*
        public async Task<IEnumerable<Employees>> GetEmployeesAsync()
        {
            try
            {
                IEnumerable<Employees> result = await _employeesDbContext.Employees.ToListAsync();
                return result;
            }
            catch
            {
                return null;
            }
        }
        */
    }
}
