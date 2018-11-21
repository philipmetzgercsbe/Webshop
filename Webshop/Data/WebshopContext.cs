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
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            var product = new Product();

            var ProductID = 1;

            var ProductFaker = new Faker<Product>()
                .RuleFor(a => a.ProductID, () => ProductID++)
                .RuleFor(a => a.Name, t => t.Commerce.ProductName())
                .RuleFor(a => a.Imagepath, t => t.Image.Image())
                .RuleFor(a => a.Description, t => t.Lorem.Text())
                .RuleFor(a => a.Price, t => t.Random.Double(1, 250.0))
                .RuleFor(a => a.Stock, t => t.Random.Int(1, 1000));

            var UserID = 1;

            var UserFaker = new Faker<User>()
                .RuleFor(a => a.UserID, () => UserID++)
                .RuleFor(a => a.Email, t => t.Internet.Email())
                .RuleFor(a => a.UserName, t => t.Internet.UserName())
                .RuleFor(a => a.PasswordHash, t => t.Internet.Password());

            var TestUsers = new List<dynamic>();
            var TestProducts = new List<dynamic>();
            var rnd = new Random();

            foreach (var products in ProductFaker.Generate(10)) //10 Products
            {
                TestProducts.Add(new
                {

                    ProductID = products.ProductID,
                    Name = products.Name,
                    Imagepath = products.Imagepath,
                    Description = products.Description,
                    Price = products.Price,
                    Stock = products.Stock
                });
            }

            foreach (var user in UserFaker.Generate(10)) //10 Users
            {
                TestUsers.Add(new
                {
                    UserID = user.UserID,
                    Id = user.Id,
                    email = user.Email,
                    userName = user.UserName,
                    password = user.PasswordHash,
                    AccessFailedCount = 0,
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = false

                });
            }
            builder.Entity<Product>().HasData(TestProducts.ToArray());
            builder.Entity<User>().HasData(TestUsers.ToArray());         
            base.OnModelCreating(builder);
        }
    }
}
