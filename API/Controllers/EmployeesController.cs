using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System;
using API.Models;
using API.Automapper;
using DAL.Models;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        private Service.EmployeesService _Service;
        private ControllerMappingService _MappingService;
        public EmployeesController()
        {
            _Service = new Service.EmployeesService();
            _MappingService = new ControllerMappingService();
        }

        //VRATI SVE ZAPOSLENIKE
        [HttpGet]
        public List<EmployeesModel> GetAllEmployees()
        {
            List<Employees> employeesDB =  _Service.GetAllEmployees();
            List<EmployeesModel> employeesModel = _MappingService.Map<List<EmployeesModel>>(employeesDB);
            return employeesModel;
        }
    }
}