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
        private readonly ILogger<HomeController> _logger;
        private MoviesEntryContext blahContext { get; set; }
        public HomeController(ILogger<HomeController> logger, MoviesEntryContext someName)
        {
            _logger = logger;
            blahContext = someName;
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
            blahContext.Add(mr);
            blahContext.SaveChanges();
            return View("Confirmation", mr);
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
