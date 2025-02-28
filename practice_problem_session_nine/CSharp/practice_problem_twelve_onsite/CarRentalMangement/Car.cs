public interface ICar
{
    global::System.Int32 numberOfSeats { get; set; }
    global::System.Boolean isAvailable { get; set; }

    void UpdateAvailability(global::System.Boolean isAvailable);
}

public class Car : Vehicle, ICar
{
    public int numberOfSeats { get; set; }
    public bool isAvailable { get; set; }

    public Car(string brand, string model, DateTime yearOfManufacture, int numberOfSeats) : base(brand, model, yearOfManufacture, 50)
    {
        this.numberOfSeats = numberOfSeats;
        this.isAvailable = true;
    }

    public void UpdateAvailability(bool isAvailable)
    {
        this.isAvailable = isAvailable;
    }

    public override double Rent(int rentalDays)
    {
        double rentalCost = base.Rent(rentalDays);
        if (DateTime.Now.Year - yearOfManufacture.Year > 5)
        {
            rentalCost *= 0.9;
        }
        return rentalCost;
    }
}