using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class16Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace Class16Demo.Data
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options)
        {
            
        }

        public DbSet<Tasks> Tasks { get; set; }
    }
}
