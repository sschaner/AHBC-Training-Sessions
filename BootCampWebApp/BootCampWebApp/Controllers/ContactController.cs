using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BootCampWebApp.Models;

namespace BootCampWebApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            List<ContactViewModel> personList = new List<ContactViewModel>()
            {
                new ContactViewModel{Name = "Steve", Email = "steve@email.com"},
                new ContactViewModel{Name = "Ed", Email = "ed@email.com"},
            };

            ViewData["person"] = personList;
            ViewBag.Message = "Contact one of our representatives back soon.";
            return View();
        }

        public ContactViewModel Contact()
        {
            return new ContactViewModel() { Name = "Steve Schaner", Email = "steve@myemail.com" };
        }

        public string Message()
        {
            return $"Contact me here.";
        }
    }
}
