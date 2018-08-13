using System.Web.Mvc;
using System.Web.Routing;
using WebApp.Domain.Enums;

namespace WebApp.Web.Helpers
{
    public class RedirectIfLoggedIn : ActionFilterAttribute
    {
        public RedirectIfLoggedIn()
        {
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.User.Identity.IsAuthenticated && SiteUser.User != null)
            {

                if (SiteUser.User.Role == UserRole.Administrator)
                {
                    // Redirect to Dashboard - Change based on requirement
                    filterContext.Result =
                            new RedirectToRouteResult(
                                new RouteValueDictionary { { "Controller", "Dashboard" }, { "Action", "Index" } });
                }
                else if (SiteUser.User.Role == UserRole.Head || SiteUser.User.Role == UserRole.Manager)
                {
                    filterContext.Result =
                            new RedirectToRouteResult(
                                new RouteValueDictionary { { "Controller", "SomeController" }, { "Action", "SomeView" } });
                }
                else
                {
                    filterContext.Result =
                           new RedirectToRouteResult(
                               new RouteValueDictionary { { "Controller", "Dashboard" }, { "Action", "Index" } });
                }
            }

            base.OnActionExecuting(filterContext);
        }
    }
}