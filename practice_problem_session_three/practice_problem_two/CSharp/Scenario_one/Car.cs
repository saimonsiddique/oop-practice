public class Car
{
    public string CarType { get; set; }
    public double RentRate { get; set; }
    public DateTime RentStartDate { get; private set; }
    public DateTime RentEndDate { get; private set; }
    public double TotalRentPrice { get; private set; }
    public DateTime MaintenanceDate { get; set; }
    public CarStatus Status { get; private set; }

    public void RentCar(DateTime rentStartDate, DateTime rentEndDate)
    {
        if (Status != CarStatus.Available)
        {
            throw new Exception("Car is not available for rent.");
        }

        if ((rentStartDate <= MaintenanceDate) && (rentEndDate >= MaintenanceDate))
        {
            throw new Exception("Car is scheduled for maintenance during the selected rental period.");
        }

        RentStartDate = rentStartDate;
        RentEndDate = rentEndDate;
        Status = CarStatus.Rented;
        TotalRentPrice = CalculateTotalRentPrice(rentStartDate, rentEndDate);
    }

    private double CalculateTotalRentPrice(DateTime rentStartDate, DateTime rentEndDate)
    {
        double totalDays = (rentEndDate - rentStartDate).TotalDays;
        return totalDays * RentRate;
    }

    public void ReturnCar()
    {
        if (MaintenanceDate <= DateTime.Now)
        {
            Status = CarStatus.InMaintenance;
        }
        else
        {
            Status = CarStatus.Available;
        }
        RentStartDate = default(DateTime);
        RentEndDate = default(DateTime);
        TotalRentPrice = 0;
    }
}

public enum CarStatus
{
    Available,
    Rented,
    InMaintenance
}