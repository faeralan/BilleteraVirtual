using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BilleteraVirtualMVC.Models;
using BilleteraVirtualMVC.Context;
using Microsoft.AspNetCore.Http;


namespace BilleteraVirtualMVC.Controllers
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
            ViewBag.Nombre = HttpContext.Session.GetString("Nombre");
            ViewBag.Saldo = HttpContext.Session.GetString("Saldo");
            ViewBag.Usuario = HttpContext.Session.GetString("UserID");
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
