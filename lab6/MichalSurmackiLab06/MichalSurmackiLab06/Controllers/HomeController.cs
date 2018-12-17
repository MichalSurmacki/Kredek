using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MichalSurmackiLab06.ViewModels;
using MichalSurmackiLab06.Models;

namespace MichalSurmackiLab06.Controllers
{
    public class HomeController : Controller
    {
        //utworzenie instacji bazy danych
        CarsAppDbEntities database = new CarsAppDbEntities();

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
        /// Strona z ciekawymi linkami
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult InterestingLinks()
        {
            return View();
        }

        /// <summary>
        /// Wyświetlanie wszystkich aut z bazy danych
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetAllCars()
        {
            List<Car> AllCars = database.Cars.ToList();
            // Lista obiektów do wyświetlenia
            List<Carr> ViewCars = new List<Carr>();
            foreach (var Car in AllCars)
            {
                Carr viewCar = new Carr(Car.Model, Car.Manufacturer, Convert.ToInt32(Car.Price), Car.Photo);
                ViewCars.Add(viewCar);
            }

            // Przekazanie listy samochodów do widoku
            return View(ViewCars);
        }

        /// <summary>
        /// Wyświetlenie listy umożliwiającej wybór konkretnego samochodu
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetListOfModels()
        {
            List<Car> AllCars = database.Cars.ToList();
            List<string> AllModels = new List<string>();

            foreach (var Car in AllCars)
            {
                AllModels.Add(Car.Model);
            }
            // Przekazanie listy modeli samochodów do widoku
            return View(AllModels);
        }

        /// <summary>
        /// Wyświetlenie samochodu po modelu
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetCarByModel(string model)
        {
            List<Car> AllCars = database.Cars.ToList();
            // Filtracja listy
            var car = AllCars.Where(a => a.Model.ToLower() == model.ToLower()).FirstOrDefault();
            Carr viewCar = new Carr(car.Model, car.Manufacturer, Convert.ToInt32(car.Price), car.Photo);

            // Przekazanie modelu do widoku
            return View(viewCar);
        }

        /// <summary>
        /// Wyświetla formularz kontaktowy do wypełnienia
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult ContactForm()
        {
            return View();
        }

        /// <summary>
        /// Przechwycenie danych z formularza kontaktowego
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult ContactForm(ContactForm userData)
        {
            string fullName = userData.FirstName + " " + userData.LastName;
            ViewBag.UserName = fullName;
            return View("ContactFormGreetings");
        }
    }
}