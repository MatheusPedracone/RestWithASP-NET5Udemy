using RestWithASPNETUdemy.Data.DTO;
using RestWithASPNETUdemy.models;

namespace RestWithASPNETUdemy.Repository
{
    public interface IUserRepository
    {
         User ValidateCredentials(UserDTO user);

        User ValidateCredentials(string userName);

        User RefreshUserInfo(User user);
    }
}
