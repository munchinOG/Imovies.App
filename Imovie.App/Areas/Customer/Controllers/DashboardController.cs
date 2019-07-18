using System;
using Microsoft.AspNetCore.Mvc;

namespace Imovie.App.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class DashboardController:Controller
    {
        public IActionResult Index()
        {
            this.ViewData["SubTitle"] = "Dashboard";
            return View();
        }

        public IActionResult Movies()
        {
            this.ViewData["SubTitle"] = "List Movies";
            return View();
        }
    }
}
