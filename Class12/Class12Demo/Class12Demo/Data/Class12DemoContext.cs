using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Class12Demo.Models
{
    public class Class12DemoContext : DbContext
    {
        public Class12DemoContext (DbContextOptions<Class12DemoContext> options)
            : base(options)
        {
        }

        public DbSet<Class12Demo.Models.Book> Book { get; set; }
    }
}
