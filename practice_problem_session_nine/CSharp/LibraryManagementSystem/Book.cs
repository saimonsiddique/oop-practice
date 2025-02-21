public class Book
{
  public string Title { get; private set; }
  public string Author { get; private set; }
  public string ISBN { get; private set; }
  public int TotalQuantity { get; private set; }
  public int AvailableQuantity { get; private set; }

  public Book(string title, string author, string isbn, int quantity)
  {
    Title = title;
    Author = author;
    ISBN = isbn;
    TotalQuantity = quantity;
    AvailableQuantity = quantity;
  }

  public void UpdateQuantity(int quantity)
  {
    TotalQuantity += quantity;
    AvailableQuantity += quantity;
  }

  public bool IsAvailable()
  {
    return AvailableQuantity > 0;
  }

  public void Borrow()
  {
    if (IsAvailable())
    {
      AvailableQuantity--;
    }
  }

  public void Return()
  {
    if (AvailableQuantity < TotalQuantity)
    {
      AvailableQuantity++;
    }
  }
}