using System.Threading.Tasks;
using Passenger.Infrastracture.DTO;

namespace Passenger.Infrastracture.Services
{
    public interface IUserService
    {
        Task<UserDto> GetDtoAsync(string email);
        Task RegisterAsync(string email, string username, string password);
    }
}