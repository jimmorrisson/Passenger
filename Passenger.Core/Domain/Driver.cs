using System;
using System.Collections.Generic;

namespace Passenger.Core.Domain
{
    public class Driver
    {
        public Guid Id { get; protected set; }
        public Guid UserId { get; protected set; }
        public Vehicle Vehicle { get; protected set; }
        public IEnumerable<Route> Routes { get; protected set; }
        public IEnumerable<DailyRoute> DailyRoutes { get; protected set; }

        protected Driver()
        {
            
        }

        public Driver(Guid userId)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            //Vehicle = SetVehicle();
        }

        public Vehicle SetVehicle(string brand, string name, int seats)
        {
            try
            {
                Vehicle vehicle = new Vehicle(brand, name, seats);
                if(vehicle != null)
                {
                    return vehicle;
                }
            }
            catch
            {

            }
            return null;
        }
    }
}