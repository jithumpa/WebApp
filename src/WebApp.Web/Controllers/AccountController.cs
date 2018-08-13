using System;
using System.Configuration;
using System.Web.Mvc;
using System.Web.Security;
using WebApp.Web.Helpers;
using WebApp.Web.ViewModels.Login;
using WebApp.Web.ViewModels.Cache;

namespace WebApp.Web.Controllers
{
    public class AccountController : Controller
    {
        [RedirectIfLoggedIn]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {          
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                if (!String.Equals(model.Email, ConfigurationManager.AppSettings["Username"], StringComparison.OrdinalIgnoreCase))
                {                   
                    this.ModelState.AddModelError(string.Empty, "Invalid email Id.");
                    return View(model);
                }
                else if (!String.Equals(model.Password, ConfigurationManager.AppSettings["Password"], StringComparison.OrdinalIgnoreCase))
                {                  
                    this.ModelState.AddModelError(string.Empty, "Invalid password.");
                    return View(model);
                }
                else
                {
                    UserInCache user = new UserInCache()
                    {
                        Email = model.Email
                    };

                    if (user != null)
                    {
                        FormsAuthentication.SetAuthCookie(model.Email, false);
                        if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                            && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                        {
                            return Redirect(returnUrl);
                        }
                        else
                        {
                            return RedirectToAction("Index", "Dashboard");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                this.ModelState.AddModelError(string.Empty, ex.Message);
            }

            return View(model);
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                //var user = this.accountService.Get(model.Email);
                //if (user == null)
                //{
                //    ModelState.AddModelError("Email", "User doesnt exist in the system");
                //    return View(new ForgotPasswordViewModel { Email = model.Email });
                //}

                //this.accountService.ForgotPassword(model);

                //this.TempData["SuccessMsg"] = "The reset link has been sent to your registered email id.";

                //return RedirectToAction("ForgotPasswordConfirmation", "Account");
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();

            this.Session.RemoveAll();
            this.Session.Abandon();

            ViewBag.ReturnUrl = string.Empty;
            return View();
        }

        [Authorize]
        public ActionResult ChangePassword()
        {
            return View();
        }
    }
}