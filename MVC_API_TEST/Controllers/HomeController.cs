using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_API_TEST.Controllers
{
    public class HomeController : Controller
    {
       


        // GET: Home
        public ActionResult Index(string UserName, string Ticket)
        {
            ViewBag.UserName = UserName;
            ViewBag.Ticket = Ticket;
            return View();
        }


        public ActionResult User()
        {
            return View();
        }

        public ActionResult GetUser()
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
    }
}