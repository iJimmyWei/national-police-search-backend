using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Police.DataAccess.Repositories;
using Police.Model;

namespace Police.Logic.Services
{
    public class StreetCrimeService
    {
        private readonly SearchOutcomesRepository _searchOutcomesRepository;

        public StreetCrimeService(
            SearchOutcomesRepository searchOutcomesRepository
        )
        {
            this._searchOutcomesRepository = searchOutcomesRepository;
        }

        public List<StreetCrimeResponse> GetStreetCrimes(double? lat, double? _long, int? year)
        {
            var crimes = _searchOutcomesRepository.LookupCrimes(lat, _long, year);

            return crimes;
        }
    }
}
