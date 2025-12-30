namespace Domain;

public class Course
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int StudentId { get; set; }

    public Course(string title, string description, int studentId)
    {
        Title = title;
        Description = description;
        StudentId = studentId;
    }

    public Course(string title, int studentId)
    {
        Title = title;
        StudentId = studentId;
    }
    
    public Course()
    {
        
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Id: {Id}, title: {Title}, description: {Description}");
    }
}