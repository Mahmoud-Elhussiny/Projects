using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Model.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        public decimal UserId { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? UserName { get; set; }
        [Required]
        public string? Password { get; set; }
        public string? PhoneNum1 { get; set; }
        public string? PhoneNum2 { get; set; }
        public string? Address { get; set; }
    }
}
