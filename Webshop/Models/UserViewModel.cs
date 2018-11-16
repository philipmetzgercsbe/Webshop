using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webshop.Models
{
    public class UserViewModel
    {
        public IEnumerable<User> Users;
        //Per request empty
        //This VM displays the saved User Information Email -> Username -> password as reversed Identity.passwordhash
        [EmailAddress, DataType(DataType.EmailAddress),Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Username"),StringLength(256)]
        public string UserName { get; set; }
        [DataType(DataType.Password),StringLength(200)]
        private string Password { get; set; }
        
    }
}
