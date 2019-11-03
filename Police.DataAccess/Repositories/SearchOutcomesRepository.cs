using System;
using System.Collections.Generic;
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

        public int GetTotalItems()
        {
            using (var dbCon = this.context.GetDbContext())
            {
                var query = (from d in dbCon.search_outcomes
                             orderby d.id
                             where d.lat > 52.629 && d.lat < 52.63 && d.year == 2019
                             select d).Count();

                return query;
            }
        }
    }
}
