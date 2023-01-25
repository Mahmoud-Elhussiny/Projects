using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pharmacy.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Model.Configrations
{
    public class Account_EntityTypeConfigration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasIndex(x => x.AccountName).IsUnique();

            builder.HasData(
                new Account
                {
                    AccountId = 1,
                    AccountName = "مشرف النظام"
                },new Account
                {
                    AccountId = 2,
                    AccountName = "مستخدم"
                });
        }
    }
}
