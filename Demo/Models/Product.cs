using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Producer { get; set; }
        [Required]
        public string Supplier { get; set; }
        [Required]
        [RegularExpression(@"^\d+$", ErrorMessage = "Please Enter a number")]
        public decimal Price { get; set; }
    }
}