using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6_bellak20.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_bellak20.Controllers
{
    public class HomeController : Controller
    {
        
        private MoviesEntryContext daContext { get; set; }
        public HomeController( MoviesEntryContext someName)
        {
            
            daContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts ()
        {
            return View("MyPodcasts");
        }

        [HttpGet]
        public IActionResult MoviesEntry()
        {
            return View("MoviesEntry");
        }

        [HttpPost]
        public IActionResult MoviesEntry(MovieResponse mr)
        {
            daContext.Add(mr);
            daContext.SaveChanges();
            return View("Confirmation", mr);
        }
        //movie list that pulls from the responses, puts into a list so we can use them
       [HttpGet]
        public IActionResult MovieList()
        {
            var applications = daContext.Responses.ToList();
            return View(applications);
        }
    }
}
