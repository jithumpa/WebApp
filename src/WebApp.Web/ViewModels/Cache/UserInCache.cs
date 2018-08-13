using WebApp.Domain.Enums;

namespace WebApp.Web.ViewModels.Cache
{
    public class UserInCache
    {
        public UserInCache()
        {
        }

        public int UserId { get; set; }

        public string Name { get; set; }

        public string ContactNumber { get; set; }

        public string Email { get; set; }

        public UserRole Role { get; set; }       
    }
}