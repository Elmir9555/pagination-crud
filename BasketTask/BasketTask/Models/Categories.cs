﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketTask.Models
{
    public class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CategoryProducts> CategoryProducts { get; set; }
    }
}
