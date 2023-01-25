using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyeeSystem.domain
{
    public class Employees
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string name { get; set; } = "";
        
        public string? address { get; set; }

        public List<Departments> Departments { get; set; }

    }
}
