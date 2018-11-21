using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webshop.Models
{
    public class ProductViewModel
    {
        //Per request empty
        //This VM displays Name -> Image -> Product description -> Price in Currency -> Stock
        public string Name { get; set; }
        [FileExtensions(Extensions = "jpg,png,gif,svg")]
        public string ImagePath { get; set; }
        [StringLength(500),MinLength(10)]
        public string Description { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        [Range(1, 500)]
        public int ProductStock { get; set; }

        private ICollection<Product> Products { get; set; }

    }
}
