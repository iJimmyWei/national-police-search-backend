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

        public List<StreetCrimeResponse> LookupCrimes()
        {
            var context = this.context.GetDbContext();

            using (context)
            {
                var query = context.search_outcomes.Where((s) => s.lat > 52.629 && s.lat < 52.63).ToList();
                var count = query.Count();
                List<StreetCrimeResponse> sc = new List<StreetCrimeResponse>();
                foreach (var q in query)
                {
                    var crime = new StreetCrimeResponse
                    {
                        Id = q.crime_id,
                        Lat = q.lat,
                        Long = q._long,
                        Count = count,
                    };
                    sc.Add(crime);
                }

                return sc;
            }
        }
    }
}
