using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ACM_Website.Controllers
{
    public class WebDevController : Controller
    {   //Shelby
        // GET: WebDev
        // ActionResult returns HTML
        public ActionResult Index()
        {
            //Picture - Jumbotron
            //Description
            return View();
        }
        public ActionResult Resources()
        {
            //Documents
            //Resources
            return View();
        }
        public ActionResult Agenda()
        {
            // Most recent thing to do - block
            //Past agenda - list
            return View();
        }
        public ActionResult Event()
        {
            //Upcoming list
            //History record event
            //Google Calendar
            return View();
        }
        public ActionResult Info()
        {
            //Captain -Members
            //Meetings times -Location
            //Description
            //Contact information
            return View();
        }
    }
}