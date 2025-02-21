public class BorrowRecord
{
  public Book Book { get; private set; }
  public Member Member { get; private set; }
  public DateTime BorrowDate { get; private set; }
  public DateTime DueDate { get; private set; }
  public DateTime? ReturnDate { get; private set; }

  public BorrowRecord(Book book, Member member, DateTime borrowDate, DateTime dueDate)
  {
    Book = book;
    Member = member;
    BorrowDate = borrowDate;
    DueDate = dueDate;
    ReturnDate = null;
  }

  public void MarkReturned()
  {
    ReturnDate = DateTime.Now;
    Book.Return();
  }

  public bool IsLate()
  {
    if (ReturnDate == null)
    {
      return DateTime.Now > DueDate;
    }
    return ReturnDate > DueDate;
  }
}