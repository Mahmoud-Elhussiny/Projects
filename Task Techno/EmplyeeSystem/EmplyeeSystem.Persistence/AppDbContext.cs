using EmplyeeSystem.Application.Interface;
using EmplyeeSystem.domain;
using Google.Protobuf.WellKnownTypes;
using Microsoft.EntityFrameworkCore;
using Mysqlx.Notice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace EmplyeeSystem.Persistence
{
    public partial class  AppDbContext : DbContext, IAppDbContext
    {
        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=employeeSystem;user=root;password=root");
        }

        public DbSet<Companies> Companies { get; set; }
        public DbSet<Departments> Departments { get ; set; }
        public DbSet<Employees> Employees { get; set; }
    }
}
