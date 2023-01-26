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


Vehicle A = new Vehicle("A0P-C4P");
Vehicle B = new Vehicle("S9F-P3D");
Vehicle C = new Vehicle("F7B-K3L");
Vehicle D = new Vehicle("C0P-P8N");
Vehicle E = new Vehicle("Z2Q-V6B");
Vehicle F = new Vehicle("G3H-P1S");
Vehicle G = new Vehicle("P9S-X3S");

CarPark.Park(A);
CarPark.Park(B);
CarPark.Park(C);
CarPark.Park(D);
CarPark.Park(E);
/*CarPark.Park(F);
CarPark.Park(G);*/





