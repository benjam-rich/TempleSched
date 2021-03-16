using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TempleSched.Models;

namespace TempleSched.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Times()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Times (Group timeM)
        {
           return View("TimeForm", timeM);
        }
        [HttpGet]
        public IActionResult TimeForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TimeForm(Group timeM)
        {
            return View("ViewAppointment", timeM);
        }

        public IActionResult ViewAppointment()
        {
            return View();
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
