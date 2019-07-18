 using System;
using Microsoft.AspNetCore.Mvc;

namespace Imovie.App.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }
    }
}
