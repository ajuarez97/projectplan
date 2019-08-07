using System.Web.Mvc;
using System.Web.Routing;

namespace ProjectPlan
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "GetUserInformation",
                url: "{controller}/{action}/{userId}",
                defaults: new { controller = "Home", action = "GetUserInformation", userId = UrlParameter.Optional }
            );
        }
    }
}
