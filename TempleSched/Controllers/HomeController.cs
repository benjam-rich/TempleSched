using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TempleSched.Models;
using TempleSched.Models.ViewModels;

namespace TempleSched.Controllers
{
    public class HomeController : Controller
    {
        private ListContext context { get; set; }

        //Constructor

        public HomeController(ListContext list)
        {

            context = list;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Times()
        {
            return View();
        }

        public IActionResult TimeForm()
        {
            return View();
        }

        public IActionResult ViewAppointment()
        {
            return View(new AppointmentsViewModel
            {
                groups = context.Groups
            }
            );
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
