public class Assignment
{
  public string Title { get; set; }
  public string Description { get; set; }
  public DateTime DueDate { get; set; }
  public List<Resource> Resources { get; }
  public List<Task> Tasks { get; } = new();
  public List<Submission> Submissions { get; }
}
