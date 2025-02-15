public class Owner
{
  public string Name { get; set; }
  public string Address { get; set; }
  public string PhoneNumber { get; set; }

  public Owner(string name, string address, string phoneNumber)
  {
    Name = name;
    Address = address;
    PhoneNumber = phoneNumber;
  }
}