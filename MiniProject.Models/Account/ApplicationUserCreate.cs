using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Models.Account
{
    //ApplicationUserCreate will also have what ApplicationUserLogin has which is user name and password
    public class ApplicationUserCreate : ApplicationUserLogin
    {
        [MinLength(10, ErrorMessage = "It should be at least 10 characters")]
        [MaxLength(30, ErrorMessage = "It should not be over 30 characters")]
        public string Fullname { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [MaxLength(30, ErrorMessage = "Email should not be over 30 characters")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

    }
}
