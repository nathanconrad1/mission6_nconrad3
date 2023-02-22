using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        //private readonly ILogger<HomeController> _logger;
        private MovieInfoContext daContext { get; set; }

        public HomeController( MovieInfoContext someName)
        {
            //_logger = logger;
            daContext = someName;
        }

        //Controller to index
        public IActionResult Index()
        {
            return View();
        }

        //Controller to podcast
        public IActionResult podcast()
        {
            return View();
        }

        //Movie entry and post 

        [HttpGet]
        public IActionResult movieEntry ()
        {
            ViewBag.Category = daContext.Category.ToList();



            return View();
        }

        [HttpPost]
        public IActionResult movieEntry(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                daContext.Add(ar);
                daContext.SaveChanges();
                return View("confirmation", ar);
            }
            else
            {
                ViewBag.Category = daContext.Category.ToList();

                return View();
            }

        }

        //List the movies action

        [HttpGet]
        public IActionResult MovieList ()
        {
            var applications = daContext.responses
                .Include(x => x.Category)
                .ToList();
            return View(applications);
        }

        //Edit table actions

        [HttpGet]
        public IActionResult Edit(int applicationid)
        {
            var application = daContext.responses.Single(x => x.ApplicationID == applicationid);
            ViewBag.Category = daContext.Category.ToList();

            return View("movieEntry", application);
        }

        [HttpPost]
        public IActionResult Edit (ApplicationResponse blah)
        {
            daContext.Update(blah);
            daContext.SaveChanges();

            return Redirect("MovieList");
        }

        //Delete the records

        [HttpGet]
        public IActionResult Delete(int applicationid)
        {
            var application = daContext.responses.Single(x => x.ApplicationID == applicationid);

            return View(application);
        }

        [HttpPost]
        public IActionResult Delete (ApplicationResponse ar)
        {
            daContext.responses.Remove(ar);
            daContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
