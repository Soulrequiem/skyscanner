﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace skyScanner
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteTable.Routes.MapHttpRoute(
                name: "DefaultAPI",
                routeTemplate: "api/airplaneQuoteController/{id}",
                defaults: new {id = System.Web.Http.RouteParameter.Optional}
                );
        }
    }
}
