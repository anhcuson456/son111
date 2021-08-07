using eProject.Models;
using eProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProject.Areas.User.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        private AccountService accountService;
        public HomeController(AccountService _accountService)
        {
            accountService = _accountService;
        }

        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("about")]
        public IActionResult About() 
        {
            ViewBag.acc = accountService.CountAcc().ToString();
            ViewBag.tou = accountService.CountTou().ToString();
            ViewBag.ser = accountService.CountSer().ToString();
            ViewBag.tra = accountService.CountTra().ToString();
            return View("About");
        }




        [HttpGet]
        [Route("contact")]
        public IActionResult Contact()
        {
            return View("contact", new Feedback());
        }
        [HttpPost]
        [Route("contact")]
        public IActionResult Contact(Feedback feedback)
        {
            accountService.Create(feedback);
            return View("index");
        }

    }
}
