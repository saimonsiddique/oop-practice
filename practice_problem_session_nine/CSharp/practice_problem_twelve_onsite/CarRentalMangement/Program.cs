Vehicle car = new Car("Toyota", "Corolla", new DateTime(2010, 2, 10), 5);
Vehicle bike1 = new Bike("Yamaha", "R1", new DateTime(2010, 2, 10), 1000);
Vehicle bike2 = new Bike("Honda", "CBR", new DateTime(2010, 2, 10), 600);
Vehicle truck = new Truck("Toyota", "Tundra", new DateTime(2010, 2, 10), 2000);

List<Vehicle> vehicles = new List<Vehicle>();
vehicles.Add(car);
vehicles.Add(bike1);
vehicles.Add(bike2);
vehicles.Add(truck);

int RentalDays = 10;

foreach (Vehicle vehicle in vehicles)
{
  Console.WriteLine(vehicle.Rent(RentalDays));
}
