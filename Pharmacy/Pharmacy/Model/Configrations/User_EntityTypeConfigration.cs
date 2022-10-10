using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pharmacy.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Model.Configrations
{
    internal class User_EntityTypeConfigration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(k=> new {k.UserId});
            builder.HasIndex(x => x.UserName).IsUnique();

            builder.HasData(
                new User
                {
                    UserId = 1,
                    FirstName = "Mahmoud",
                    LastName = "Hussein",
                    UserName = "asd123",
                    Password = "12345"
                }
                );

        }



    }
}
