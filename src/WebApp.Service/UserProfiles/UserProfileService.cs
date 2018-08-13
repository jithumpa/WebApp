using WebApp.DAL.UserProfiles;
using WebApp.Domain.Entities;
using WebApp.Service.Entity;

namespace WebApp.Service.Users
{
    public class UserProfileService : EntityService<UserProfile>, IUserProfileService
    {
        readonly IUserProfileRepository userProfileRepository;

        public UserProfileService(IUserProfileRepository userProfileRepository)
            : base(userProfileRepository)
        {
            this.userProfileRepository = userProfileRepository;
        }

        public int SampleServiceMethod(int firstNumber, int secondNumber)
        {
            return this.userProfileRepository.SampleServiceMethod(firstNumber, secondNumber);
        }
    }
}