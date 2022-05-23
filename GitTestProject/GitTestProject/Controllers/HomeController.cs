using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitTestProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Title = "Login Page";

            return View();
        }
        [HttpPost]
        public ActionResult Login(string uname, string pass)
        {
            ViewBag.Title = "valid";
            return View(uname, pass);
        }
    }
}
