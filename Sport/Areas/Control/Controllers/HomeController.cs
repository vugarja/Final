using System.Web.Mvc;
using Sport.Models;
using Sport.DAL;
using System.Linq;
using System.Web.Helpers;

namespace Sport.Areas.Control.Controllers
{
    public class HomeController : Controller
    {
        private readonly SportContext db = new SportContext();

        // GET: Control/Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(Admin admin)
        {
            if (string.IsNullOrEmpty(admin.Email) || string.IsNullOrEmpty(admin.Password))

            {
                Session["LoginError"] = "E-poçt və şifrə doldurulmalıdır";
                return RedirectToAction("index");
            }

            Admin adm = db.Admins.FirstOrDefault(a => a.Email == admin.Email);

            if (adm!=null)
            {
                if (Crypto.VerifyHashedPassword(adm.Password,admin.Password))
                {
                    Session["LoginSuccess"] = true;
                    return RedirectToAction("index", "dashboard");
                }
            }

            Session["LoginError"] = "E-poçt vəya şifrə düz deyil";
            return RedirectToAction("index");

        }

        public ActionResult Logout()
        {
            Session["logined"] = null;
            return RedirectToAction("index");
        }

       
    }
}