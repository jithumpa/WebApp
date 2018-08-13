using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Service;

namespace WebApp.Web.Areas.Customer.Controllers
{
    public class CustController : Controller
    {
        readonly IUserProfileService userProfileService;

        public CustController(IUserProfileService userProfileService)
        {
            this.userProfileService = userProfileService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult custdisplayscreen()
        {
            return View();
        }

        [HttpPost]
        public ActionResult custdisplayscreen(Areas.Customer.Models.Customer model)
        {
            
            if(string.IsNullOrEmpty(model.Name))
            {
                ModelState.AddModelError("Name", "Name is required");
            }
            
            if(ModelState.IsValid)
            {
                ViewBag.Name = model.Name;
            }

            if (ModelState.IsValid)
            {
                ViewBag.Name = model.Name;
                ViewBag.Email = model.Email;
            }
            return View(model);
        }
    }
}