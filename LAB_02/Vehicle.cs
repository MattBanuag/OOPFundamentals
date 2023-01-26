using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkArea
{
    public class Vehicle
    {
        // Fields
        private string _licensePlate;
        private int _parkingSpot;
        int capacity = 5;

        // Properties
        public string LicensePlate
        {
            get { return _licensePlate; }
            set
            {
                if(value.Length >= 7)
                {
                    _licensePlate = value;
                } else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("License plate needs to be at least 7 characters.");
                }
            }
        }
        public int ParkingSpot
        {
            get { return _parkingSpot; }
            set
            {
                if (value < capacity || value > 0)
                {
                    _parkingSpot = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Parking spot does not exist");
                }
            }
        }

        // Constructor
        public Vehicle(string licensePlate) 
        {
            LicensePlate = licensePlate;
        }    
        
    }
}
