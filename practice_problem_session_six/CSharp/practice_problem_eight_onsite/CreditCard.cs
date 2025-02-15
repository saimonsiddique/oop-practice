using System;

public class CreditCard
{
  private string cardNumber { get; set; }
  private DateTime expirationDate { get; set; }
  private double creditLimit { get; set; } = 500000;

  public CreditCard(string cardNumber, DateTime expirationDate, double creditLimit)
  {
    // Check if card number only contains digits
    if (!cardNumber.All(char.IsDigit) && cardNumber.Length != 11)
    {
      throw new Exception("Card number must only contain digits");
    }

    this.cardNumber = cardNumber;
    this.expirationDate = expirationDate;
    this.creditLimit = creditLimit;
  }

  public bool isCardValid()
  {
    return DateTime.Now < expirationDate;
  }

  public double availableCredit()
  {
    return creditLimit;
  }
  
  public void charge(double amount)
  {
    if (amount > creditLimit)
    {
      throw new Exception("Amount exceeds credit limit");
    }
    creditLimit -= amount;
  }

}