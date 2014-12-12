﻿using System;

using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using ProductsAppPureWebAPI.App_Start;

namespace WebApi2WithMVC
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Services.Replace(typeof(IExceptionHandler), new AiExceptionHandler());
        }
    }
}
//config.Services.Add(typeof(IExceptionLogger), new AiExceptionLogger());            
//config.Filters.Add(new AiExceptionFilterAttribute());
//config.Services.Replace(typeof(IExceptionHandler), new AiExceptionHandler());