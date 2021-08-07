using eProject.Models;
using eProject.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace eProject.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/touristSpot")]
    public class TouristController : Controller
    {
        private IWebHostEnvironment webHostEnvironment;
        private TouristService touristService;
        private CategoryService categoryServi;
        private TravelService travelService;
        public TouristController(TravelService _travelService, TouristService _touristService, CategoryService _catesService, IWebHostEnvironment _webHostEnvironment)
        {
            travelService = _travelService;
            categoryServi = _catesService;
            touristService = _touristService;
            webHostEnvironment = _webHostEnvironment;
        }
        [Route("index")]
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.tourSpot = touristService.findAll();
            return View();
        }
        [HttpGet]
        [Route("create")]
        public IActionResult Create()
        {
            ViewBag.cates = categoryServi.findAllTour();
            return View("Create", new TouristSpot());
        }
        [HttpPost]
        [Route("create")]
        public IActionResult Create(TouristSpot touristSpot,string id)
        {
            if (touristService.Check(id))
            {
                TempData["msgID"] = "<script>alert('ID already exists');</script>";
            }
            else
            {
                touristService.Create(touristSpot);
            }
            return RedirectToAction("index");
        }

        [Route("delete/{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                touristService.Delete(id);
            }
            catch (Exception)
            {
                TempData["msg"] = "<script>alert('Can not delete');</script>";
            }
            return RedirectToAction("index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(string id)
        {
            ViewBag.cates = categoryServi.findAllTour();
            var tourist = touristService.Find(id);
            return View("Edit", tourist);
        }
        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(string id, TouristSpot tourist)
        {
            var currentTourist = touristService.Find(id);
            currentTourist.Id = tourist.Id;
            currentTourist.Name = tourist.Name;
            currentTourist.Addr = tourist.Addr;
            currentTourist.Descrip = tourist.Descrip;
            currentTourist.Active = tourist.Active;
            currentTourist.Stt = tourist.Stt;
            touristService.Edit(currentTourist);
            return RedirectToAction("index");

        }

        [Route("searchbyName")]
        public IActionResult SearchbyName([FromQuery(Name = "name")] string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                ViewBag.tourSpot = touristService.findAll();
            }
            else
            {
                ViewBag.tourSpot = touristService.SearchByName(name);
            }

            return View("Index");
        }


        [Route("img/{id}")]
        public IActionResult Img(string id)
        {
            ViewBag.tourSpot = touristService.Find(id);
            return View("img");
        }

        [HttpGet]
        [Route("createImg/{id}")]
        public IActionResult CreateImg(string id)
        {
            ViewBag.tourId = id;
            return View("CreateImg", new Img());
        }
        [HttpPost]
        [Route("createImg/{id}")]
        public IActionResult CreateImg(string id, Img img, IFormFile file)
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
                img.Name = fileName + "." + ext;
            }
            else
            {
                img.Name = "no_image.png";
            }
            touristService.CreateImg(img);
            return RedirectToAction("img", "touristSpot", new { area = "admin", id = id });
        }


        [Route("deleteImg/{id}")]
        public IActionResult DeleteImg(int id, string tourID)
        {
            ViewBag.tourID = tourID;
            touristService.DeleteImg(id);
            return RedirectToAction("index");
        }

        [Route("travel/{id}")]
        public IActionResult Travel(string id)
        {
            ViewBag.tour = touristService.Find(id);
            return View("Travel");
        }

        [HttpGet]
        [Route("createTra/{id}")]
        public IActionResult CreateTra(string id)
        {
            ViewBag.travels = travelService.findAll();
            ViewBag.tourID = id;
            return View("CreateTra", new TourTravel());
        }
        [HttpPost]
        [Route("createTra/{id}")]
        public IActionResult CreateTra(string id, TourTravel tourTravel)
        {
            travelService.CreateTouTra(tourTravel);
            return RedirectToAction("travel", "touristSpot", new { area = "admin", id = id });
        }

        [Route("deleteTouTra/{id}")]
        public IActionResult DeleteTouTra(int id)
        {
            travelService.DeleteTouTra(id);
            return RedirectToAction("index");
        }
    }
}

