using Pharmacy.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Dtos
{
    public class loginresultDto
    {
        public bool result { get; set; }

        public List<decimal>? typeAccount { get; set; } 

    }
  
}
