using BusinessLayer.Abstract;
using BusinessLayer.Concrate;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using webUI.Models;

namespace webUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        private readonly ICategoryService _cateService;
        private readonly ITagService _tagService;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _productService = new ProductMan();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }



        /// CRUD Metots

        // product
        public IActionResult Products()
        {
            var products = _productService.GetProducts();
            return View(products);
        }

        public IActionResult AddProduct(product product)
        {
            _productService.CreateProduct(product);
            return RedirectToAction(nameof(Products));
        }
        public IActionResult RemovePoduct(int id)
        {
            _productService.DeleteProduct(id);
            return RedirectToAction(nameof(Products));
        }
        public IActionResult UpdateProduct(product product)
        {
            _productService.UpdateProduct(product);
            return RedirectToAction(nameof(Products));
        }

        // category
        public IActionResult Categories()
        {
            var categories = _cateService.GetCategories();
            return View(categories);
        }

        public IActionResult AddCategory(category category)
        {
            _cateService.CreateCategory(category);

            return RedirectToAction(nameof(Categories));
        }
        public IActionResult RemoveCategory(int id)
        {
            _cateService.DeleteCategory(id);
            return RedirectToAction(nameof(Categories));
        }
        public IActionResult UpdateCategory(category category)
        {
            _cateService.UpdateCategory(category);
            return RedirectToAction(nameof(Categories));
        }

        // tag
        public IActionResult Tags()
        {
            var tags = _tagService.GetTags();
            return View(tags);
        }

        public IActionResult AddTag(tag tag)
        {
            _tagService.CreateTag(tag);

            return RedirectToAction(nameof(Tags));
        }
        public IActionResult RemoveTag(int id)
        {
            _tagService.DeleteTag(id);
            return RedirectToAction(nameof(Tags));
        }
        public IActionResult UpdateTag(tag tag)
        {
            _tagService.UpdateTag(tag);
            return RedirectToAction(nameof(Tags));
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
