using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using C1GridControl.Models;

using System.Collections;
using System.Globalization;
using System.Web;
using C1.Web.Mvc;

namespace C1GridControl.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(Sale.GetData(15));
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
