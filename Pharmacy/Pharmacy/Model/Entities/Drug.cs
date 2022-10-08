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
        [Key]
        public int DrugId { get; set; }
        [Required]
        public string? DrugName { get; set; }
        public string? DrugCode { get; set; }
        [Required]
        public DateTime ExpireDate { get; set; }
        [Required]
        public decimal Price { get; set; }
        public int Quantity { get; set; }= 1;

        public int ManufacturerId { get; set; }


    }
}
