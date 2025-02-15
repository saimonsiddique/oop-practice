class LicencePlate
{
  public string LicencePlateNumber { get; set; }
  public DateTime RegistrationDate { get; set; }
  public DateTime ExpirationDate { get; set; }

  public LicencePlate(string licencePlateNumber, DateTime registrationDate, DateTime expirationDate)
  {
    LicencePlateNumber = licencePlateNumber;
    RegistrationDate = registrationDate;
    ExpirationDate = expirationDate;
  }

  public bool IsExpired()
  {
    return ExpirationDate < DateTime.Now;
  }

  public string GetLicencePlateInfo()
  {
    return $"Licence Plate Number: {LicencePlateNumber}\nRegistration Date: {RegistrationDate}\nExpiration Date: {ExpirationDate}";
  }
}