using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using VeterinariaBE;

namespace VeterinariaApp.Helpers.Sesion
{
    /// <summary>
    /// 
    /// </summary>
    public static class AdministradorSesion
    {
        /// <summary>
        /// SesionActiva
        /// </summary>
        public static bool SesionActiva
        {
            set
            {
                HttpContext.Current.Session["SesionActiva"] = value;
            }
            get
            {
                if (HttpContext.Current.Session["SesionActiva"] == null) return false;
                return bool.Parse(HttpContext.Current.Session["SesionActiva"].ToString());
            }
        }

        public static iniciar_sesion_Result Usuario
        {
            set
            {
                var user = value;
                HttpContext.Current.Session["Usuario"] = user;
            }
            get
            {
                if (HttpContext.Current.Session["Usuario"] == null)
                {
                    CerrarSession();
                    string ruta = ConfigurationManager.AppSettings["Inicio"].ToString();
                    HttpContext.Current.Response.Redirect(ruta);
                }
                return (iniciar_sesion_Result)HttpContext.Current.Session["Usuario"];
            }
        }

        public static void CerrarSession()
        {
            HttpContext.Current.Session.Clear();
            FormsAuthentication.SignOut();

            HttpContext.Current.User = null;
            HttpContext.Current.Session.Abandon();

        }
    }
}