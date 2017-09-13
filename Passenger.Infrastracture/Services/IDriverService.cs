using System;
using System.Threading.Tasks;
using Passenger.Infrastracture.DTO;

namespace Passenger.Infrastracture.Services
{
    public interface IDriverService
    {
         Task<DriverDto> GetAsync(Guid userId);
    }
}