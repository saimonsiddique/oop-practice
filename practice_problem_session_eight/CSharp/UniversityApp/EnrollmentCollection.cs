public class EnrollmentCollection
{
   public List<Enrollment> Enrollments { get; set; }
    public EnrollmentCollection()
    {
        Enrollments = new List<Enrollment>();
    }
    public void AddEnrollment(Enrollment enrollment)
    {
        Enrollments.Add(enrollment);
    }
    public List<Enrollment> GetEnrollments()
    {
        return Enrollments.ToList();
    }

    public List<Enrollment> GetEnrollmentsByStudentRegNo(string regNo)
    {
        return Enrollments.Where(e => e.TakenBy.RegNo == regNo).ToList();
    }

    public List<Enrollment> GetEnrollmentsByCourseCode(string courseCode)
    {
        return Enrollments.Where(e => e.EnrolledIn.Code == courseCode).ToList();
    }
}