using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Models.Account
{
    public class ApplicationUserLogin
    {
        //add Validation
        [Required(ErrorMessage = "Username is required")]
        [MinLength(5,ErrorMessage = "User Name should be at least 5 characters")]
        [MaxLength(20, ErrorMessage = "User Name should not be over 20 characters")]
        public string Username { get; set; }
        //add Validation
        [Required(ErrorMessage = "Password is required")]
        [MinLength(5, ErrorMessage = "Password should be at least 5 characters")]
        [MaxLength(20, ErrorMessage = "Password should not be over 20 characters")]
        public string Password { get; set; }


    }
}
