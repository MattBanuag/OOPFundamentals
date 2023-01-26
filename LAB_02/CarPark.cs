using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkArea
{
    public class CarPark
    {
        // Fields
        private HashSet<Vehicle> ParkedCars = new HashSet<Vehicle>();
        private int _capacity = 20;

        // Park Method
        public void Park(Vehicle vehicle)
        {
            // Checking if there is space in the parking spot
            if(ParkedCars.Count > _capacity)
            {
                throw new Exception("~ ERROR: Parking lot is full.");
            } else 
            {
                // Checking if vehicle with the same license plate is already parked
                foreach (Vehicle car in ParkedCars)
                {
                    if (car.LicensePlate == vehicle.LicensePlate)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"~ Cannot park '{vehicle.LicensePlate}'. This vehicle is already parked in the parkade.");
                        Console.ResetColor();
                        return;
                    }
                }

                vehicle.ParkingSpot = ParkedCars.Count + 1;
                ParkedCars.Add(vehicle);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"~ {vehicle.LicensePlate} has been parked at {vehicle.ParkingSpot}.");
                Console.ResetColor();
            }
        }

        // CarPark Constructor
        public CarPark(int capacity)
        {
            if (capacity <= _capacity)
            {
                _capacity = capacity;
                Console.WriteLine($"Car Park with a capacity of {capacity} has been created.");
            } else
            {
                Console.ForegroundColor = ConsoleColor.Red; 
                throw new Exception($"~ ERROR: Capacity cannot be greater than {_capacity}.");
            }
        }
    }
}
