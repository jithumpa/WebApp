using System.Web.Mvc;

namespace WebApp.Web.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {       
        public ActionResult Index()
        {
            return View();
        }
    }
}