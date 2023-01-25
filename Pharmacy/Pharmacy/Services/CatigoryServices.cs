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
    public static class CatigoryServices
    {
        public static string CreateCatigory(string Catigoryname,string? Desc = null)
        {
            using(var Db = new Model.AppDbContext())
            {
                var catigory = new Catigory();
                catigory.CatigoryId = Db.catigories.Any() ? Db.catigories.Max(o => (int)o.CatigoryId) + 1:1;
                catigory.CatigoryName = Catigoryname;
                catigory.Description = Desc;
                Db.catigories.Add(catigory);
                if (Db.SaveChanges() == 0)
                {
                    return "مشكلة فى حفظ البيانات";
                }
                return "تم حفظ البيانات بنجاح";
            }
        }


        public static List<CatigoryDto> GetAllCatigories()
        {
            using(var Db = new Model.AppDbContext())
            {
                var catigories = Db.catigories.Select(o=>new CatigoryDto()
                {
                    CatigoryId = o.CatigoryId,
                    CatigoryName = o.CatigoryName,
                    Description = o.Description
                }).ToList();

                return catigories;

            }
        }

    }
}
