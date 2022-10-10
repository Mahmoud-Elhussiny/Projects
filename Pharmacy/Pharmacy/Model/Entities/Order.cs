using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Model.Entities
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [Column(TypeName = "decimal(7,0)")]
        public decimal OrderId { get; set; }
        [Required]
        public DateTime OrdereDate { get; set; }
        [Column(TypeName = "decimal(7, 2)")]
        public decimal TotalPrice { get; set; }

        [Required]
        [Column(TypeName = "decimal(7,0)")]
        public decimal UserId { get; set; }
        
        public User? User { get; set; }

        public List<Order_Item>? items { get; set; }

    }
}
