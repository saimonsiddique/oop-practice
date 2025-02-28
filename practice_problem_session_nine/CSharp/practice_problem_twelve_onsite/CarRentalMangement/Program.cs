Vehicle car = new Car("Toyota", "Corolla", new DateTime(2010, 2, 10), 5);
Vehicle bike = new Bike("Yamaha", "R1", new DateTime(2010, 2, 10), 1000);
Vehicle truck = new Truck("Toyota", "Tundra", new DateTime(2010, 2, 10), 2000);

int carRentalDays = 3;
int bikeRentalDays = 8;
int truckRentalDays = 2;

double carRentalCost = car.Rent(carRentalDays);
double bikeRentalCost = bike.Rent(bikeRentalDays);
double truckRentalCost = truck.Rent(truckRentalDays);


Console.WriteLine($"Car rental cost for {carRentalDays} days: ${carRentalCost}");
Console.WriteLine($"Bike rental cost for {bikeRentalDays} days: ${bikeRentalCost}");
Console.WriteLine($"Truck rental cost for {truckRentalDays} days: ${truckRentalCost}");