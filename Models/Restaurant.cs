﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace retaurant_info.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }

       
        public virtual ApplicationUser Owner { get; set; }
    }
}
