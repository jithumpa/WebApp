using WebApp.Domain.Entities;

namespace WebApp.DAL.UserProfiles
{
    public interface IUserProfileRepository : IGenericRepository<UserProfile>
    {
        int SampleServiceMethod(int firstNumber, int secondNumber);     
    }  
}
