using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_bai1
{
    class CodeFirstContext : DbContext
    {
        public CodeFirstContext(): base() { }
        public DbSet<Company> companies { get; set; }
    }
}
