using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Police.DataAccess.Repositories;

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

        public int GetStreetCrimes()
        {
            var shit = _searchOutcomesRepository.GetTotalItems();

            return shit;
        }
    }
}
