using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VeterinariaApp.Helpers.Sesion;

namespace VeterinariaApp.Controllers
{
    public class TiendaController : Controller
    {
        // GET: Tienda
        public ActionResult Index()
        {
            if (AdministradorSesion.SesionActiva == false)
            {
                return RedirectToAction("Login", "Acceso");
            }
            return View();
        }
    }
}