using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkArea
{
    public class CarPark
    {
        private int _carParkNumber;
        private int _capacity = 20;
        private HashSet<ParkingSpot> _parkingSpots = new HashSet<ParkingSpot>();    

        // PROPERTIES
        public HashSet<ParkingSpot> ParkingSpots
        {
            get { return _parkingSpots; }
        }
        public int CarParkNumber
        {
            get { return _carParkNumber; }
        }

        // METHODS
        private void _setCarPark(int carParkNumber, int capacity)
        {
            if(capacity > _capacity || capacity < 0)
            {
                throw new Exception($"A capacity of {capacity} is not valid. Your CARPARK should only have a MAX of {_capacity}");
            } else
            {
                if (carParkNumber < 0 || carParkNumber > 100)
                {
                    throw new Exception($"{carParkNumber} is not a valid number");
                }
                else
                {
                    _carParkNumber = carParkNumber;
                }
            }
        }
        public void ParkVehicle(int spotNumber, CarPark carPark, Vehicle vehicle)
        {
            _parkingSpots.Add(new ParkingSpot(spotNumber, carPark, vehicle));
            vehicle.ParkingSpots.Add(new ParkingSpot(spotNumber, carPark, vehicle));
        } 
        public void RemoveVehicle(string licenseNumber)
        {
            foreach(ParkingSpot parkingSpot in _parkingSpots)
            {
                if (parkingSpot.Vehicle.LicenseNumber == licenseNumber)
                {
                    _parkingSpots.Remove(parkingSpot);
                    return;
                }
            }
        }

        // CONSTRUCTOR
        public CarPark(int carParkNumber, int capacity) 
        {
            _setCarPark(carParkNumber, capacity);
        }
    }
}