using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SessionSecurityWithASPNetMVC.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class AccountModel
    {
        /// <summary>
        /// 
        /// </summary>
        public List<Account> AccountList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public AccountModel()
        {
            AccountList = new List<Account>
            {
                new Account {  Username = "SuperAdmin", Password="Password123$", roles = new string[] { "SuperAdmin", "Admin", "Employee" } } ,
                new Account {  Username = "Administrator", Password="Password123$", roles = new string[] { "Admin", "Employee" } },
                new Account {  Username = "Employee", Password="Password123$", roles = new string[] { "Employee" } }
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public Account FindAccount(string username)
        {

            if (AccountList != null && AccountList.Count > 0)
            {
                return AccountList.Where(a => a.Username.Equals(username)).FirstOrDefault();

            }
            else
            {
                // No Account data setup
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Account Login(string username, string password)
        {

            if (AccountList != null && AccountList.Count > 0)
            {
                Account account = AccountList.Where(a => a.Username.Equals(username) && a.Password.Equals(password)).FirstOrDefault();
                return account;

            }
            else
            {
                // No Account data setup
                return null;
            }
        }
    }
}