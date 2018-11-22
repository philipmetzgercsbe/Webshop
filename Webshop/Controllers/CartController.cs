using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Webshop.Migrations;
using Webshop.Models;

namespace Webshop.Controllers
{
    public class CartController : Controller
    {

        private readonly WebshopContext _context;

        public CartController(WebshopContext context)
        {
            _context = context;
        }
        public IActionResult Cart()
        {
            CartViewModel viewModel = new CartViewModel();
            //Test Query of User Cart
       
            viewModel.Products = _context.Carts.Include(a => a.Products).Where(a => a.User.UserID == User.Identity.Name).Join("Products").Where(; 
                   
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult IncreaseAmount(int id)
        {
           CartViewModel viewModel = new CartViewModel();
            
            var cart =  _context.Carts
                .FirstOrDefault(m => m.CartID == id);
            var product = _context.Products
                .FirstOrDefault(m => m.ProductID == cart.ProductFK);

            if (cart == null)
            {
                ViewData["Message"] = "No Items in your Cart";
                
            }

            var productAmount = cart.ProductAmount;
            var productStock = product.Stock;
            if ( productAmount < productStock )
            {
               
               viewModel.productAmount++;
            }
            if (productAmount == productStock)
            {
                return 
            }
            

        }
        //Do the same for DecreaseAmount
        
    }
}