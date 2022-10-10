using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Model.Entities
{
    [Table("User_Accounts")]
    public class User_Account
    {

        [Column(TypeName = "decimal(7,0)")]
        public decimal Id { get; set; }
        [Required]
        [Column(TypeName = "decimal(7,0)")]
        public decimal UserId { get; set; }
        [Required]
        [Column(TypeName = "decimal(7,0)")]
        public decimal AccountId { get; set; }

        public Account? Account { get; set; }
        public User? User { get; set; }
    }
}
