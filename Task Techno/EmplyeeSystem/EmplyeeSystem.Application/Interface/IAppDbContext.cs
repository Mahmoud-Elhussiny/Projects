using EmplyeeSystem.domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyeeSystem.Application.Interface
{
    public interface IAppDbContext
    {
        public DbSet<Companies> Companies { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Employees> Employees { get; set; }
    }
}
