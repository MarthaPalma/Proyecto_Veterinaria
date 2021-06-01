using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VeterinariaBL;
using VeterinariaBE;

namespace VeterinariaApp.Controllers
{
    public class ServicioController : Controller
    {
        // GET: Servicio
        public ActionResult Index()
        {

            var lst = ServicioBL.ListarServicio();
            ViewBag.SERVICIO = lst;

            return View();
        }

        [HttpPost]
        public JsonResult InsertarServicio(string nombre, string descripcion, decimal precio, string foto)
        {
            bool result = false;
            try
            {

                ServicioBL.InsertarServicio(nombre, descripcion, precio, foto);
                result = true;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return Json(result, JsonRequestBehavior.AllowGet);
            }

        }

        [HttpPost]
        public JsonResult EliminarServicio(int id)
        {
            bool result = false;
            try
            {

                ServicioBL.EliminarServicio(id);
                result = true;

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }


        [HttpPost]
        public JsonResult GetServicio(int id)
        {
            try
            {
                var obj = ServicioBL.GetServicio2(id);

                return Json(obj, JsonRequestBehavior.AllowGet);
            }
            catch
            {

                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }


        [HttpPost]
        public JsonResult ActualizarServicio(int idservicio, string nombre, string descripcion, decimal precio, string foto)
        {
            bool result = false;
            try
            {

                ServicioBL.ActualizarServicio(idservicio, nombre, descripcion, precio, foto);
                result = true;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return Json(result, JsonRequestBehavior.AllowGet);
            }

        }
    }
}