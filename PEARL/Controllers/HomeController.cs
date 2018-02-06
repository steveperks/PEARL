using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PEARL.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Pearl Collaboration";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ProjectSummary()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ProjectWorkstreams()
        {
            ViewBag.Message = "Project Workstreams";

            return View();
        }

        public ActionResult Workstream1()
        {
            return View();
        }

        public ActionResult Workstream2()
        {
            return View();
        }

        public ActionResult Workstream3()
        {
            return View();
        }

        public ActionResult Workstream4()
        {
            return View();
        }

        public ActionResult PatientExperience()
        {
            return View();
        }

        public ActionResult StaffExperience()
        {
            return View();
        }
    }
}