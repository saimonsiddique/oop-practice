public class Bike : Vehicle
{
  public int engineSize { get; set; }
  public bool isAvailable { get; set; }

  public Bike(string brand, string model, DateTime yearOfManufacture, int engineSize) : base(brand, model, yearOfManufacture, 15.00)
  {
    this.isAvailable = true;
  }

  public void UpdateAvailability(bool isAvailable)
  {
    this.isAvailable = isAvailable;
  }

  public override double Rent(int rentalDays)
  {
    double rentalCost = base.Rent(rentalDays);
    if (rentalDays > 7)
    {
      rentalCost *= 0.85;
    }
    return rentalCost;
  }
}