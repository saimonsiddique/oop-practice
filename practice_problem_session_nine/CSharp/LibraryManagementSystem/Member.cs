public class Member
{
  public string MemberId { get; private set; }
  public string Name { get; private set; }
  public string ContactInfo { get; private set; }
  public List<BorrowRecord> BorrowRecords { get; private set; }

  public Member(string memberId, string name, string contactInfo)
  {
    MemberId = memberId;
    Name = name;
    ContactInfo = contactInfo;
    BorrowRecords = new List<BorrowRecord>();
  }
}