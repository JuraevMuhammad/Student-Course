namespace Domain;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int BirthYear { get; set; }
    public string Address { get; set; }
    
    public Student(string firstName, string lastName, int birthYear, string address)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthYear = birthYear;
        Address = address;
    }
    
    public Student(string firstName, string lastName, int birthYear)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthYear = birthYear;
    }
    
    public Student()
    {
        
    }

    public Student(int id, string firstName, string lastName, int birthYear, string address)
    {
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
