using System;

namespace WebApp.Domain.Entities
{
    public class UserProfile : BaseEntity
    {
        public UserProfile()
        {
        }

        public string Email { get; set; }

        public string HashPassword { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }      

        public string MobileNumber { get; set; }

        public DateTime RegisteredDate { get; set; }      

        public bool IsBlocked { get; set; }
    }
}
