using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BilgeAdam.NorthwindPages.Models;

namespace BilgeAdam.NorthwindPages.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<ProductViewModel>
            {
                new ProductViewModel { Id = 1, Name = "Chai", Price = 39.82M, Text = "Meyve Suyu" },
                new ProductViewModel { Id = 2, Name = "Chang", Price = 17.83M, Text = "Meyve Nektarı" },
                new ProductViewModel { Id = 3, Name = "Anyseed Syrup", Price = 23.65M, Text = "Şekerleme Türevi" },
                new ProductViewModel { Id = 4, Name = "Ikura", Price = 25.56M, Text = "Okyanus Balığı" },
                new ProductViewModel { Id = 5, Name = "Miku Tobe Mishu", Price = 6.44M, Text = "Kurutulmuş Et" },
                new ProductViewModel { Id = 6, Name = "Yarda", Price = 11.80M, Text = "Günlük Süt" }
            };
            return View(products);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
