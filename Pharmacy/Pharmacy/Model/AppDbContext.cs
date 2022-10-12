using Microsoft.EntityFrameworkCore;
using Pharmacy.Model.Configrations;
using Pharmacy.Model.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Model
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public AppDbContext()
        {

        }

        public DbSet<User>? User { get; set; }
        public DbSet<User_Account>? User_Accounts { get; set; }
        public DbSet<Account>? Accounts { get; set; }
        public DbSet<Drug>? Drugs { get; set; }
        public DbSet<Order_Item>? order_Items { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //options.UseSqlite("FileName=PharmacyDB", option =>
            //{
            //    option.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            //});
            //base.OnConfiguring(options);

            // options.UseSqlite(ConfigurationManager.ConnectionStrings["PharmacyDatabase"].ConnectionString);
            options.UseSqlite("Data Source=D:\\MyWork\\Projects\\Pharmacy\\Pharmacy\\PharmacyDB.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new UserAccount_EntityTypeConfigrations().Configure(modelBuilder.Entity<User_Account>());
            new Drug_EntityTypeConfigration().Configure(modelBuilder.Entity<Drug>());
            new User_EntityTypeConfigration().Configure(modelBuilder.Entity<User>());
            new Account_EntityTypeConfigration().Configure(modelBuilder.Entity<Account>());
            new Manufacturer_EntityTypeConfigration().Configure(modelBuilder.Entity<Manufacturer>());

        }
    }
}
