﻿using System.Web;
using System.Web.Mvc;

namespace WS_EurekaBank_REST
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
