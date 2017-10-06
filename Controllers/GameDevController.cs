using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ACM_Website.Controllers
{
    public class GameDevController : Controller
    {   //Game Dev
        // GET: GameDev
        // ActionResult returns HTML
        public ActionResult Index()
        {
            ViewBag.Whatever = "Whatever";
            return View();
        }
        public ActionResult Resources()
        {
            return View();
        }
        public ActionResult Agenda()
        {
            return View();
        }
        public ActionResult Event()
        {
            return View();
        }
        public ActionResult Info()
        {
            return View();
        }
    }
}