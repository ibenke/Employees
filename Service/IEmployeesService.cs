using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IEmployeesService
    {
        List<Employees> GetAllEmployees();
    }
}
