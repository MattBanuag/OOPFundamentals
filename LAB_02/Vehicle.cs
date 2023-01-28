using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkArea
{
    public class Vehicle
    {
        private string _licenseNumber;
        private int _spotNumber;
        private HashSet<ParkingSpot> _parkingSpots = new HashSet<ParkingSpot>();

        public string LicenseNumber
        {
            get { return _licenseNumber; }
        }

        public HashSet<ParkingSpot> ParkingSpots
        {
            get { return _parkingSpots; }
        }

        // METHOD
        private void _setVehicle(string licenseNumber)
        {
            if(licenseNumber.Length < 0 || licenseNumber.Length > 7)
            {
                throw new Exception($"'{licenseNumber}' is not valid");
            } else
            {
                _licenseNumber = licenseNumber;
            }
        }

        // CONSTRUCTOR
        public Vehicle(string licenseNumber)
        {
            _setVehicle(licenseNumber);
        }
    }
}
