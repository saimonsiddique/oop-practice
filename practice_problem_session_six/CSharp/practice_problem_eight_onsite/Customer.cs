class Customer
{
  public string Name { get; set; }
  public DateTime DateOfBirth { get; set; }
  public CreditCard CreditCard { get; set; }

  public Customer(string name, DateTime dateOfBirth, CreditCard creditCard)
  {
    if (DateTime.Now.Year - dateOfBirth.Year < 18 ||
        DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
    {
      throw new ArgumentException("Customer must be at least 18 years old");
    }
    Name = name;
    DateOfBirth = dateOfBirth;
    CreditCard = creditCard;
  }

  public bool isCardValid()
  {
    return CreditCard.isCardValid();
  }

  public double availableCredit()
  {
    return CreditCard.availableCredit();
  }

  public void charge(double amount)
  {
    if (isCardValid())
    {
      if (amount > availableCredit())
      {
        throw new Exception("Amount exceeds available credit");
      }
    } else {
      throw new Exception("Card is not valid");
    }

    CreditCard.charge(amount);
  }

}