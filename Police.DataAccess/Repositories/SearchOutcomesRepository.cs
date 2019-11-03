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

        public search_outcomes LookupCrimes()
        {
            var context = this.context.GetDbContext();

            using (context)
            {
                var query = context.search_outcomes.Where((s) => s.lat > 52.629 && s.lat < 52.63 && s.year == 2019).FirstOrDefault();

                return query;
            }
        }
    }
}
