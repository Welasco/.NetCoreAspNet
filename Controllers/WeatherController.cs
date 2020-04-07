using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _NetCoreAspNet.Models;

namespace _NetCoreAspNet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : Controller
    {
        private readonly ILogger<WeatherController> _logger;

        public WeatherController(ILogger<WeatherController> logger)
        {
            _logger = logger;
        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet]
        public WeatherForecast Get()
        {
            var rng = new Random();
            WeatherForecast forcast = new WeatherForecast();
            forcast.Date = DateTime.Now;
            forcast.TemperatureC = rng.Next(-20, 55);
            forcast.Summary = Summaries[rng.Next(Summaries.Length)];
            return forcast;
        }        
    }
}
