﻿using System.Web;
using System.Web.Mvc;

namespace Logging_Audit_Trails
{
  public class FilterConfig
  {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    {
      filters.Add(new HandleErrorAttribute());
    }
  }
}