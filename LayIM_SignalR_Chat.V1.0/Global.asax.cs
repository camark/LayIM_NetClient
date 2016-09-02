﻿using LayIM_SignalR_Chat.V1._0.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace LayIM_SignalR_Chat.V1._0
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //增加异常处理
            GlobalFilters.Filters.Add(new LayIMExceptionFilter());
            
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
