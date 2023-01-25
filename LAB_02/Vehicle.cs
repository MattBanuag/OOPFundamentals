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
        private string _parkingSpot;

        // Properties
        public string LicensePlate
        {
            get { return _licensePlate; }
        }
        public string ParkingSpot
        {
            get { return _parkingSpot; }
        }
        // Constructor
        public Vehicle(string licensePlate, string parkingSpot) 
        {
            _licensePlate = licensePlate;
            _parkingSpot = parkingSpot;
        }    
        
    }
}
