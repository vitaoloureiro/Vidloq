using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidloq
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapMvcAttributeRoutes();
            
            /* Maneira antiga de fazer, o MVC 5 uma o AttributeRoutes

            // nomeDaRota, padrao da url, valores padrão (new { nomeDaController, nomeDaActionResult
            routes.MapRoute(
                "FilmesPorData",
                "filmes/lancados/{ano}/{mes}",
                new {controller = "Filmes", action = "PorData"});
            ///////////////////////////////////////////////////////////////////////////////////////////
            // nomeDaRota, padrao da url, valores padrão (new { nomeDaController, nomeDaActionResult
            routes.MapRoute(
                "FilmesPorData",
                "filmes/lancados/{ano}/{mes}",
                new { controller = "Filmes", action = "PorData" },
                // usando expressão regular para obrigar que o ano tenha 4 digitos e o mês tenha 2 digitos
                // o @ informa que o próximo caracter é um caracter de escape
                new { ano = @"\d{4}", mes = @"\d{2}"});
          */
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
