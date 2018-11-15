using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webshop.Models
{
    public class Product
    {
        [Key]
        public int ProductID;
        [Required]
        public string Name { get; set; }
        [Required]
        public string Imagepath { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
