using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkingWithRazor.Models;

namespace WorkingWithRazor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Product product = new Product
            {
                ProductId = 1,
                Name = "Shirt",
                Description = "Nice Formal shirt",
                Price = 275M,
                Category = "Shirts"

            };
            ViewBag.Stock = 6;
            return View(product);
        }
        public IActionResult Loop()
        {
            Product[] products = {
                new Product { ProductId = 1, Name = "Shirt", Price = 275M }
                ,  new Product { ProductId = 2, Name = "Jeans", Price = 425M }
                ,  new Product { ProductId = 3, Name = "Shorts", Price = 200M }
                ,  new Product { ProductId = 4, Name = "Pants", Price = 350M }
             ,  new Product { ProductId = 5, Name = "Shoes", Price = 700M }
            };
            return View(products);
        }
    }
}