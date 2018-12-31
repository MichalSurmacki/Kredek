using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MichalSurmackiLab07Zad1._2.Models;
using Zadanie.Service;
using Zadanie.ViewModels;
using Zadanie.Service.LendBooksService;

namespace MichalSurmackiLab07Zad1._2.Controllers
{
    public class HomeController : Controller
    {
        //wstrzykiwanie zależności
        private readonly IShowBooksService _showBooksService;
        private readonly ILendBooksService _lendBooksService;

        //konstruktor wstrzykiwanie zależności
        public HomeController(IShowBooksService showBooksService, ILendBooksService lendBooksService)
        {
            _showBooksService = showBooksService;
            _lendBooksService = lendBooksService;
        }

        //metody odpowiedzalne za zwracanie odpowiednich widoków stron
        public IActionResult Index()
        {
            List<ShowBooksViewModel> model = _showBooksService.GetBooks();
            return View(model);
        }

        [HttpPost]
        public IActionResult LendBook(ShowBooksViewModel model, LendBooksViewModel model1)
        {
            _showBooksService.LentBook(model.Id);
            _lendBooksService.SaveChanges(model1);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult AddBook(ShowBooksViewModel model)
        {
            _showBooksService.SaveChanges(model);
            return RedirectToAction("Index");
        }

        public IActionResult LendedBooks()
        {
            List<LendBooksViewModel> model = _lendBooksService.GetLendedBooks();
            return View(model);
        }

        public IActionResult ReturnBook(LendBooksViewModel model)
        {
            _lendBooksService.ReturnBook(model.Id);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
