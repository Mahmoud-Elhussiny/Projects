using Microsoft.EntityFrameworkCore;
using Pharmacy.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Model
{
    public class AppDbContext:DbContext
    {

        public DbSet<User>? Users { get; set; }
        public DbSet<User_Account>? User_Accounts { get; set; }
        public DbSet<Account>? Accounts { get; set; }
        public DbSet<Drug>? Drugs { get; set; }
        public DbSet<Order_Item>? order_Items { get; set; }
    }
}
