using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Week6IdentityDemo.Models
{
    public class Week6IdentityDemoContext : DbContext
    {
        public Week6IdentityDemoContext (DbContextOptions<Week6IdentityDemoContext> options)
            : base(options)
        {
        }

        public DbSet<Week6IdentityDemo.Models.Post> Post { get; set; }
    }
}
