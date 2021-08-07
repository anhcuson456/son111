using eProject.Models;
using eProject.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace eProject.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("travel")]
    public class TravelController : Controller
    {
        private IWebHostEnvironment webHostEnvironment;
        private TravelService travelService;

        public TravelController(TravelService _travelService, IWebHostEnvironment _webHostEnvironment)
        {
            travelService = _travelService;
            webHostEnvironment = _webHostEnvironment;
        }
        [Route("index")]
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.travel = travelService.findAll();
            return View();
        }

        [HttpGet]
        [Route("create")]
        public IActionResult Create()
        {
            return View("Create", new Travel());
        }
        [HttpPost]
        [Route("create")]
        public IActionResult Create(Travel travel, IFormFile file)
        {
            if (file != null)
            {
                var fileName = System.Guid.NewGuid().ToString().Replace("-", "");
                var ext = file.ContentType.Split(new char[] { '/' })[1];
                var path = Path.Combine(webHostEnvironment.WebRootPath, "Img", fileName + "." + ext);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                travel.Img = fileName + "." + ext;
            }
            else
            {
                travel.Img = "no_image.png";
            }
            travelService.Create(travel);
            return RedirectToAction("index");
        }

        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                travelService.Delete(id);
            }
            catch (Exception)
            {
                TempData["msgTra"] = "<script>alert('Can not delete');</script>";
            }
            
            return RedirectToAction("index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            var travel = travelService.find(id);
            return View("Edit", travel);
        }
        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(int id, Travel travel,IFormFile file)
        {
            var currentTravel = travelService.find(id);
            currentTravel.Name = travel.Name;
            if (file != null) 
            {
                var fileName = System.Guid.NewGuid().ToString().Replace("-", "");
                var ext = file.ContentType.Split(new char[] { '/' })[1];
                var path = Path.Combine(webHostEnvironment.WebRootPath, "Img", fileName + "." + ext);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                currentTravel.Img = fileName + "." + ext;
            }
            travelService.Edit(currentTravel);
            return RedirectToAction("index");

        }

        [Route("searchbyName")]
        public IActionResult SearchbyName([FromQuery(Name = "name")] string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                ViewBag.travel = travelService.findAll();
            }
            else
            {
                ViewBag.travel = travelService.SearchByName(name);
            }
            return View("Index");
        }
    }
}
