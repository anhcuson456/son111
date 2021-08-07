using eProject.Models;
using eProject.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace eProject.Controlles
{
    [Route("tourist")]
    public class TouristController : Controller
    {
        private IWebHostEnvironment webHostEnvironment;
        private TouristService touristService;
        private ServiService serviceService;
        public TouristController(TouristService _touristService, ServiService _serviceService, IWebHostEnvironment _webHostEnvironment)
        {
            serviceService = _serviceService;
            touristService = _touristService;
            webHostEnvironment = _webHostEnvironment;
        }
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.touristSpots = touristService.findAll();
            ViewBag.serVi = serviceService.findAll();
            ViewBag.cate = touristService.findCate();
            return View();
        }
        [Route("detail")]
        public IActionResult Detail(string id)
        {
            ViewBag.cate = touristService.findCate();
            ViewBag.tourist = touristService.Find(id);
            return View("Detail");
        }

        [HttpGet]
        [Route("comment")]
        public IActionResult Comment(string Content,string TourId)
        {
            var username = HttpContext.Session.GetString("username");
            var idAcc = touristService.findID(username);
            var cmt = new Comment();
            cmt.AccId = idAcc;
            cmt.Content = Content;
            cmt.TourId = TourId;
            touristService.Add(cmt);
            return RedirectToAction("Detail",new { id = TourId });
        }

        [HttpGet]
        [Route("commentSer")]
        public IActionResult CommentSer(string Content, string ServiId)
        {
            var username = HttpContext.Session.GetString("username");
            var idAcc = serviceService.findID(username);
            var cmt = new Comment();
            cmt.AccId = idAcc;
            cmt.Content = Content;
            cmt.ServiId = ServiId;
            serviceService.Add(cmt);
            return RedirectToAction("DetailSer", new { id = ServiId });
        }

        [Route("detailser")]
        public IActionResult DetailSer(string id)
        {
            ViewBag.service = serviceService.find(id);
            return View("DetailSer");
        }

    }
}
