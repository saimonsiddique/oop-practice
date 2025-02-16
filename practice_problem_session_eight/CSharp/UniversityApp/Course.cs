public class Course {
    public string Title { get; set; }
    public string Code { get; set; }
    public double Credit { get; set; }
    public Course(string title, string code, double credit) : this() {
        Title = title;
        Code = code;
        Credit = credit;
    }
    public Course()
    {

    }
}