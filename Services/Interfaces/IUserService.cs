using Services.Models.UserModels;

namespace Services.Interfaces
{
    public interface IUserService
    {
        void RegisterUser(UserDTO user);

        bool CanAuthenticate(UserDTO user);

        void EditUser(UserDTO user);

        UserDTO GetUser(UserDTO userModel);
    }
}
