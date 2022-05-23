using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GitTestProject.Models;

namespace GitTestProject.Controllers
{
    public class HomeController : Controller
    {
        empManagementEntities con=new empManagementEntities();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult Login()
        {
           return View();
        }
        [HttpPost]
        public ActionResult Login(string Login, string Password)
        {
            var res=(from t in con.employees where t.Login == Login &&t.Password == Password select t).FirstOrDefault();
            if (res != null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Titl = "Invalid "+Login+" and "+Password;
                return View();
            }
        }
        #region Register
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(employee employee)
        {
            if(ModelState.IsValid)
            {
                con.employees.Add(employee);
                if (con.SaveChanges() > 0)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    ViewData["msg"] = "invalid user";
                    return View();
                }
            }
            ViewData["msg"] = "invalid user";
            return View();
        }
            #endregion
    }
}