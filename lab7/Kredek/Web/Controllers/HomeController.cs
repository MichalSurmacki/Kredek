using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Kredek.Service.ContactService;
using Kredek.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Web.Models;


namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private IContactService _contactService;

        //ctor tab tab tworzy konstruktor
        public HomeController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            List<ShowContactViewModel> model = _contactService.GetContacts();
            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(SaveContactViewModel model)
        {
            _contactService.SaveContact(model);
            return RedirectToAction("Index");
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
