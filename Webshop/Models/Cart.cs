using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webshop.Models
{
    public class Cart
    {
        [Key]
        public long CartID;
        //EF will create Product_Cart and Cart_User
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
