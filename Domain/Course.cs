namespace Domain;

public class Course
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int StudentId { get; set; }

    private int cnt = 0;
    public Course(string title, string description, int studentId)
    {
        cnt++;
        Id = cnt;
        Title = title;
        Description = description;
        StudentId = studentId;
    }

    public Course(string title, int studentId)
    {
        cnt++;
        Id = cnt;
        Title = title;
        StudentId = studentId;
    }
    
    public Course()
    {
        cnt++;
        Id = cnt;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Id: {Id}, title: {Title}, description: {Description}");
    }
}