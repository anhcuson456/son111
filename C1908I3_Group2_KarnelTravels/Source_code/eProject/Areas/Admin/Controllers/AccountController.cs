using eProject.Models;
using eProject.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProject.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("Account")]
    public class AccountController : Controller
    {
        private IWebHostEnvironment webHostEnvironment;
        private AccountService accountService;
        public AccountController(AccountService _accountService, IWebHostEnvironment _webHostEnvironment)
        {
            accountService = _accountService;
            webHostEnvironment = _webHostEnvironment;
        }

        [HttpGet]
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.account = accountService.findAll();
            return View();
        }

        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            accountService.Delete(id);
            return RedirectToAction("index");
        }

        [HttpGet]
        [Route("createAcc")]
        public IActionResult CreateAcc()
        {
            return View("Create", new Account());
        }

        [HttpPost]
        [Route("createAcc")]
        public IActionResult CreateAcc(Account account)
        {
            account.Pass = BCrypt.Net.BCrypt.HashString(account.Pass);
            accountService.CreateAcc(account);
            return RedirectToAction("index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            var account = accountService.find(id);
            return View("Edit", account);
        }
        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(int id, Account account)
        {
            var currentAccount = accountService.find(id);
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
            return RedirectToAction("index");
        }
        [Route("searchbyName")]
        public IActionResult SearchbyName([FromQuery(Name = "name")] string name)
        {
            ViewBag.account = accountService.SearchByName(name);
            return View("Index");
        }
    }
}
