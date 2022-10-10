using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Model.Entities
{
    [Table("Order_Items")]
    public class Order_Item
    {
        [Key]
        [Column(TypeName = "decimal(7,0)")]
        public decimal OrderItemId { get; set; }
        [Required]
        [Column(TypeName = "decimal(7,0)")]
        public decimal OrderId { get; set; }
        [Required]
        [Column(TypeName = "decimal(7,0)")]
        public decimal DrugId { get; set; }

        public Order? Order { get; set; }
        public Drug? Drug { get; set; }
    }
}
