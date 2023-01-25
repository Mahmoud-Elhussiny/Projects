using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Dtos;
using Pharmacy.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Services
{
    public static class DrugServices
    {
        public static string CreateDrug(DrugDto drugDto)
        {

            using (var Db = new Model.AppDbContext())
            {

                var result = Db.Drugs.Any(o => o.DrugCode == drugDto.DrugCode && o.ExpireDate == drugDto.ExpireDate);

                if (result)
                {
                    return "تم اضافة نفس المنتج بنفس ناريخ الانتهاء من قبل";
                }

                var drug = new Drug();
                drug.DrugId = Db.Drugs.Any() ? Db.Drugs.Max(o => (int)o.DrugId) + 1 : 1;
                drug.DrugName = drugDto.DrugName;
                drug.DrugCode = drugDto.DrugCode;
                drug.numofpices = drugDto.numofpices;
                drug.ExpireDate = drugDto.ExpireDate;
                drug.Quantity = drugDto.Quantity;
                drug.Price = drugDto.Price;
                drug.ManufacturerId = drugDto.ManufacturerId;
                drug.CatigoryId = drugDto.CatigoryId;
                if (drugDto.numofpices != null)
                    drug.totalNumofPices = drugDto.Quantity * drugDto.numofpices;
                Db.Drugs.Add(drug);
                if (Db.SaveChanges() == 0)
                {
                    return "مشكلة اثناء حفظ البيانات";
                }
                return "تم حفظ البيانات بنجاح";

            }


        }

        public static DrugDto searchByDrugCode(string drugCode)
        {
            var Db1 = new Model.AppDbContext();
            using (var Db = new Model.AppDbContext())
            {
                var result = Db.Drugs.Include(o => o.Catigory).Where(o => o.DrugCode == drugCode).FirstOrDefault();
                var output = new DrugDto();
               
                if (result == null)
                {
                    output.status = false;
                    output.Message = "كود المنتج اللذى ادخلته غير صحيح";
                    return output;
                }
                
                if (result.Quantity == 0)
                {
                    output.status = false;
                    output.Message = "نفذت الكميه لهذا المنتج";
                    return output;
                }
                output.DrugId = result.DrugId;
                output.DrugName = result.DrugName;
                output.DrugCode = result.DrugCode;
                output.Price = result.Price;
                output.CatigoryName = result.Catigory.CatigoryName;
                output.numofpices = result.numofpices;
                output.Quantity = result.Quantity;
                return output;
                

            }
        }


        public static DrugDto searchByDrugName(string drugName)
        {
            using (var Db = new Model.AppDbContext())
            {

                var output = new DrugDto();
                var result = Db.Drugs.Include(o=>o.Catigory).Where(o => o.DrugName == drugName).FirstOrDefault();
                if (result == null)
                {
                    output.status = false;
                    output.Message = "اسم المنتج اللذى ادخلته غير صحيح";
                    return output;
                }
                if (result.Quantity == 0)
                {
                    output.status = false;
                    output.Message = "نفذت الكميه لهذا المنتج";
                    return output;
                }
                result.Quantity -= 1;
                Db.Drugs.Update(result);
                Db.SaveChanges();

                output.DrugCode = result.DrugCode;
                output.DrugName = result.DrugName;
                output.Price = result.Price;
                output.CatigoryName = result.Catigory.CatigoryName;
                return output;

            }
        }
    }
}
