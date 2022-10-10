using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pharmacy.Dtos;
using Pharmacy.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Services
{
    public class UserServices
    {
        public string CreateUser(UserDto userDto)
        {
            using (var Db = new Model.AppDbContext())
            {
                if(Db.Users.Any(o => o.UserName == userDto.UserName))
                {
                    return "اسم المستخدم تم استخدامة من قبل";
                }

                var user = new User();

                user.UserId = Db.Users.Any() ? Db.Users.Max(o => o.UserId) + 1 : 1;
                user.FirstName = userDto.FirstName;
                user.LastName = userDto.LastName;
                user.UserName = userDto.UserName;
                user.Password = userDto.Password;
                user.PhoneNum1 = userDto.PhoneNum1;
                user.PhoneNum2 = userDto.PhoneNum2;
                user.Address = userDto.Address;

                 Db.Users.Add(user);
               if(Db.SaveChanges() == 0)
                {
                    return "مشكلة فى حفظ البيانات";
                }
            }

            return "تم حقظ البيانات بنجاح";
            
        }
    }
}
