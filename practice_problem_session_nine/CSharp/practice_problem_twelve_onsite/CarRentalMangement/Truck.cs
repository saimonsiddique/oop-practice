public class Truck : Vehicle
{
  public double baseRentalPrice { get; set; }
  public double weightCapacity { get; set; }
  public bool isAvailable { get; set; }

  public Truck(string brand, string model, DateTime yearOfManufacture, double weightCapacity) : base(brand, model, yearOfManufacture, 100.00)
  {
    this.baseRentalPrice = baseRentalPrice;
    this.weightCapacity = weightCapacity;
    this.isAvailable = true;
  }

  public void UpdateAvailability(bool isAvailable)
  {
    this.isAvailable = isAvailable;
  }

  public override double Rent(int rentalDays)
  {
    double rentalCost = base.Rent(rentalDays);
    rentalCost += 100 * rentalDays;
    return rentalCost;
  }
}