using System;
using System.Collections.Generic;
using System.Web.Mvc;
using WebApp.Domain.Enums;

namespace WebApp.Web.Helpers
{
    public class RolesAuthorizeAttribute : AuthorizeAttribute
    {
        public new IList<UserRole> Roles;

        public RolesAuthorizeAttribute(params UserRole[] roles)
        {
            this.Roles = roles;
        }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext == null)
            {
                throw new ArgumentNullException("filterContext");
            }

            if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                filterContext.Result =
                    new RedirectResult("/Account/Login?returnurl=" + filterContext.HttpContext.Request.RawUrl);
                return;
            }
            if (this.Roles.Contains(SiteUser.User.Role))
            {
                return;
            }

            filterContext.Result = new RedirectResult("/Home/Index");
        }
    }
}