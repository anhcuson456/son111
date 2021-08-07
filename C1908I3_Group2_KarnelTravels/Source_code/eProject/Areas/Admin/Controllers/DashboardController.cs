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
    [Route("admin")]
    [Route("admin/dashboard")]
    public class DashboardController : Controller
    {
        private IWebHostEnvironment webHostEnvironment;
        private AccountService accountService;
        public DashboardController(AccountService _accountService, IWebHostEnvironment _webHostEnvironment)
        {
            accountService = _accountService;
            webHostEnvironment = _webHostEnvironment;
        }
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
