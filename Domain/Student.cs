namespace Domain;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int BirthYear { get; set; }
    public string Address { get; set; }

    private int cnt = 0;
    public Student(string firstName, string lastName, int birthYear, string address)
    {
        cnt++;
        Id = cnt;
        FirstName = firstName;
        LastName = lastName;
        BirthYear = birthYear;
        Address = address;
    }
    
    public Student()
    {
        cnt++;
        Id = cnt;
    }

    public Student(int id, string firstName, string lastName, int birthYear, string address)
    {
        cnt++;
        Id = cnt;
        FirstName = firstName;
        LastName = lastName;
        BirthYear = birthYear;
        Address = address;
    }

    public void GetInfo()
    {
        Console.WriteLine($"Id: {Id}, FirstName: {FirstName}, LastName: {LastName}");
    }
}
