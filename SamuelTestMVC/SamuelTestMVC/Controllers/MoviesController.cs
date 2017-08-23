using SamuelTestMVC.Models;
using SamuelTestMVC.Models.ViewModels;
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

            var customers = new List<Customer>
            {
                new Customer { Name = "Cust 1" },
                new Customer { Name = "Cust 2" }
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = newMovie,
                Customers = customers
            };

            return View(viewModel);
        }

        [Route("movies/released/{year}/{month:regex(\\d{4})}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content("Year : " + year + "Month : " + month);

        }


    }
}