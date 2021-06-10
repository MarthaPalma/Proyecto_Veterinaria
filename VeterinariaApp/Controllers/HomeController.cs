using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VeterinariaApp.Helpers.Sesion;

namespace VeterinariaApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult IndexAdmin()
        {
            if (AdministradorSesion.SesionActiva == false)
            {
                return RedirectToAction("Login", "Acceso");
            }

            return View();
        }

        // GET: Home
        public ActionResult IndexCliente()
        {
            if (AdministradorSesion.SesionActiva == false)
            {
                return RedirectToAction("Login", "Acceso");
            }
            return View();
        }

        // GET: Home
        public ActionResult IndexPersonal()
        {
            if (AdministradorSesion.SesionActiva == false)
            {
                AdministradorSesion.CerrarSession();
                return RedirectToAction("Login", "Acceso");
            }
            return View();
        }

    }
}