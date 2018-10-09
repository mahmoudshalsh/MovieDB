using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ttt.Models;

namespace ttt.Controllers
{
    public class GenreController : Controller
    {
        public ViewResult Index()
        {
            var repo = new GenreRepo();
            return View(repo.GetAll().Result);
        }

        public PartialViewResult Movies(int Id)
        {
            var repo = new MovieRepo();
            var movies = repo.GetByGenreId(Id).Result;
            return PartialView(movies);
        }
    }
}
