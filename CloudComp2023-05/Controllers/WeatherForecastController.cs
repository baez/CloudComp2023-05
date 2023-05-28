﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CloudComp2023_05.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private string _connString = "";
        private readonly IConfiguration _configuration;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            // ===========
            var connectionString = this._configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING");
            var sdConnect = new DatabaseConnection();
            var dbStatus = sdConnect.GetDBStatus(connectionString);
            // ===========

            var rng = new Random();
            var result = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = index < 5 ? Summaries[rng.Next(Summaries.Length)] : $"Database Status: {dbStatus}"
            });

            return result.ToArray();
        }
    }
}
