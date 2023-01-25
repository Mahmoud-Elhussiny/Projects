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
                if (Db.User.Any(o => o.UserName == userDto.UserName))
                {
                    return "اسم المستخدم تم استخدامة من قبل";
                }

                var user = new User();

                user.UserId = Db.User.Any() ? Db.User.Max(o => (int)o.UserId) + 1 : 1;
                user.FirstName = userDto.FirstName;
                user.LastName = userDto.LastName;
                user.UserName = userDto.UserName;
                user.Password = userDto.Password;
                user.PhoneNum1 = userDto.PhoneNum1;
                user.PhoneNum2 = userDto.PhoneNum2;
                user.Address = userDto.Address;


                Db.User.Add(user);
                var userAccount = new User_Account();
                var count = Db.User_Accounts.Any() ? Db.User_Accounts.Max(o => (int)o.Id) + 1 : 1;
                if (userDto.IsUser)
                {
                    userAccount.Id = count++;
                    userAccount.UserId = user.UserId;
                    userAccount.AccountId = 2;

                    Db.User_Accounts.Add(userAccount);
                }
                if (userDto.IsAdmin)
                {
                    userAccount.Id = count++;
                    userAccount.UserId = user.UserId;
                    userAccount.AccountId = 1;

                    Db.User_Accounts.Add(userAccount);
                }
                
                if (Db.SaveChanges() == 0)
                {
                    return "مشكلة فى حفظ البيانات";
                }
            }

            return "تم حقظ البيانات بنجاح";

        }

        public static loginresultDto Loginservice(string username, string pass)
        {
            using (var Db = new Model.AppDbContext())
            {
                loginresultDto loginresult = new loginresultDto();
                var user = Db.User
                    .Where(o => o.UserName == username && o.Password == pass).FirstOrDefault();
                if (user == null) {
                    loginresult.result = false;
                    return loginresult ; 
                }
                loginresult.result = true;
                var useraccount = Db.User_Accounts.Where(o => o.UserId == user.UserId);
                loginresult.typeAccount = new List<decimal>();
                foreach(var account in useraccount)
                {
                    loginresult.typeAccount.Add(account.AccountId);
                }

                return loginresult;
            }
        }
       
        public static List<Account> GetAllAccounts()
        {
            using(var db = new Model.AppDbContext())
            {
                return db.Accounts.ToList();
            }
        }

    }
}
