﻿using System.Web;
using System.Web.Mvc;

namespace HabitSculpter.Service.HSAPI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
