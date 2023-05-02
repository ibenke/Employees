using DAL.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service
{
    public class EmployeesService : IEmployeesService
    {
        private Repository.EmployeesRepository _employeesRepository;
        public EmployeesService()
        {
            _employeesRepository = new Repository.EmployeesRepository();
        }

        public List<Employees> GetAllEmployees()
        {
            List<Employees> employees = _employeesRepository.GetAllEmployees();

            if(employees == null)
            {
                throw new Exception("Error");
            }
            else
            {
                return employees;
            }
        }
    }
}
