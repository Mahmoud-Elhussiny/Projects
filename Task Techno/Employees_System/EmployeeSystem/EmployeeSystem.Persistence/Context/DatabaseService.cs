﻿using EmployeeSystem.Aplication.Interfaces;
using EmployeeSystem.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem.Persistence.Context
{
    public partial class DatabaseService : DbContext, IDatabaseService
    {

        public DatabaseService()
        {

        }

        public DatabaseService(DbContextOptions<DatabaseService> options):base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=Company_System;user=root;password=root");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.isAdmin).HasDefaultValue(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasData(new Employee
                {
                    Id = 1,
                    Name = "admin",
                    UserName = "admin",
                    password = "admin123",
                    address = "Cairo",
                    isAdmin = true,
                });
            });
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

     
    }
}