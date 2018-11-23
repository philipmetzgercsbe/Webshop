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
            var prodamounts = _context.Carts.Include(a => a.ProductAmount).Where(a => a.User.UserID == viewModel.userId).ToList();
            viewModel.Products = carts[0].Products.ToList();
            foreach (var product in viewModel.Products)
            {
                viewModel.ProductAmount = prodamounts[0].ProductAmount;
            }
            if (viewModel.Products == null)
            {
                ViewData["Message"] = "No items in your cart";
            }
            return View(viewModel);
        }

//        [HttpPost]
//        public IActionResult ChangeAmount(int id,int newAmount)
//        {
//           CartViewModel viewModel = new CartViewModel();
//            
//            var cart =  _context.Carts
//                .FirstOrDefault(m => m.CartID == id);
//            var product = _context.Products
//                .FirstOrDefault(m => m.ProductID == cart.ProductFK);
//
//            if (cart != null)
//            {
//                var productAmount = cart.ProductAmount;
//                var productStock = product.Stock;
//                if ( productAmount <= productStock && productAmount > 0)
//                {               
//                        viewModel.ProductAmount++;
//                }
//                if (productAmount == productStock)
//                {
//                    return LocalRedirect("Cart");
//                }
//
//               
//            }
//            return viewModel.ProductAmount++;
//        }
//        //Do the same for DecreaseAmount
//        public IActionResult AddProduct(int id)
//        {
//         //Check if Product is in Cart else add 
//        }
    }
}