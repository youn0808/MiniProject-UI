using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Models.Account
{
    /*
    to be able to register and login so this is going to be the one that matches up our table.
    because this is one thats going to be loaded from the data base and also this is going to be used 
    But When we are sending it to the front end we are going to be using "ApplicationUser class" 
    Becase we don't want to save the password on the database. we are just going to calculater the tokens and we will be sent to the front end
    */
    public class ApplicationUserIdentity
    {
        public int ApplicationUserId { get; set; }
        public string Username { get; set; }
        public string NormalizedUsername { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public string Fullname { get; set; }
        public string PasswordHash { get; set; }
    }
}
