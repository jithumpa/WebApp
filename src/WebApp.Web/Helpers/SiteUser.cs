using WebApp.Web.Infrastructure;
using WebApp.Web.ViewModels.Cache;

namespace WebApp.Web.Helpers
{
    public static class SiteUser
    {
        public static UserInCache User
        {
            get
            {
                return new CacheService().GetSession(SessionKeys.User, GetLoggedInUser);
            }
        }

        private static UserInCache GetLoggedInUser()
        {
            // TO DO: Get the user and its role and add to cache.

            // var userRoleService = GetService<IUserRoleService>();
            // UserInCache user = userRoleService.GetUserandRole(HttpContext.Current.User.Identity.Name);

            UserInCache user = new UserInCache();

            if (user == null)
            {
                return null;
            }

            return user;
        }       
    }
}