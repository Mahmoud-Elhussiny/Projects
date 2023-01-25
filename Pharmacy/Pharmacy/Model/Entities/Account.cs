using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Model.Entities
{
    [Table("Accounts")]
    public class Account
    {
        [Key]
        public decimal AccountId { get; set; }
        [Required]
        public string? AccountName { get; set; }

    }
}
