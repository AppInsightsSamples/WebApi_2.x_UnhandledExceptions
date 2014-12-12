using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.ApplicationInsights;

namespace WebApi2WithMVC.App_Start
{
    public class AiHandleErrorAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            var ai = new TelemetryClient();
            ai.TrackException(filterContext.Exception);
            base.OnException(filterContext);
        }
    }
}