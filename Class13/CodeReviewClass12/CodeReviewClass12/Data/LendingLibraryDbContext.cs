using CodeReviewClass12.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeReviewClass12.Data
{
    public class LendingLibraryDbContext : DbContext
    {
        public LendingLibraryDbContext(DbContextOptions<LendingLibraryDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Book { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
