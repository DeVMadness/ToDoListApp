using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Context
{
    public class ToDoListContext : DbContext
    {
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Status> Statuses { get; set; }

        public ToDoListContext()
            : base(new DbContextOptionsBuilder<ToDoListContext>()
                  .UseSqlServer(@Environment.GetEnvironmentVariable("ToDoListDbConnectionString")).UseLazyLoadingProxies().Options)
        {
            Database.EnsureCreated();
        }
        
        public ToDoListContext(DbContextOptions<ToDoListContext> options)
         : base(options)
        {
            Database.EnsureCreated();
        }

    }

}
