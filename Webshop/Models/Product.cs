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
        [Required,Display(Name = "Name")]
        public string Name { get; set; }
        [Required,Display(Name = "Image")]
        public string Imagepath { get; set; }
        [Required, Display(Name = "Price")]
        public double Price { get; set; }
        [Required,Display(Name = "Stock")]
        public int Stock { get; set; }
    }
}
