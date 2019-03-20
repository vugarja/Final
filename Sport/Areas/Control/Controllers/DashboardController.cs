using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sport.Areas.Control.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Control/Dashboard
        public ActionResult Index()
        {
            return View();
        }
    }
}