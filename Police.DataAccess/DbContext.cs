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
        static void Main(string[] args)
        {
        }

        public Model1 GetDbContext()
        {
            return new Model1();
        }
    }
}
