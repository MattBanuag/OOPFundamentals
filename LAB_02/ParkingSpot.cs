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
        public Vehicle Vehicle
        {
            get { return _vehicle; }
        }

        // CONSTRUCTOR
        public ParkingSpot(int spotNumber, CarPark carPark, Vehicle vehicle) 
        {
            _spotNumber = spotNumber;
            _carPark = carPark;
            _vehicle = vehicle;
        }
    }  
}
