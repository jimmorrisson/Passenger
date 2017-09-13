using AutoMapper;
using Passenger.Core.Domain;
using Passenger.Infrastracture.DTO;

namespace Passenger.Infrastracture.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDto>();
                cfg.CreateMap<Driver, DriverDto>();
            }).CreateMapper();
    }
}