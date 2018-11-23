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
using Product = Webshop.Models.Product;

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

           
            var carts = _context.Carts.Include(a => a.Products).Where(a => a.User.UserID == viewModel.userId).ToList();
            viewModel.Products = carts[0].Products.ToList(); //null check nicht vergessen
            if (viewModel.Products == null)
            {
                ViewData["Message"] = "No items in your cart";
            }
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult ChangeAmount(int id,int newAmount)
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

            if (cart != null)
            {
                var productAmount = cart.ProductAmount;
                var productStock = product.Stock;
                if ( productAmount <= productStock && productAmount > 0)
                {               
                        viewModel.ProductAmount++;
                }
                if (productAmount == productStock)
                {
                    ViewData["Message"] = "No Items in your Cart";
                }

                return newAmount;
            }
        }
        //Do the same for DecreaseAmount
        
    }
}