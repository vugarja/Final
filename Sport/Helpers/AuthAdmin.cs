using System.Web;
using System.Web.Mvc;

namespace Sport.Helpers
{
    public class AuthAdmin:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.Session["LoginSuccess"] == null)
            {
                filterContext.Result = new RedirectResult("~/control");
                return;
            }

            base.OnActionExecuting(filterContext);
        }
    }
}