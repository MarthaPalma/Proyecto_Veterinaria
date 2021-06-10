using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VeterinariaBL;
using VeterinariaBE;
using System.IO;
using System.Drawing;
using VeterinariaApp.Helpers.Sesion;

namespace VeterinariaApp.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            if (AdministradorSesion.SesionActiva == false)
            {
                return RedirectToAction("Login", "Acceso");
            }
            var lst = ProductoBL.ListarProducto();
            ViewBag.PRODUCTO = lst;

            ViewBag.TIPOPRODUCTO = new SelectList(
            ProductoBL.ListarTipoProducto().ToList(), "idtipoproducto", "desctipoproducto");

            ViewBag.PROVEEDOR = new SelectList(
            ProductoBL.ListarProveedor().ToList(), "idproveedor", "razonsocial");



            return View();
        }

        [HttpPost]
        public JsonResult InsertarProducto(string nombre, int idtipoproducto, string descripcion, int idproveedor, decimal precio, int stock, string foto)
        {
            bool result = false;
            try
            {
                ProductoBL.InsertarProducto(nombre, idtipoproducto, descripcion, idproveedor, precio, stock, foto);
                result = true;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return Json(result, JsonRequestBehavior.AllowGet);
            }

        }

        [HttpPost]
        public JsonResult EliminarProducto(int id)
        {
            bool result = false;
            try
            {

                ProductoBL.EliminarProducto(id);
                result = true;

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }


        [HttpPost]
        public JsonResult GetProducto(int id)
        {
            try
            {
                var obj = ProductoBL.GetProducto2(id);

                return Json(obj, JsonRequestBehavior.AllowGet);
            }
            catch 
            {

                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }


        [HttpPost]
        public JsonResult ActualizarProducto(int idproducto, string nombre, int idtipoproducto, string descripcion, int idproveedor, decimal precio, int stock, string foto)
        {
            bool result = false;
            try
            {

                ProductoBL.ActualizarProducto(idproducto, nombre, idtipoproducto, descripcion, idproveedor, precio, stock, foto);
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