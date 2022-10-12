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
    public static class UserServices
    {
        public static string CreateUserservice(UserDto userDto)
        {
            using (var Db = new Model.AppDbContext())
            {
                if(Db.User.Any(o => o.UserName == userDto.UserName))
                {
                    return "اسم المستخدم تم استخدامة من قبل";
                }

                var user = new User();

                user.UserId = Db.User.Any() ? Db.User.Max(o => o.UserId) + 1 : 1;
                user.FirstName = userDto.FirstName;
                user.LastName = userDto.LastName;
                user.UserName = userDto.UserName;
                user.Password = userDto.Password;
                user.PhoneNum1 = userDto.PhoneNum1;
                user.PhoneNum2 = userDto.PhoneNum2;
                user.Address = userDto.Address;

                 Db.User.Add(user);
               if(Db.SaveChanges() == 0)
                {
                    return "مشكلة فى حفظ البيانات";
                }
            }

            return "تم حقظ البيانات بنجاح";
            
        }

        public static bool Loginservice(string username , string pass)
        {
            using(var Db = new Model.AppDbContext())
            {
                var user = Db.User
                    .Where(o=>o.UserName == username && o.Password == pass).FirstOrDefault();
                if(user == null) { return false; }

                return true;
            }
        }

    }
}
