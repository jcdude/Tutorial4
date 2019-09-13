using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial4
{
    public class MyContext : DbContext
    {
        public DbSet<Employee> employees { get; set; }
        public DbSet<Role> roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=tutorial4;User Id=gratis2;Password=Pass4gratis");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
