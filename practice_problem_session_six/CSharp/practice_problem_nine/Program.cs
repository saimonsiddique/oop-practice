Owner owner = new Owner("Saimon", "Dhaka", "01700000000");
LicencePlate licencePlate = new LicencePlate("Dhaka Metro HA-123456", new DateTime(2010, 2, 1), new DateTime(2026, 1, 1));
Car car = new Car(owner, licencePlate, "Toyota", "Corolla", new DateTime(2001, 1, 1));

Console.WriteLine(car.GetCarInfo());
Console.WriteLine($"Car Age: {car.GetCarAge().Days / 365} years");
Console.WriteLine($"Is Needed to Renew Licence Plate: {car.IsNeededToRenewLicencePlate()}");
Console.WriteLine($"Is Qualify to Renew Registration: {car.IsNeededToRenewRegistration()}");