using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ErrantDaydream.Models;

namespace ErrantDaydream.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Page = PageIndex.Home;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Page = PageIndex.About;
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Page = PageIndex.Contact;
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}