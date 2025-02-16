public class Student
{
  public string Name { get; set; }
  public string RegNo { get; set; }
  public string Email { get; set; }
  private const double MaxCredits = 20;
  private double enrolledCredits;

  public Student(string name, string regNo, string email) : this()
  {
    Name = name;
    RegNo = regNo;
    Email = email;
  }

  public Student()
  {

  }

  public bool CanEnrollCredits(int credits)
  {
    return enrolledCredits + credits <= MaxCredits;
  }

  public void EnrollCredits(int credits)
  {
    if (CanEnrollCredits(credits))
      enrolledCredits += credits;
    else
      throw new InvalidOperationException("Exceeds maximum credit limit of 20");
  }

  public int GetEnrolledCredits()
  {
    return enrolledCredits;
  }
}