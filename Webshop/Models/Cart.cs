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
        public long CartID { get; set; }
        //EF will create Product_Cart and Cart_User
        public User User { get; set; }  //Cart_UserFK
        public int ProductAmount { get; set; }
        public virtual ICollection<Product> Products { get; set; } //Product_CartFK
    }
}
