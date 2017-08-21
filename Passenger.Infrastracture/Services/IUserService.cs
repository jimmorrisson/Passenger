using Passenger.Infrastracture.DTO;

namespace Passenger.Infrastracture.Services
{
    public interface IUserService
    {
        UserDto GetDto(string email);
        void Register(string email, string username, string password);
    }
}