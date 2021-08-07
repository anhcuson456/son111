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
    [Route("admin/service")]
    public class ServiceController : Controller
    {
        private IWebHostEnvironment webHostEnvironment;
        private ServiService serviService;
        private CategoryService categoryServi;
        private TouristService touristService;
        private TravelService travelService;


        public ServiceController(TravelService _travelService, ServiService _serviService, TouristService _touristService, CategoryService _catesService, IWebHostEnvironment _webHostEnvironment)
        {
            travelService = _travelService;
            touristService = _touristService;
            categoryServi = _catesService;
            serviService = _serviService;
            webHostEnvironment = _webHostEnvironment;
        }

        [Route("index")]
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.service = serviService.findAll();
            return View();
        }
        [HttpGet]
        [Route("create")]
        public IActionResult Create()
        {
            ViewBag.cates = categoryServi.findAll();
            ViewBag.tours = touristService.findAll();
            return View("Create", new Servi());
        }
        [HttpPost]
        [Route("create")]
        public IActionResult Create(Servi servi,string id)
        {
            if (serviService.Check(id))
            {
                TempData["msgID"] = "<script>alert('ID already exists');</script>";
            }
            else
            {
                serviService.Create(servi);
            }
            return RedirectToAction("index");
        }


        [Route("delete/{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                serviService.Delete(id);
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
            ViewBag.cates = categoryServi.findAll();
            ViewBag.tours = touristService.findAll();
            var servi = serviService.find(id);
            return View("Edit", servi);
        }
        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(string id, Servi servi)
        {
            var currentServi = serviService.find(id);
            currentServi.Id = servi.Id;
            currentServi.Name = servi.Name;
            currentServi.Addr = servi.Addr;
            currentServi.Descrip = servi.Descrip;
            currentServi.CategoryId = servi.CategoryId;
            currentServi.TourId = servi.TourId;
            currentServi.Stt = servi.Stt;
            serviService.Edit(currentServi);
            return RedirectToAction("index");

        }

        [Route("img/{id}")]
        public IActionResult Img(string id)
        {
            ViewBag.service = serviService.find(id);
            return View("img");
        }

        [HttpGet]
        [Route("createImg/{id}")]
        public IActionResult CreateImg(string id)
        {
            ViewBag.serviD = id;
            return View("CreateImg", new Img());
        }
        [HttpPost]
        [Route("createImg/{id}")]
        public IActionResult CreateImg(string id, Img img, IFormFile file)
        {
            if ( file != null)
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
            else {
                img.Name = "no_image.png";
            }
            serviService.CreateImg(img);
            return RedirectToAction("img", "service", new { area = "admin",id = id });
        }
        [Route("deleteImg/{id}")]
        public IActionResult DeleteImg(int id)
        {
            serviService.DeleteImg(id);
            return RedirectToAction("index");
        }

        [Route("searchbyName")]
        public IActionResult SearchbyName([FromQuery(Name = "name")] string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                ViewBag.service = serviService.findAll();
            }
            else
            {
                ViewBag.service = serviService.SearchByName(name);
            }
            return View("Index");
        }

        
        [Route("travel/{id}")]
        public IActionResult Travel(string id)
        {
            ViewBag.service = serviService.find(id);
            return View("Travel");
        }
        [HttpGet]
        [Route("createTra/{id}")]
        public IActionResult CreateTra(string id)
        {
            ViewBag.travels = travelService.findAll();
            ViewBag.serviD = id;
            return View("CreateTra", new ServiTravel());
        }
        [HttpPost]
        [Route("createTra/{id}")]
        public IActionResult CreateTra(string id, ServiTravel serviTravel)
        {
            travelService.CreateSerTra(serviTravel);
            return RedirectToAction("travel", "service", new { area = "admin", id = id });
        }
        [Route("deleteSertra/{id}")]
        public IActionResult DeleteSerTra(int id)
        {
            travelService.DeleteSerTra(id);
            return RedirectToAction("index");
        }
    }
}

