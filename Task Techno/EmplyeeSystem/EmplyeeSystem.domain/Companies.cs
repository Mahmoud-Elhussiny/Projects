﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyeeSystem.domain
{
    public class Companies
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string location { get; set; } = "";

        public List<Departments> Departments { get; set; }
    }
}
