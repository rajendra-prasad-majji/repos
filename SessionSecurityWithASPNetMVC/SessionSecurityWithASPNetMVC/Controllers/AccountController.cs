using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SessionSecurityWithASPNetMVC.ViewModels;
using SessionSecurityWithASPNetMVC.Models;

// Step#1 :: Deleted default Controllers and Views
// Step#2 :: Created new Account class with username, password and list of roles.
// Step#3 :: Created Account Controller.

namespace SessionSecurityWithASPNetMVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            AccountViewModel accountViewModel = new AccountViewModel();
            accountViewModel.AccountModel = new AccountModel();
            accountViewModel.Account = null;

            return View(accountViewModel);
        }

        [HttpPost]
        public ActionResult Login(AccountViewModel accountViewModel)
        {
            ViewBag.LoginError = "";
            if (accountViewModel.AccountModel == null)
                accountViewModel.AccountModel = new AccountModel();

            Account accountRequest = accountViewModel.Account;
            if (accountRequest != null)
            {
                if (string.IsNullOrWhiteSpace(accountRequest.Username) || string.IsNullOrWhiteSpace(accountRequest.Password)
                    || accountViewModel.AccountModel.Login(accountRequest.Username, accountRequest.Password) == null)
                {
                    ViewBag.LoginError = DateTime.Now.ToLongTimeString() + " - Invalid " + nameof(accountRequest.Username) + " or " + nameof(accountRequest.Password);
                    return View("Index", accountViewModel);
                   // return RedirectToAction("Index", "Account", new { accountViewModel });
                }
                else
                {
                    return View("Success");
                }
            }
            else
            {
                ViewBag.LoginError = DateTime.Now.ToShortTimeString() + " - Data not received for " + nameof(accountRequest.Username) + " or " + nameof(accountRequest.Password);
                return View("Index");
            }

        }
    }
}