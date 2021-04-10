using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InstituteFinderApplication.Controllers
{
     public class HomeController : Controller
    {
        //This varriable is used to store temp ID from Index view
        public static string TempID;

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Course(string ID)
        {
            TempID = ID;

            return View();
        }
    }
}