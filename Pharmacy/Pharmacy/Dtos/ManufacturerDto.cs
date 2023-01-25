using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Dtos
{
    public class ManufacturerDto
    {
        public decimal? ManufacturerId { get; set; }
        public string? ManufacturerName { get; set; }
        public string? Address { get; set; }
        public string? PhoneNum1 { get; set; }
        public string? PhoneNum2 { get; set; }
    }
}
