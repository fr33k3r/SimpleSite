using SimpleSite.Filters;
using SimpleSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleSite.Controllers
{
  public class HomeController : Controller
  {
       
    public ActionResult Index()
    {

      return View();
    }

    public ActionResult About()
    {
      ViewBag.Message = "This is a sample application to introduce ASP.NET with Bootstrap.";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }
  }
}