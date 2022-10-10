using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Model.Entities
{
    [Table("Drugs")]
    public class Drug
    {
        [Column(TypeName = "decimal(7,0)")]
        public decimal DrugId { get; set; }
        [Required]
        public string? DrugName { get; set; }
        public string? DrugCode { get; set; }
        [Required]
        public DateTime ExpireDate { get; set; }
        [Required]
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        public int Quantity { get; set; }= 1;
        [Column(TypeName = "decimal(7,0)")]
        public decimal? ManufacturerId { get; set; }
        public Manufacturer? Manufacturer { get; set; }


    }
}
