using EmplyeeSystem.Application.Interface;
using EmplyeeSystem.domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyeeSystem.Persistence
{
    public class AppDbContext : DbContext, IAppDbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=.;database=employeeSystem;user=root;password=root");
        }

        public DbSet<Companies> Companies { get; set; }
        public DbSet<Departments> Departments { get ; set; }
        public DbSet<Employees> Employees { get; set; }
    }
}
