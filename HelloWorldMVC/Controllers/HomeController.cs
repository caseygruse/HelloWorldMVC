using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorldMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            DayOfWeek day = DateTime.Today.DayOfWeek;
            if(day == DayOfWeek.Thursday)
            {
                //ViewBag is a wrapper around ViewData
                ViewBag.Message = "It's Thorsday!";
                //Same as above
                ViewData["Message"] = "It's Thorsday!";

                //Data Inside of ViewBag/ViewData is automatically sent to the view.
            }
            else
            {
                ViewBag.Message = "Hulk Smash!";
            }
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public void Casey()
        {
            Response.Write("It's break time joe!");
        }
        
    }
}