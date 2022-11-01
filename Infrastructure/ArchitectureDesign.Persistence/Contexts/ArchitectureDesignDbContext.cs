using ArchitectureDesign.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureDesign.Persistence.Contexts
{
    public class ArchitectureDesignDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql("User ID=postgres;Password=123456;Host=localhost;Port=5433;Database=ArchitectureDesign;");

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
