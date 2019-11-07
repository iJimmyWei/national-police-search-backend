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
    [Route("api/street-crimes")]
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
        public List<StreetCrimeResponse> Get(
           [FromQuery(Name = "lat")] double? lat,
           [FromQuery(Name = "long")] double? _long
        )
        {
            var crime = _streetCrimeService.GetStreetCrimes(lat, _long);

            return crime;
        }
    }
}
