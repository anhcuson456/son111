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
    [Route("category")]
    public class CategoryController : Controller
    {
        private IWebHostEnvironment webHostEnvironment;
        private CategoryService categoryService;

        public CategoryController(CategoryService _categoryService, IWebHostEnvironment _webHostEnvironment)
        {
            categoryService = _categoryService;
            webHostEnvironment = _webHostEnvironment;
        }
        [Route("index")]
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.cates = categoryService.findAll();
            return View();
        }
        [HttpGet]
        [Route("create")]
        public IActionResult Create()
        {
            return View("Create", new CategoryServi());
        }
        [HttpPost]
        [Route("create")]
        public IActionResult Create(CategoryServi categoryServi)
        {
            categoryService.Create(categoryServi);
            return RedirectToAction("index");
        }
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                categoryService.Delete(id);
            }
            catch (Exception)
            {
                TempData["msgCate"] = "<script>alert('Can not delete');</script>";
            }
            
            return RedirectToAction("index");
        }
        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            ViewBag.cates = categoryService.findAll();
            var cateservi = categoryService.find(id);
            return View("Edit", cateservi);
        }
        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(int id, CategoryServi categoryServi)
        {
            var currentCateServi = categoryService.find(id);
            currentCateServi.Name = categoryServi.Name;
            categoryService.Edit(currentCateServi);
            return RedirectToAction("index");

        }
        [HttpGet]
        [Route("SearchSer")]
        public IActionResult SearchSer([FromQuery (Name="name")] string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                ViewBag.cates = categoryService.findAll();
            }
            else
            {
                ViewBag.cates = categoryService.SearchSerByName(name);
            }
            return RedirectToAction("index");
        }


        [Route("index2")]
        [HttpGet]
        public IActionResult Index2()
        {
            ViewBag.cates = categoryService.findAllTour();
            return View("index2");
        }
        [HttpGet]
        [Route("createtour")]
        public IActionResult CreateTour()
        {
            return View("Createtour", new CategoryTour());
        }
        [HttpPost]
        [Route("createtour")]
        public IActionResult CreateTour(CategoryTour categoryTour)
        {
            categoryService.CreateTour(categoryTour);
            return RedirectToAction("index2");
        }
        [Route("deletetour/{id}")]
        public IActionResult DeleteTour(int id)
        {
            try
            {
                categoryService.DeleteTour(id);
            }
            catch (Exception)
            {
                TempData["msgCateT"] = "<script>alert('Can not delete');</script>";
            }
            
            return RedirectToAction("index2");
        }
        [HttpGet]
        [Route("edittour/{id}")]
        public IActionResult EditTour(int id)
        {
            var catetour = categoryService.findTour(id);
            return View("Edittour", catetour);
        }
        [HttpPost]
        [Route("edittour/{id}")]
        public IActionResult EditTour(int id, CategoryTour categoryTour)
        {
            var currentCateTour = categoryService.findTour(id);
            currentCateTour.Name = categoryTour.Name;
            categoryService.EditTour(currentCateTour);
            return RedirectToAction("index2");

        }

        [HttpGet]
        [Route("SearchTou")]
        public IActionResult SearchTou([FromQuery(Name = "name")] string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                ViewBag.cates = categoryService.findAllTour();
            }
            else
            {
                ViewBag.cates = categoryService.SearchByNameTour(name);
            }
            return RedirectToAction("index2");
        }
    }
}