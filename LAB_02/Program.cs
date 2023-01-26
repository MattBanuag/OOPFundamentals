using ParkArea;
using System.Drawing;
/// Create an OOP "Carpark" System
/// At its most basic, the static CarPark class will have a private HashSet of Vehicles, and a method: public static void Park (Vehicle vehicle) method.
/// Vehicles have a string LicenseNumber, and a string ParkingSpot
/// Both should be private and validated with public properties
/// 
/// When the Park method is invoked, it adds the vehicle to the CarPark HashSet,  counts the vehicles in the HashSet, and uses that number to assign a spot.
/// If 20 vehicles are parked, then the 21st vehicle parked is given spot 21.
/// 
/// It should prevent a vehicle from parking in more than one spot (if it already has a spot) or if the spots are over capacity.
/// 

/*
    
Create a third class, called ParkingSpot. It should have a string Number field/property, a Vehicle property, and a CarPark property.
    
Vehicles should now have a HashSet of ParkingSpots.
    CarPark should now have a HashSet of ParkingSpots.
   
When the program is initialized, the CarPark should initialize, and add to its HashSet of ParkingSpots, the amount matching its capacity, and number them from 1 to Capacity.
        The ParkingSpot should add the CarPark as its CarPark property.
    
CarPark should have a ParkVehicle property, that takes a Vehicle object, searches for the lowest-numbered available spot, and "parks" the car
        The found ParkingSpot adds the Vehicle to its Vehicle property.
        The Vehicle will add the ParkingSpot to its ParkingSpots property.
   
CarPark should also have a RemoveVehicle method, that takes a vehicle license, and removes that vehicle from all of the spots that it is parked in.
        It should remove the vehicle from the ParkingSpot's Vehicle property.
        It should remove the ParkingSpot from the Vehicle's ParkingSpots property.

*/

// INITIALIZE CAR PARK
try
{
    CarPark ParkOne = new CarPark(20);
} catch(Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.ResetColor();
}







