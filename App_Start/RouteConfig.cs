using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Index",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Pago",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Pago", action = "Pago", id = UrlParameter.Optional });

            routes.MapRoute(
                name: "Productos",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Productos", action = "Productos", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Registro",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Registro", action = "Registro", id = UrlParameter.Optional }
            );
            routes.MapRoute(
    name: "Reserva",
    url: "{controller}/{action}/{id}",
    defaults: new { controller = "Reserva", action = "Reserva", id = UrlParameter.Optional }
);
            routes.MapRoute(
    name: "ResumenPago",
    url: "{controller}/{action}/{id}",
    defaults: new { controller = "ResumenPago", action = "ResumenPago", id = UrlParameter.Optional }
);
        }
    }
}
