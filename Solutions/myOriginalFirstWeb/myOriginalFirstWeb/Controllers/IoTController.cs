using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myOriginalFirstWeb.Controllers
{
    public class IoTController : Controller
    {
        // GET: IoT
        public ActionResult Index()
        {
            return View();
        }

        public String myAction(string name1)
        {
            return "MyAction : "+name1;
        }
    }
}