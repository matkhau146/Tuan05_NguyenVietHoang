﻿using System.Web;
using System.Web.Mvc;

namespace Tuan05_NguyenVietHoang
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
