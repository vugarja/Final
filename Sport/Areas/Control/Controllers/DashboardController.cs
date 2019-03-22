using System.Web.Mvc;
using Sport.Helpers;
using Sport.Models;

namespace Sport.Areas.Control.Controllers
{
    [AuthAdmin]
    public class DashboardController : Controller
    {
        public ActionResult Index()
        {
            Admin admin = Session["Admin"] as Admin;

            return View(admin);
        }
    }
}