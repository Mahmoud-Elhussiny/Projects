using Pharmacy.Dtos;
using Pharmacy.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Services
{
    public static class ManufacturerServices
    {
        public static string CreateManufacturer(ManufacturerDto manufacturerDto)
        {
            using(var Db = new Model.AppDbContext())
            {
                var manufact = Db.Manufacturers
                    .Where(o => o.ManufacturerName == manufacturerDto.ManufacturerName).FirstOrDefault();
                if(manufact != null)
                {
                    return "هذة الشركة موجودة بالفعل";
                }

                manufact = new Manufacturer();

                manufact.ManufacturerId = Db.Manufacturers.Any()?Db.Manufacturers.Max(o => (int)o.ManufacturerId) + 1 : 1;
                manufact.ManufacturerName = manufacturerDto.ManufacturerName;
                manufact.Address = manufacturerDto.Address;
                manufact.PhoneNum1 = manufacturerDto.PhoneNum1;
                manufact.PhoneNum2 = manufact.PhoneNum2;

                Db.Manufacturers.Add(manufact);

                if (Db.SaveChanges() == 0)
                {
                    return "مشكله فى حفظ البيانات";
                }

                return "تم حفظ البيانات بنجاح";

            }
        }


        public static List<ManufacturerDto> GetAllManufacturers()
        {
            using(var Db = new Model.AppDbContext())
            {
                return Db.Manufacturers.Select(o => new ManufacturerDto()
                {
                    ManufacturerId = o.ManufacturerId,
                    ManufacturerName = o.ManufacturerName
                }).ToList();
            }
        }
    }
}
