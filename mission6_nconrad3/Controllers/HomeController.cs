using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mission6_nconrad3.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace mission6_nconrad3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieInfoContext blahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieInfoContext someName)
        {
            _logger = logger;
            blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult podcast()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EnterMovie ()
        {
            return View("movieEntry");
        }

        [HttpPost]
        public IActionResult EnterMovie(ApplicationResponse ar)
        {
            blahContext.Add(ar);
            blahContext.SaveChanges();
            return View("confirmation", ar);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
