Car car = new Car();
car.CarType = "Sedan";
car.RentRate = 50;
car.MaintenanceDate = new DateTime(2025, 02, 14);

try
{
  car.RentCar(new DateTime(2025, 02, 1), new DateTime(2025, 02, 14));
    Console.WriteLine($"Total Rent Price: {car.TotalRentPrice}");  
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

car.ReturnCar();