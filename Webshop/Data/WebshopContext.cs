using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Bogus;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Webshop.Models
{
    public class WebshopContext : IdentityDbContext<IdentityUser>
    {
        public WebshopContext(DbContextOptions<WebshopContext> options)
            : base(options)
        {
        }

       
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            var product = new Product();



            var ProductFaker = new Faker<Product>()
                .RuleFor(a => a.ProductID, () => product.ProductID++)
                .RuleFor(a => a.Name, t => t.Lorem.Word())
                .RuleFor(a => a.Imagepath, t => t.Image.Image())
                .RuleFor(a => a.Price, t => t.Random.Double(1, 250.0))
                .RuleFor(a => a.Stock, t => t.Random.Int(1, 1000));



        }

    }
}
