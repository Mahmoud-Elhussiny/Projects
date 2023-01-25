using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyeeSystem.domain
{
    public class Departments
    {

        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }="";

        public List<Employees> Employees { get; set; }


        [ForeignKey("Companies")]
        public int CompaniesId { get; set; }
        public Companies Companies { get; set; }


    }
}
