using DataModels;
using Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Repositories;
using System;
using System.Collections.Generic;

namespace CloudComp2023_05.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private string _connString = "";
        private readonly IConfiguration _configuration;
        private readonly IEmployeeRepository _employeeRepository;

        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger, IConfiguration configuration)
        {
            this._logger = logger;
            this._configuration = configuration;
            this._connString = this._configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING");
            this._employeeRepository = new EmployeeRepository(this._connString);
        }

        [HttpGet]
        public IList<Employee> Get(string id)
        {
            if (string.IsNullOrWhiteSpace(id)) 
            {
                new ArgumentNullException(nameof(id));
            }

            var employees = this._employeeRepository.GetEmployees(id);

            return employees;
        }
    }
}
