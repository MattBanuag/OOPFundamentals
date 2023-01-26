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

        // Park Method
        public static void Park(Vehicle vehicle)
        {
            int capacity = 5;
            if(ParkedCars.Count < capacity)
            {
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
                return;
            }
        }
    }
}
