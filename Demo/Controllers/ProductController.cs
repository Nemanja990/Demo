using Demo.Business;
using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class ProductController : Controller
    {
        private List<Product> _products;

        public ProductController()
        {
            _products = LoadJson.LoadAllProducts();
        }

        // GET: Product
        public ActionResult Index()
        {           
            return View(_products);
        }

        [HttpGet]
        public ActionResult EditData(int id)
        {
            var product = _products.FirstOrDefault(x => x.Id == id);
            return View(product);
        }

        [HttpPost]
        public ActionResult EditData(Product product)
        {
            var ToBeChanged = _products.FirstOrDefault(x => x.Id == product.Id);
            ToBeChanged.Name = product.Name;
            ToBeChanged.Price = product.Price;
            ToBeChanged.Producer = product.Producer;
            ToBeChanged.Supplier = product.Supplier;
            ToBeChanged.Description = product.Description;
            ToBeChanged.Category = product.Category;

            return View("Index", _products);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            _products.Add(product);
            return View("Index", _products);
        }
    }
}