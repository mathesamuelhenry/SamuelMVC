using SamuelTestMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SamuelTestMVC.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            Movie newMovie = new Movie() { Name = "Shrek" };

            // return View(newMovie);

            // return Content("Hello World");

            ViewData["Movie"] = newMovie;

            return View();
        }

        [Route("movies/released/{year}/{month:regex(\\d{4})}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content("Year : " + year + "Month : " + month);

        }


    }
}