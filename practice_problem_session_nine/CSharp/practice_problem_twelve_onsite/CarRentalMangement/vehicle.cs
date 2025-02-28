public class Vehicle
{
  public string brand { get; set; }
  public string model { get; set; }
  public double rentRate { get; set; }
  public DateTime yearOfManufacture { get; set; }

  public Vehicle(string brand, string model, DateTime yearOfManufacture, double rentRate)
  {
    this.brand = brand;
    this.model = model;
    this.rentRate = rentRate;
    this.yearOfManufacture = yearOfManufacture;
  }

  public virtual double Rent(int rentalDays)
  {
    return rentRate * rentalDays;
  }
}