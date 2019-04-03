﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Producer { get; set; }
        public string Supplier { get; set; }
        public decimal Price { get; set; }
    }
}