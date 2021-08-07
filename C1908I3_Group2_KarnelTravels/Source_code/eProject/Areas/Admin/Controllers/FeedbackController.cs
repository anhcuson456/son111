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
    [Route("admin/feedback")]
    public class FeedbackController : Controller
    {
        private IWebHostEnvironment webHostEnvironment;
        private AccountService accountService;

        public FeedbackController(AccountService _accountService, IWebHostEnvironment _webHostEnvironment)
        {
            accountService = _accountService;
            webHostEnvironment = _webHostEnvironment;
        }
        [Route("index")]
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.feedback = accountService.findAllFee();
            return View();
        }
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            accountService.DeleteFee(id);
            return RedirectToAction("index");
        }

        [Route("indexcom")]
        [HttpGet]
        public IActionResult IndexCom()
        {
            ViewBag.comment = accountService.findAllCom();
            return View("IndexCom");
        }
        [Route("deletecom/{id}")]
        public IActionResult Deletecom(int id)
        {
            accountService.DeleteCom(id);
            return RedirectToAction("IndexCom");
        }


    }
}
