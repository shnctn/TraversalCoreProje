﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SubAbout
    {
        [Key]
        public int SubAbotID { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
    }
}