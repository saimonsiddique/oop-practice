class Car
{
  public Owner Owner { get; set; }
  public LicencePlate LicencePlate { get; set; }
  public string Manufacturer { get; set; }
  public string Model { get; set; }
  public DateTime YearOfManufacture { get; set; }

  public Car(Owner owner, LicencePlate licencePlate, string manufacturer, string model, DateTime yearOfManufacture)
  {
    Owner = owner;
    LicencePlate = licencePlate;
    Manufacturer = manufacturer;
    Model = model;
    YearOfManufacture = yearOfManufacture;
  }

  public TimeSpan GetCarAge()
  {
    return DateTime.Now - YearOfManufacture;
  }

  public Owner GetOwner()
  {
    return Owner;
  }

  public LicencePlate GetLicencePlate()
  {
    return LicencePlate;
  }

  public string GetCarInfo()
  {
    return $"Manufacturer: {Manufacturer}\nModel: {Model}\nYear of Manufacture: {YearOfManufacture}\nOwner: {Owner.Name}\n{LicencePlate.GetLicencePlateInfo()}";
  }

  public bool IsNeededToRenewLicencePlate()
  {
    return LicencePlate.IsExpired();
  }

  public bool IsQualifyToRenewRegistration()
  {
    return YearOfManufacture.AddYears(20) < DateTime.Now;
  }
}