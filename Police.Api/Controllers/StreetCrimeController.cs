using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Police.Logic.Services;
using Police.Model;

namespace Police.Api.Controllers
{
    [ApiController]
    [Route("api")]
    public class StreetCrimeController : ControllerBase
    {
        private readonly ILogger<StreetCrimeController> _logger;
        private readonly StreetCrimeService _streetCrimeService;

        public StreetCrimeController(
            ILogger<StreetCrimeController> logger,
            StreetCrimeService streetCrimeService
        )
        {
            _logger = logger;
            this._streetCrimeService = streetCrimeService;
        }

        [HttpGet]
        public StreetCrimeResponse Get()
        {
            var crime = _streetCrimeService.GetStreetCrimes();

            StreetCrimeResponse test = new StreetCrimeResponse
            {
                count = crime.id
            };

            return test;
        }
    }
}
