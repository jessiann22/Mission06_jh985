using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission06_jh985.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mission06_jh985.Controllers
{
    public class HomeController : Controller
    {
        private MovieEntryContext movieTimeContext { get; set; }
        
        //constructor
        public HomeController(MovieEntryContext nameTime)
        {
            movieTimeContext = nameTime;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcast()
        {
            return View("Podcasts");
        }

        [HttpGet]
        public IActionResult MovieEntry()
        {
            ViewBag.Category = movieTimeContext.Category.ToList();

            return View("MovieEntry", new MovieEntryModel());
        }

        [HttpPost]
        public IActionResult MovieEntry(MovieEntryModel me)
        {
            if (ModelState.IsValid)
            {
                movieTimeContext.Add(me);
                movieTimeContext.SaveChanges();

                return View();
            }
            else //if invalid
            {
                return View(me);
            }
        }

        public IActionResult MovieList ()
        {
            var movieApps = movieTimeContext.Response
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();

            return View(movieApps);
        }

        public IActionResult Edit (int movieid)
        {
            ViewBag.Category = movieTimeContext.Category.ToList();

            var movie = movieTimeContext.Response.Single(x => x.MovieID == movieid);

            return View("MovieEntry");
        }

        [HttpPost]

        public IActionResult Edit (MovieEntryModel me2)
        {
            movieTimeContext.Update(me2);
            movieTimeContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]

        public IActionResult Delete(int movieid)
        {
            var movie = movieTimeContext.Response.Single(x => x.MovieID == movieid);
            return View();
        }

        [HttpPost]

        public IActionResult Delete (MovieEntryModel me3)
        {
            movieTimeContext.Response.Remove(me3);
            movieTimeContext.SaveChanges();

            return RedirectToAction("MovieList");
       
        }

    }
}
