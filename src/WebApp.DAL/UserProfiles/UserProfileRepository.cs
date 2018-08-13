using WebApp.Domain.Entities;

namespace WebApp.DAL.UserProfiles
{
    public class UserProfileRepository : GenericRepository<UserProfile>, IUserProfileRepository
    {
        public UserProfileRepository()
        {
        }

        public int SampleServiceMethod(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }    
}
