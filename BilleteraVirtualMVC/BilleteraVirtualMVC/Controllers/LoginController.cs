using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BilleteraVirtualMVC.Context;
using BilleteraVirtualMVC.Models;
using Microsoft.AspNetCore.Http;

namespace BilleteraVirtualMVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly BilleteraContext _context;

        public LoginController(BilleteraContext context)
        {
            _context = context;
        }

        // GET: Login
        public async Task<IActionResult> Index()
        {
            return View("~/Views/Login.cshtml");
        }

        [HttpPost, ActionName("Login")]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Usuario user)
        {
            if (ModelState.IsValid)
            {
                using (_context)
                {
                    var obj = _context.Usuarios.Where(a => a.Email.Equals(user.Email) && a.Password.Equals(user.Password)).FirstOrDefault();
                    if (obj != null)
                    {

                        HttpContext.Session.SetString("UserID", obj.UsuarioId.ToString());
                        HttpContext.Session.SetString("CuentaID", obj.Cuenta.CuentaId.ToString());
                        HttpContext.Session.SetString("Nombre", obj.Nombre.ToString());
                        return RedirectToAction("UserDashBoard");
                    }
                }
            }
            return RedirectToAction("Login");
        }

        public IActionResult UserDashBoard()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                return View("~/Views/Home/Index.cshtml");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}
