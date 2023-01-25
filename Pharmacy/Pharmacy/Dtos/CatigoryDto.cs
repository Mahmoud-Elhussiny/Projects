using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Dtos
{
    public class CatigoryDto
    {
        public decimal CatigoryId { get; set; }
        public string CatigoryName { get; set; }
        public string? Description { get; set; }

    }
}
