﻿using Demo.Data;
using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class DatabaseProductController : Controller
    {
        private DataContext _context;

        public DatabaseProductController()
        {
            _context = new DataContext();
        }

        // GET: DatabaseProduct
        public ActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == id);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var toBeEdited = _context.Products.FirstOrDefault(x => x.Id == product.Id);
                    if (toBeEdited != null)
                    {
                        toBeEdited.Name = product.Name;
                        toBeEdited.Price = product.Price;
                        toBeEdited.Producer = product.Producer;
                        toBeEdited.Supplier = product.Supplier;
                        toBeEdited.Category = product.Category;
                        toBeEdited.Description = product.Description;
                        _context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return View("Index", _context.Products.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Products.Add(product);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return View("Index", _context.Products.ToList());
        }
    }
}