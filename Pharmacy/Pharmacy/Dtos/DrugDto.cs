using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Pharmacy.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Dtos
{
    public class DrugDto
    {
        public decimal DrugId { get; set; }
        [Required]
        public string? DrugName { get; set; }
        [Required]
        public string? DrugCode { get; set; }
        [Required]
        public DateTime ExpireDate { get; set; }
        public int? numofpices { get; set; }
        [Required]
        public decimal Price { get; set; }
        public int Quantity { get; set; } = 1;
        public decimal? ManufacturerId { get; set; }
        public decimal CatigoryId { get; set; }
        public string? CatigoryName { get; set; }

        public bool status { get; set; } = true;
        public string? Message { get; set; }
        
    }
}
