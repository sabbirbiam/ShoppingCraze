using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingCraze.Web.Mvc.Models;

namespace ShoppingCraze.Web.Mvc.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginVM obj)
        {
            if(obj.UserName=="admin" && obj.Password == "admin")
            {
                Session["user"] = "admin";
                return RedirectToAction("Index", "Course");
            }

            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            Session.Abandon();            
            return View();
        }
    }
}