using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aits_PikedupBySazzad.Models;

namespace Aits_PikedupBySazzad.Controllers
{
    public class ProductController : Controller
    {
        private List<Product> _products = new List<Product>();

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product model)
        {
            if (!ModelState.IsValid) return View(model);
            model.Id = Guid.NewGuid();
            Database.Products.Add(model);
            ViewBag.products = Database.Products;
            return View(model);
        }
    }
}
