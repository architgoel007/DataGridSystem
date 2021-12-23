using DataGridSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataGridSystem.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationContext _applicationContext;

        public ProductController(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _applicationContext.Products.ToList();
            return Json(products);
        }

        public IActionResult PostProduct(Product product)
        {
            _applicationContext.Products.Add(product);
            _applicationContext.SaveChanges();
            return Json(product);
        }

        public IActionResult Categorey()
        {
            return View();
        }
        public IActionResult GetCategorey()
        {
            var category = _applicationContext.Categoreys.ToList();
            return Json(category);
        }
        public IActionResult AddCategorey(Categorey categorey)
        {
           var cat= _applicationContext.Categoreys.Add(categorey);
            _applicationContext.SaveChanges();
            var products = _applicationContext.Categoreys.ToList();
            return Json(products);
        }
    }
}
