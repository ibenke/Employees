﻿using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IEmployeesRepository
    {
        List<Employees> GetAllEmployees();
    }
}
