using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SessionSecurityWithASPNetMVC.Models
{
    public class Account
    {
        [Display(Name ="User Name")]
        [Required]
        [MinLength(6, ErrorMessage = "User name should be atleast 6 characters long")]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [Required]
        [MinLength(6,ErrorMessage ="Password should be atleast 6 characters long")]
        [MaxLength(10,ErrorMessage ="Password can not have more than 10 characters")]
        public string Password { get; set; }

        public string[] roles { get; set; }

        public Account()
        {
            // Default constructor.   
        }
    }
}