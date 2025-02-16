Student student1 = new Student("Saimon", "1234", "saimon@yopmail.com");
Student student2 = new Student("Sabbir", "5678", "sabbir@yopmail.com");
Student student3 = new Student("Rahim", "91011", "rahim@yopmail.com");

Course course1 = new Course("CSE101", "Introduction to Programming", 3);
Course course2 = new Course("CSE102", "Data Structure", 3);
Course course3 = new Course("CSE103", "Algorithm", 3);

Enrollment enrollment1 = new Enrollment(student1, course1, DateTime.Now);
Enrollment enrollment2 = new Enrollment(student1, course2, DateTime.Now);
Enrollment enrollment3 = new Enrollment(student2, course1, DateTime.Now);
Enrollment enrollment4 = new Enrollment(student2, course3, DateTime.Now);


EnrollmentCollection enrollmentCollection = new EnrollmentCollection();
enrollmentCollection.AddEnrollment(enrollment1);
enrollmentCollection.AddEnrollment(enrollment2);
enrollmentCollection.AddEnrollment(enrollment3);
enrollmentCollection.AddEnrollment(enrollment4);

foreach (Enrollment enrollment in enrollmentCollection.GetAllEnrollments())
{
  Console.WriteLine(
    $"Student: {enrollment.TakenBy.Name}, " +
    $"Course: {enrollment.EnrolledIn.Title}, " +
    $"Enrollment Date: {enrollment.EnrollmentDate}"
  );
}