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
        public long ProductID { get; set; }
        [Required,Display(Name = "Name")]
        public string Name { get; set; }
        [Required,Display(Name = "Image")]
        public string Imagepath { get; set; }
        [Required,StringLength(500),Display(Name = "Description")]
        public string Description { get; set; }
        [Required, Display(Name = "Price")]
        public double Price { get; set; }
        [Required,Display(Name = "Stock")]
        public int Stock { get; set; }
    }
}
