
using Domain;
using Domain.Interface;

namespace Service;

public class StudentService : IStudent, ICourse
{
    private readonly List<Student> _students = new();
    private readonly List<Course> _courses = new();

    // Student Methods
    public void AddStudent(Student student)
    {
        throw new NotImplementedException();
    }

    public void GetAllStudents()
    {
        throw new NotImplementedException();
    }

    public void UpdateStudent(Student student)
    {
        throw new NotImplementedException();
    }

    public void DeleteStudent(int id)
    {
        throw new NotImplementedException();
    }

    public List<Student> SearchStudentByName(string name)
    {
        throw new NotImplementedException();
    }

    public List<Student> GetStudentsWithoutCourses()
    {
        throw new NotImplementedException();
    }

    public List<Student> GetStudentsWithMoreThanNCourses(int n)
    {
        throw new NotImplementedException();
    }

    public List<Student> GetStudentsByAddress(string text)
    {
        throw new NotImplementedException();
    }

    public List<Student> GetStudentsByBirthYear(int year)
    {
        throw new NotImplementedException();
    }

    public List<Student> SortStudentsByLastName()
    {
        throw new NotImplementedException();
    }

    public Student GetYoungestStudent()
    {
        throw new NotImplementedException();
    }

    public Student GetOldestStudent()
    {
        throw new NotImplementedException();
    }

    public bool ExistsStudent(int id)
    {
        throw new NotImplementedException();
    }

    public void DeleteAllCoursesOfStudent(int studentId)
    {
        throw new NotImplementedException();
    }

    public void RemoveStudentsWithoutAddress()
    {
        throw new NotImplementedException();
    }

    public void EditStudentAddress(int studentId, string newAddress)
    {
        throw new NotImplementedException();
    }

    public void EditStudentBirthYear(int studentId, int birthYear)
    {
        throw new NotImplementedException();
    }

    public void ClearAllStudents()
    {
        throw new NotImplementedException();
    }

    // Course Methods
    public void AddCourse(Course course)
    {
        throw new NotImplementedException();
    }

    public void GetCoursesByStudentId(int studentId)
    {
        throw new NotImplementedException();
    }

    public void UpdateCourse(Course course)
    {
        throw new NotImplementedException();
    }

    public void DeleteCourse(int courseId)
    {
        throw new NotImplementedException();
    }

    public int GetCourseCountByStudentId(int studentId)
    {
        throw new NotImplementedException();
    }

    public List<Course> GetAdultStudents(int minAge)
    {
        throw new NotImplementedException();
    }

    public List<Course> GetCoursesByTitlePart(string text)
    {
        throw new NotImplementedException();
    }

    public List<Course> SortCoursesByTitle()
    {
        throw new NotImplementedException();
    }

    public bool ExistsCourse(int id)
    {
        throw new NotImplementedException();
    }

    public void ClearAllCourses()
    {
        throw new NotImplementedException();
    }
}
