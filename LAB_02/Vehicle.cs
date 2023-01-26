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
        private int _capacity = 5;

        // Properties
        public string LicensePlate
        {
            get { return _licensePlate; }
        }
        public int ParkingSpot
        {
            get { return _parkingSpot; }
            set
            {
                if (value < _capacity || value > 0)
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
            if (licensePlate.Length < 7 || licensePlate.Length > 7)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                throw new Exception("License plate needs to be at least 7 characters.");
            }
            else
            {
                _licensePlate = licensePlate;
            }
        }    
        
    }
}
