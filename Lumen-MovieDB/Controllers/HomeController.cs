using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lumen_MovieDB.Models;

namespace Lumen_MovieDB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Movies()
        {
            ViewBag.Message = "List of Movies from DB... here hard coded";

            var movies = GetMovies();

            return View(movies);

        }

        private IEnumerable<Movies> GetMovies()
        {
            return new List<Movies>
            {
                new Movies()
                {
                    Id = 1,
                    ReleaseYear = 2000,
                    MovieTitle = "Dolores Claiborne",
                    MovieGenre = "Drama",
                    Description = "Splendid Movie",
                    featuredImg = "dc.jpg"
                },
                new Movies()
                {
                    Id = 2,
                    ReleaseYear = 1990,
                    MovieTitle = "Troy",
                    MovieGenre = "Action",
                    Description = "Funfilled",
                    featuredImg = "troy.jpg"
                },
                new Movies()
                {
                    Id = 3,
                    ReleaseYear = 2011,
                    MovieTitle = "Machinist",
                    MovieGenre = "Thriller",
                    Description = "Depressing",
                    featuredImg = "machinist.jpg"
                },
                new Movies()
                {
                    Id = 4,
                    ReleaseYear = 2016,
                    MovieTitle = "Arrival",
                    MovieGenre = "Sci-Fi",
                    Description = "Scintillating",
                    featuredImg = "arrival.jpg"
                },
                new Movies()
                {
                    Id = 5,
                    ReleaseYear = 2015,
                    MovieTitle = "The Intern",
                    MovieGenre = "Drama",
                    Description = "Marvellous",
                    featuredImg = "intern.jpg"
                }
            };
        }

        public ActionResult Movie(int id)
        {
            var movie = GetMovies().SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        public ActionResult AddComment(string Username, string Comment)
        {
            var movie = new Movies();
            movie.Username = Username;
            movie.Comment = Comment;
            return Json(movie, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}