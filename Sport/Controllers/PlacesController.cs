using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sport.Controllers
{
    public class PlacesController : Controller
    {
        // GET: Places
        public ActionResult Index()
        {
            return View();
        }
    }
}