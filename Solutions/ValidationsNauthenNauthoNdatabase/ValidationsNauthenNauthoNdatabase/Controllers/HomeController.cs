using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationsNauthenNauthoNdatabase.Models;

namespace ValidationsNauthenNauthoNdatabase.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Login(LoginSubmit user)
        { 
            return View("Login",user);
        }

        public ActionResult Register()
        {
            return View();
        }
        public ActionResult SubmitLogin(LoginSubmit user)
        {
            if (!ModelState.IsValid)
                return View("Login",user);
            else
                return View();
        }


    }
}