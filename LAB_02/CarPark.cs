using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkArea
{
    public static class CarPark
    {
        // Fields
        private static HashSet<Vehicle> ParkedCars = new HashSet<Vehicle>();
        private static int _capacity = 5;

        // Park Method
        public static void Park(Vehicle vehicle)
        {
            // Validating park capacity and parking vehicle
            if (ParkedCars.Count < _capacity)
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
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"~ Cannot park '{vehicle.LicensePlate}'. The lot is FULL.");
                Console.ResetColor();
            }
        }
    }
}
