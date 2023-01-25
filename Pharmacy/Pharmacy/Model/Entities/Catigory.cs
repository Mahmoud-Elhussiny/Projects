using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Model.Entities
{
    [Table("Catigories")]
    public class Catigory
    {
        [Key]
        public decimal CatigoryId { get; set; }
        [Required]
        public string CatigoryName { get; set; }
        public string? Description { get; set; }

        public List<Drug>? Drugs { get; set; }
    }
}
