using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Model.Entities
{
    [Table("Manufacturers")]
    public class Manufacturer
    {
        [Key]
        public int ManufacturerId { get; set; }
        [Required]
        public string? ManufacturerName { get; set; }
        public string? Address { get; set; }
        public string? PhoneNum1 { get; set; }
        public string? PhoneNum2 { get; set; }
    }
}
