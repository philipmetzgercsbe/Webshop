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
            var prodamounts = _context.Carts.Include(a => a.ProductAmount).Include(a => a.Products)
                .Where(a => a.User.UserID == viewModel.userId).ToList();
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

        [HttpGet]
        public IActionResult ChangeAmount(int id, int newAmount, bool add)
        {
            CartViewModel viewModel = new CartViewModel();

            var cart = _context.Carts
                .FirstOrDefault(m => m.CartID == id);
            var cartItems = cart.Products.ToList();
            var product = _context.Products
                .FirstOrDefault(m => m.ProductID == cartItems.Find(a => a.ProductID == id).ProductID);

            if (add == true && cart != null)
            {
                var productAmount = cart.ProductAmount;
                var productStock = product.Stock;
                if (productAmount <= productStock && productAmount > 0)
                {
                    viewModel.ProductAmount++;
                    return View("Cart", viewModel);
                }

                if (productAmount == productStock)
                {
                    return View("Cart", viewModel);
                }

                return View("Cart",viewModel);


            }
            else
            {
                var productAmount = cart.ProductAmount;
                var productStock = product.Stock;
                if (productAmount <= productStock && productAmount > 0)
                {
                    viewModel.ProductAmount--;
                    return View("Cart", viewModel);
                }

                if (productAmount == 1)
                {
                    return View("Cart",viewModel);
                }

                return View("Cart",viewModel);
            }

        }
    

       
        public IActionResult AddProduct(int id)
        {

            CartViewModel viewModel = new CartViewModel();
            var carts = _context.Carts.Include(a => a.Products).Where(a => a.User.UserID == viewModel.userId).ToList();
            
            var prodInCart = carts[0].Products.ToList();
            if (prodInCart.Find(a => a.ProductID == id).ProductID.CompareTo(long.Parse(id)))
            {
                ViewData["Message"] = "Product already in Cart";
                return View("Cart",viewModel);
            }
            carts[0].Products.Add(_context.Products.Find(id));
            return View("Cart", viewModel);
            //Check if Product is in Cart else add 
        }
    }
}