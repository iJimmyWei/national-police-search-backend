using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Police.Logic.Services;

namespace Police.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly StreetCrimeService _streetCrimeService;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            StreetCrimeService streetCrimeService
        )
        {
            _logger = logger;
            this._streetCrimeService = streetCrimeService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var shit = _streetCrimeService.GetStreetCrimes();
            var shit2 = _streetCrimeService.GetStreetCrimes();
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = shit,
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
