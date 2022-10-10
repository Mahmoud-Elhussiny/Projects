﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pharmacy.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Model.Configrations
{
    public class UserAccount_EntityTypeConfigrations : IEntityTypeConfiguration<User_Account>
    {
        public void Configure(EntityTypeBuilder<User_Account> builder)
        {
            builder.HasKey(o => new {o.UserId ,o.AccountId});
        }
    }
}
