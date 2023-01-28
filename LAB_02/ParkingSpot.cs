using ParkArea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkArea
{
    public class ParkingSpot
    {
        private int _spotNumber;
        private Vehicle _vehicle;
        private CarPark _carPark;

        // PROPERTIES
        public int SpotNumber
        {
            get { return _spotNumber; }
        }

        public CarPark CarPark
        {
            get { return _carPark; }
        }

        public Vehicle Vehicle
        {
            get { return _vehicle; }
        }

        // METHODS

        // CONSTRUCTOR
        // Initialize Parking Spots
        public ParkingSpot(int spotNumber, CarPark carPark, Vehicle vehicle) 
        {
            _spotNumber = spotNumber;
            _carPark = carPark;
            _vehicle = vehicle;
        }
    }  
}
