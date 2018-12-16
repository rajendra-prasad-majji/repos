using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SessionSecurityWithASPNetMVC.Models;

namespace SessionSecurityWithASPNetMVC.ViewModels
{
    public class AccountViewModel
    {
        // public AccountModel AccountModel { get; set; }
        public Account Account { set; get; }
        public AccountModel AccountModel { set; get; }

    }
}