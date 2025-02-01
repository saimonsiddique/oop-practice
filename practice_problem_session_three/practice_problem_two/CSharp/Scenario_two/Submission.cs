public class Submission
{
    public int Id { get; }
    public Student Student { get; }
    public Assignment Assignment { get; }
    public DateTime? SubmittedAt { get; private set; }
    public string? Content { get; private set; }
    public bool IsLate { get; private set; }
    public Grade? Grade { get; private set; }

    public void Submit(DateTime submissionTime, string content)
    {
        SubmittedAt = submissionTime;
        Content = content;
    }

    public void GradeAssignment(Grade grade)
    {
        Grade = grade;
    }

    public void MarkAsLate()
    {
        if (SubmittedAt > Assignment.DueDate)
        {
            IsLate = true;
        } else
        {
            IsLate = false;
        }
    }
}

public record Grade(double Score, string Feedback);