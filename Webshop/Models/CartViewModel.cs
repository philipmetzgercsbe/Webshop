using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webshop.Models
{
    public class CartViewModel
    {
        //Per request empty
        //TODO: CartController with AddCart BuyCart ChangeAmount(Product product) 
        //TODO: CSHTML ViewCart Displays all items in Cart(User user)
        public List<Product> Products { get; set; }
        [Range(1,1000),Display(Name = "Amount")]
        public int ProductAmount { get; set; }
        [Range(1,Int32.MaxValue),Display(Name = "Items in Cart")]
        public int AmountOfItems { get; set; } //this property displays Products.count 
        [Display(Name = "Totalprice"),DataType(DataType.Currency)]
        public double TotalPrice { get; set; } //foreach item.price in cart Totalprice += item.price
        //only required for CartController 
        public long userId { get; set; }
    }
}
