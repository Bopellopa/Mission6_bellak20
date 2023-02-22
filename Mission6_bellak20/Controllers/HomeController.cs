using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            ViewBag.Categories = daContext.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult MoviesEntry(MovieResponse mr)
        {
            //make sure its valid
            if (ModelState.IsValid)
            {
                daContext.Add(mr);
                daContext.SaveChanges();
                return View("Confirmation", mr);

            }
            else
            {
                ViewBag.Categories = daContext.Categories.ToList();
                return View(mr);
            }
            
        }
        //movie list that pulls from the responses, puts into a list so we can use them, orders by category name alphabetically
       [HttpGet]
        public IActionResult MovieList()
        {
            var movies = daContext.Responses.Include(x => x.Category)
                .OrderBy(x => x.Category)
                .ToList();
            return View(movies);
        }
        [HttpGet]
        public IActionResult Edit (int applicationid)
        {
            ViewBag.Categories = daContext.Categories.ToList();

            var movie = daContext.Responses.Single(x => x.ApplicationId == applicationid);

            return View("MoviesEntry", movie);
        }
        [HttpPost]
        public IActionResult Edit(MovieResponse Blah)
        {
            daContext.Update(Blah);
            daContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int applicationid)
        {
            var movie = daContext.Responses.Single(x => x.ApplicationId == applicationid);
            return View(movie);
        }
        [HttpPost]
        public IActionResult Delete(MovieResponse mr)
        {
            daContext.Responses.Remove(mr);
            daContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
