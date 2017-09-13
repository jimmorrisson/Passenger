using System;
using System.Collections.Generic;
using Passenger.Core.Domain;

namespace Passenger.Infrastracture.DTO
{
    public class DriverDto
    {
        public Guid ID { get; set; }
        public Vehicle Vehicle { get; set; }
        public IEnumerable<Route> Routes { get; set; }
        public IEnumerable<DailyRoute> DailyRoutes { get; set; }
    }
}