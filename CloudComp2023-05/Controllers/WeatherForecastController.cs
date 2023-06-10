using DataModels;
using Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Repositories;
using System.Collections.Generic;

namespace CloudComp2023_05.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private string _connString = "";
        private readonly IConfiguration _configuration;
        private readonly IEmployeeRepository _documentRepository;
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IConfiguration configuration)
        {
            this._logger = logger;
            this._configuration = configuration;
            this._connString = this._configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING");
            this._documentRepository = new EmployeeRepository(this._connString);
        }

        [HttpGet]
        public IList<Employee> Get()
        {
            // ===========
            // var sdConnect = new DatabaseConnection();
            // var dbStatus = sdConnect.GetDBStatus(this._connString);
            // this._documentRepository.CreateTable();
            
            this._documentRepository.InsertEmployee("H003", "Tom Hardy");
            var employees = this._documentRepository.GetEmployees();
            // ===========

            //var rng = new Random();
            //var result = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = index < 5 ? Summaries[rng.Next(Summaries.Length)] : $"Database Status: {dbStatus}"
            //});

            return employees;
        }
    }
}
