using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Police.Model;

namespace Police.DataAccess
{
    public class DbContextService
    {
        public Model1 GetDbContext()
        {
            return new Model1();
        }
    }
}
