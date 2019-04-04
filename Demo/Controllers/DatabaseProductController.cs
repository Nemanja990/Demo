using Demo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class DatabaseProductController : Controller
    {
        private readonly DataContext _context;

        public DatabaseProductController(DataContext context)
        {
            _context = context;
        }

        // GET: DatabaseProduct
        public ActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }
    }
}