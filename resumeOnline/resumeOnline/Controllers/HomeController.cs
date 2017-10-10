using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace resumeOnline.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "How To Get A Hold Of Me";

            return View();
        }
        public ActionResult Experience()
        {
            return View();
        }
        public ActionResult Certifications()
        {
            return View();
        }
        public ActionResult Skills()
        {
            return View();
        }
        public ActionResult Education()
        {
            return View();
        }
    }
}