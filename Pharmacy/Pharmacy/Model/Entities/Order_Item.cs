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
        public decimal OrderItemId { get; set; }
        [Required]
        public decimal OrderId { get; set; }
        [Required]
        public decimal DrugId { get; set; }

        public bool Type { get; set; } = true;
        public decimal Price { get; set; }

        public Order? Order { get; set; }
        public Drug? Drug { get; set; }
    }
}
