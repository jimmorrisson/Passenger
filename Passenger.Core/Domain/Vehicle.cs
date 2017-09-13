using System;

namespace Passenger.Core.Domain
{
    public class Vehicle
    {
        public string Brand { get; protected set; }
        public string Name { get; protected set; }
        public int Seats { get; protected set; }

        protected Vehicle()
        {

        }
        
        public Vehicle(string brand, string name, int seats)
        {
            SetBrand(brand);
            SetName(name);
            SetSeats(seats);
        }

        private void SetBrand(string brand)
        {
            if(string.IsNullOrEmpty(brand) || brand.Length > 20)
            {
                throw new Exception("Brand is too long or empty");
            }
            if(Brand == brand)
            {
                return;
            }
            Brand = brand;
        }

        private void SetName(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be null or empty");
            }
            if(Name == name)
            {
                return;
            }
            Name = name;
        }

        private void SetSeats(int seats)
        {
            if(seats <= 0)
            {
                throw new Exception("Number of seats must be higher than 0!");
            }
            if(Seats == seats)
            {
                return;
            }
            Seats = seats;
        }

        public static Vehicle Create(string brand, string name, int seats)
            => new Vehicle(brand, name, seats);
    }
}