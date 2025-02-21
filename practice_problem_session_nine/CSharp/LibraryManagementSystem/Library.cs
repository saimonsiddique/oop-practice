public class Library
{
  private List<Book> books;
  private List<Member> members;
  private List<BorrowRecord> borrowRecords;


  public Library()
  {
    books = new List<Book>();
    members = new List<Member>();
    borrowRecords = new List<BorrowRecord>();
  }

  public void AddBook(string title, string author, string isbn, int quantity)
  {
    Book existingBook = books.Find(b => b.ISBN == isbn);
    if (existingBook != null)
    {
      existingBook.UpdateQuantity(quantity);
    }
    else
    {
      Book book = new Book(title, author, isbn, quantity);
      books.Add(book);
    }
  }

  public void RemoveBook(string isbn)
  {
    Book book = books.Find(b => b.ISBN == isbn);
    if (book != null)
    {
      bool isBorrowed = borrowRecords.Exists(br => br.Book.ISBN == isbn && br.ReturnDate == null);
      if (!isBorrowed)
      {
        books.Remove(book);
      }
      else
      {
        throw new Exception("Book is currently borrowed and cannot be removed.");
      }
    }
  }

  public void RegisterMember(string memberId, string name, string contactInfo)
  {
    if (members.Exists(m => m.MemberId == memberId))
    {
      throw new Exception("Member already registered.");
    }
    else
    {
      Member member = new Member(memberId, name, contactInfo);
      members.Add(member);
    }
  }

  public List<Book> SearchBooks(string query)
  {
    return books.FindAll(b =>
        b.Title.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0 ||
        b.Author.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0 ||
        b.ISBN.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0);
  }

  public void BorrowBook(string isbn, string memberId)
  {
    Book book = books.Find(b => b.ISBN == isbn);
    Member member = members.Find(m => m.MemberId == memberId);

    if (book == null)
    {
      throw new Exception("Book not found.");
    }
    if (member == null)
    {
      throw new Exception("Member not found. Please register first.");
    }
    if (book.IsAvailable())
    {
      book.Borrow();
      BorrowRecord record = new BorrowRecord(book, member);
      borrowRecords.Add(record);
      member.BorrowRecords.Add(record);
    }
    else
    {
      throw new Exception("Book is not available for borrowing.");
    }
  }

  public void ReturnBook(string isbn, string memberId)
  {
    BorrowRecord record = borrowRecords.Find(br =>
        br.Book.ISBN == isbn &&
        br.Member.MemberId == memberId &&
        br.ReturnDate == null);

    if (record != null)
    {
      record.MarkReturned();
      if (record.IsLate())
      {
        throw InvalidReturnException("Book returned late.");
      }
      else
      {
        record.Book.Return();
      }
    }
    else
    {
      throw new Exception("Book not found in borrow records.");
    }
  }

  public List<BorrowRecord> ViewBorrowingHistory(string memberId)
  {
    Member member = members.Find(m => m.MemberId == memberId);
    if (member != null)
    {
      return member.BorrowRecords;
    }
    return new List<BorrowRecord>();
  }

  public void NotifyDueBooks()
  {
  }
}
