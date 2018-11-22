using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
//            viewModel.Products = _context.Carts.Include(a => a.Products).Where(a => a.User == a.User).Join; 
                   
            return View();
        }
    }
}