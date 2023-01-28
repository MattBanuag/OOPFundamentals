using ParkArea;

try
{
    CarPark CarParkOne = new CarPark(1, 20);
    Vehicle CarOne = new Vehicle("A0P-M8C");
    Vehicle CarTwo = new Vehicle("Z1L-F6X");

    CarParkOne.ParkVehicle(1, CarParkOne, CarOne);
    CarParkOne.ParkVehicle(1, CarParkOne, CarTwo);
    DisplayParkedVehicles(CarParkOne);
    ParkingSpot NewParkingSpot = new ParkingSpot(1, CarParkOne, CarOne);

    CarParkOne.RemoveVehicle("Z1L-F6X");
    DisplayParkedVehicles(CarParkOne);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

void DisplayParkedVehicles(CarPark carPark)
{
    foreach (ParkingSpot spot in carPark.ParkingSpots)
    {
        Console.WriteLine(spot.Vehicle.LicenseNumber);
    } 
}