using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using VeterinariaApp.App_Start;

namespace VeterinariaApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
