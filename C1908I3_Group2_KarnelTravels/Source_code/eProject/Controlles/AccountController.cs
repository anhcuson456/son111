using eProject.Models;
using eProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProject.Controlles
{
    [Route("account")]
    public class AccountController : Controller
    {
        private AccountService accountService;
        public AccountController(AccountService _accountService)
        {
            accountService = _accountService;
        }

        [HttpGet]
        [Route("login")]
        public IActionResult login()
        {
            return View();
        }
        [HttpPost]
        [Route("login")]
        public IActionResult Login(string username, string password)
        {
            var account = accountService.Login(username, password);
            if (account == null)
            {
                ViewBag.account = "Username or password fails";
                return View("login");
            }
            else
            {
                HttpContext.Session.SetString("username", username);
                if (account.Rol == "admin")
                {
                    return RedirectToAction("index", "dashboard", new { area = "admin" });
                }
                else
                {
                    return RedirectToAction("index", "home");
                }
            }
        }


        [Route("logout")]
        public IActionResult Logout()
        {
            return RedirectToAction("Login");
        }

        [HttpGet]
        [Route("profile")]
        public IActionResult Profile()
        {
            var username = HttpContext.Session.GetString("username");
            var account = accountService.findUser(username);
            return View("Profile", account);
        }
        [HttpPost]
        [Route("profile")]
        public IActionResult Profile(Account account)
        {
            var username = HttpContext.Session.GetString("username");
            var currentAccount = accountService.findUser(username);
            if (!string.IsNullOrEmpty(account.Pass))
            {
                currentAccount.Pass = BCrypt.Net.BCrypt.HashString(account.Pass);
            }
            currentAccount.Username = account.Username;
            currentAccount.Name = account.Name;
            currentAccount.Addr = account.Addr;
            currentAccount.Phone = account.Phone;
            currentAccount.Rol = account.Rol;
            accountService.Edit(currentAccount);
            return RedirectToAction("index","home");
        }


        [HttpGet]
        [Route("register")]
        public IActionResult Register()
        {
            return View("Register", new Account());
        }
        [HttpPost]
        [Route("register")]
        public IActionResult Register(Account account,string username)
        {
            if (accountService.Check(username))
            {
                TempData["msguser"] = "<script>alert('Someone already uses this username, please change it .');</script>";
            }
            else
            {
                account.Pass = BCrypt.Net.BCrypt.HashString(account.Pass);
                account.Rol = "user";
                accountService.Register(account);
            }
            return RedirectToAction("login");
        }

    }
}
