using CodeFirst.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class CodeFirstContext: DbContext
    {
        public CodeFirstContext():base("name=CustomerDb")
        {

        }
 
        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerType> CustomerType { get; set; }
    }
}
