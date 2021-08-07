using eProject.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProject.Controlles
{ 
    [Route("search")]
    public class SearchController : Controller
    {
        private IWebHostEnvironment webHostEnvironment;
        private TouristService touristService;
        private ServiService serviceService;
        private CategoryService categoryService;
        public SearchController(TouristService _touristService, ServiService _serviceService, IWebHostEnvironment _webHostEnvironment, CategoryService _categoryService)
        {
            serviceService = _serviceService;
            touristService = _touristService;
            webHostEnvironment = _webHostEnvironment;
            categoryService = _categoryService;
        }
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.catetours = categoryService.findAllTour();
            ViewBag.tourist = touristService.findAll();
            return View();
        }
        [Route("index2")]
        public IActionResult Index2()
        {
            ViewBag.catesers = categoryService.findAll();
            ViewBag.service = serviceService.findAll();
            return View("index2");
        }

        [Route("searchAllTour")]
        public IActionResult SearchTourAll([FromQuery(Name = "keyword")] string keyword)
        {
            ViewBag.catetours = categoryService.findAllTour();
            if (string.IsNullOrEmpty(keyword))
            {
                ViewBag.tourist = touristService.findAll();
            }
            else
            {
                ViewBag.tourist = touristService.SearchAll(keyword);
            }
            return View("Index");
        }

        [Route("searchAllSer")]
        public IActionResult SearchSerAll([FromQuery(Name = "keyword")] string keyword)
        {
            ViewBag.catesers = categoryService.findAll();
            if (string.IsNullOrEmpty(keyword))
            {
                ViewBag.service = serviceService.findAll();
            }
            else
            {
                ViewBag.service = serviceService.SearchAll(keyword);
            }
            return View("Index2");

        }

        [Route("searchbyPrice")]
        public IActionResult SearchbyPrice(decimal min, decimal max)
        {
            ViewBag.catesers = categoryService.findAll();
            ViewBag.service = serviceService.SearchByPrice(min,max);
            return View("Index2");
        }

        [Route("searchToubyCate")]
        public IActionResult SearchToubyCate([FromQuery(Name = "cate")] int cate)
        {
            ViewBag.catetours = categoryService.findAllTour();
            ViewBag.tourist = touristService.SearchTourByCate(cate);
            return View("Index");
        }
        [Route("searchSerbyCate")]
        public IActionResult SearchSerbyCate([FromQuery(Name = "cate")] int cate)
        {
            ViewBag.catesers = categoryService.findAll();
            ViewBag.service = serviceService.SearchSerByCate(cate);
            return View("Index2");
        }
    }
}
