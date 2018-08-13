using System.Web.Mvc;
using WebApp.Service;
using WebApp.Web.Helpers;

namespace WebApp.Web.Controllers
{
    public class HomeController : Controller
    {
        readonly IUserProfileService userProfileService;

        public HomeController(IUserProfileService userProfileService)
        {
            this.userProfileService = userProfileService;
        }

        //[RedirectIfLoggedIn]
        public ActionResult Index()
        {
            this.userProfileService.GetById(1);
            return View();
        }        
    }
}