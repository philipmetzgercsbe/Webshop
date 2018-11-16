using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Webshop.Models
{
    public class User : IdentityUser
    {
        
        [Key]
        public long UserID { get; set; }
        [Required,Display(Name = "Username")]
        public string Username { get; set; }
        [Required,Display(Name = "Password")]
        public string Password { get; set; }

    }
}
