using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MichalSurmackiZad01.ViewsModel;
using MichalSurmackiZad01.Models;

namespace MichalSurmackiZad01.Controllers
{
    public class HomeController : Controller
    {
        //utworzenie instancji bazy danych
        MichalSurmackiLab06Zad01Entities database = new MichalSurmackiLab06Zad01Entities();

        /// <summary>
        /// Strona główna
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Strona z najlepszymi forami poświęconymi filmom
        /// </summary>
        /// <returns></returns>
        public ActionResult FavouriteForums()
        {
            return View();
        }

        /// <summary>
        /// Wyświetlanie wszystkich filmów z bazy danych
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetAllFilms()
        {
            List<Film> AllFilms = database.Films.ToList();
            // Lista obiektów do wyświetlenia
            List<MyFilm> ViewFilms = new List<MyFilm>();
            foreach (var Film in AllFilms)
            {
                MyFilm viewFilm = new MyFilm(Film.Name, Film.Director, Convert.ToInt32(Film.YearOfProduction), Film.Photo);
                ViewFilms.Add(viewFilm);
            }

            // Przekazanie listy filmów do widoku
            return View(ViewFilms);
        }

        /// <summary>
        /// Wyświetla formularz do oceny filmu
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult MarkForm()
        {
            return View();
        }

        /// <summary>
        /// Przechwycenie danych z formularza do oceniania filmu
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult MarkForm(GivingMark userData)
        {
            string filmsName = userData.FilmName;
            ViewBag.movieName = filmsName;
            return View("MarkingMovie");
        }

        /// <summary>
        /// Wyświetlenie wizytowki autora
        /// </summary>
        /// <returns></returns>
        public ActionResult AuthorForm()
        {
            return View();
        }
    }
}