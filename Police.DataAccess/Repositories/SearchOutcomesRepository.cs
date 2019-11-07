using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Police.Model;

namespace Police.DataAccess.Repositories
{
    public class SearchOutcomesRepository
    {
        private readonly DbContextService context;

        public SearchOutcomesRepository(
            DbContextService context
        )
        {
            this.context = context;
        }

        public List<StreetCrimeResponse> LookupCrimes(double? lat, double? _long)
        {
            var context = this.context.GetDbContext();
            double mileToDegree = (double) 1 / 69; // Each degree of latitude/longitude approx. 69 miles
            var defaultRadiusMiles = 1;
            var latitudeRadius = mileToDegree * defaultRadiusMiles;

            using (context)
            {
                var query = context.search_outcomes.Where((s) =>
                   lat - latitudeRadius < s.lat && s.lat < lat + latitudeRadius &&
                   _long - latitudeRadius < s._long && s._long < _long + latitudeRadius
                ).ToList();
                var count = query.Count();
                List<StreetCrimeResponse> sc = new List<StreetCrimeResponse>();
                foreach (var q in query)
                {
                    var crime = new StreetCrimeResponse
                    {
                        Id = q.crime_id,
                        Lat = q.lat,
                        Long = q._long,
                        CrimeTypeId = q.crime_type_id,
                        LastOutcomeId = q.last_outcome_id,
                        Count = count,
                    };
                    sc.Add(crime);
                }

                return sc;
            }
        }
    }
}
