using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MultiPageWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MultiPageWebApp.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext context { get; set; }

        public HomeController(ContactContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var contacts = context.Contacts
                .OrderBy(c => c.Name)
                .ToList();
            return View(contacts);
        }
    }
}
