public class Enrollment
{
  public Student TakenBy { get; set; }
  public Course EnrolledIn { get; set; }
  public DateTime EnrollmentDate { get; set; }
  public Enrollment()
  {

  }
  public Enrollment(Student takenBy, Course enrolledIn, DateTime enrollmentDate)
  {
    if (!takenBy.CanEnrollCredits(enrolledIn.Credit))
    {
      throw new InvalidOperationException("Exceeds maximum credit limit of 20");
    }
    
    TakenBy = takenBy;
    EnrolledIn = enrolledIn;
    EnrollmentDate = enrollmentDate;
  }
}