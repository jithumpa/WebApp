using WebApp.Domain.Entities;
using WebApp.Service.Entity;

namespace WebApp.Service
{
    public interface IUserProfileService : IEntityService<UserProfile>
    {
        int SampleServiceMethod(int firstNumber, int secondNumber);
    }
}
