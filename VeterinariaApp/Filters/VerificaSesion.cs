using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VeterinariaApp.Controllers;
using VeterinariaBE;
using VeterinariaBL;

namespace VeterinariaApp.Filters
{
    public class VerificaSesion : ActionFilterAttribute
    {
        private iniciar_sesion_Result oUsuario;
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                base.OnActionExecuting(filterContext);

                oUsuario = (iniciar_sesion_Result)HttpContext.Current.Session["User"];

                if(oUsuario == null)
                {
                    if(filterContext.Controller is AccesoController == false)
                    {
                        filterContext.HttpContext.Response.Redirect("~/Acceso/Login");
                    }
                }
            }
            catch (Exception)
            {

                filterContext.Result = new RedirectResult("~/Acceso/Login");
            }
        }
    }
}