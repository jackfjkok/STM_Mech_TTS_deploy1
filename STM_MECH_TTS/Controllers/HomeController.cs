using Microsoft.AspNetCore.Mvc;
using STM_MECH_TTS.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Encodings.Web;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace STM_MECH_TTS.Controllers
{
    public class HomeController : Controller
    {
        [Microsoft.AspNetCore.Authorization.AllowAnonymous]
        public IActionResult Index()
        {
            return View();
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

        public IActionResult Privacy()
        {
            return View();
        }

        //[Microsoft.AspNetCore.Authorization.AllowAnonymous]
        public IActionResult Index2()
        {
            return View();
        }

        //[Microsoft.AspNetCore.Authorization.AllowAnonymous]
        public IActionResult Index3()
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
