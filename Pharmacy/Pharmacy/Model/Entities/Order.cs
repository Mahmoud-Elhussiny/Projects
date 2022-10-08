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
        public int OrderId { get; set; }
        [Required]
        public DateTime OrdereDate { get; set; }

        public decimal TotalPrice { get; set; }

        [Required]
        public int UserId { get; set; }
        
        public User? User { get; set; }
        List<Order_Item>? items;

    }
}
