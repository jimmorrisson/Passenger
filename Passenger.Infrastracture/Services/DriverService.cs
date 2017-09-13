using System;
using System.Linq;
using System.Threading.Tasks;
using Passenger.Core.Repositories;
using Passenger.Infrastracture.DTO;

namespace Passenger.Infrastracture.Services
{
    public class DriverService : IDriverService
    {
        private readonly IDriverRepository _driverRepository;
        public DriverService(IDriverRepository driverRepository)
        {
            _driverRepository = driverRepository;
        }
        public async Task<DriverDto> GetAsync(Guid userId)
        {
            var driver = _driverRepository.GetAsync(userId);

            return new DriverDto
            {
                
            };
        }
    }
}