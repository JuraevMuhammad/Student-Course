
using System.IO.Enumeration;
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
        _students.Add(student);
        Console.WriteLine($"Student {student.Id} has been added");
    }

    public void GetAllStudents()
    {
        foreach (var student in _students)
        {
            student.GetInfo();
        }
        Console.WriteLine("===================");
    }

    public void UpdateStudent(Student student)
    {
        var result = _students.Find(x => x.Id == student.Id);
        if (result != null)
        {
            result.FirstName = student.FirstName;
            result.LastName = student.LastName;
            result.BirthYear = student.BirthYear;
            result.Address = student.Address;
            Console.WriteLine($"Student {result.Id} has been updated");
            return;
        }

        Console.WriteLine($"Student {student.Id} not found");
    }

    #region DeleteStudent

    public void DeleteStudent(int id)
    {
        var result = _students.Find(x => x.Id == id);
        if (result != null)
        {
            _students.Remove(result);
            Console.WriteLine($"Student {result.Id} has been deleted");
            return;
        }
        Console.WriteLine($"Student {id} has been deleted");
    }

    #endregion

    #region SearchStudentByName

    public List<Student> SearchStudentByName(string name)
    {
        var result = _students.Where(x => x.FirstName.ToLower().Contains(name.ToLower())).ToList();
        if (result != null)
        {
            Console.WriteLine("---Students found---");
            return result;
        }

        return null;
    }

    #endregion

    #region GetStudentsWithoutCourses
    private List<Student> resStudents = new();
    public List<Student> GetStudentsWithoutCourses()
    {
        try
        {
            foreach (var student in _students)
            {
                foreach (var course in _courses)
                {
                    if (student.Id != course.Id)
                    {
                        resStudents.Add(student);
                    }
                }
            }

            if (resStudents.Count == 0)
            {
                throw new Exception("No students found");
            }

            return resStudents;
        }
        catch
        {
            throw new Exception("Error getting students");
        }
    }
    #endregion

    #region GetStudentsWithMoreThanNCourses

    private List<Student> _getStudent = new();
    private List<Student> _getStudents = new();
    public List<Student> GetStudentsWithMoreThanNCourses(int n)
    {
        try
        {
            foreach (var student in _students)
            {
                foreach (var course in _courses)
                {
                    if (student.Id == course.Id)
                    {
                        _getStudent.Add(student);
                    }

                    if (_getStudent.Count > n)
                    {
                        _getStudents.Add(student);
                    }
                }
            }

            if (_getStudents.Count == 0)
            {
                return null;
            }

            return _getStudent;
        }
        catch
        {
            throw new Exception("Error getting students");
        }
    }
    #endregion

    #region GetStudentsByAddress

    private List<Student> _getStudentsByAddress = new();
    public List<Student> GetStudentsByAddress(string text)
    {
        var res = _getStudentsByAddress.Where(x => x.Address.ToLower().Contains(text.ToLower())).ToList();
        if (res.Count == 0)
        {
            return null;
        }
        else
        {
            return res;
        }
    }

    #endregion

    #region GetStudentsByBirthYear

    private List<Student> _getStudentsByBirthYear = new();
    public List<Student> GetStudentsByBirthYear(int year)
    {
        var res = _students.Where(x => x.BirthYear == year).ToList();
        if (res.Count == 0)
        {
            Console.WriteLine("No students found");
            return res;
        }
        Console.WriteLine("Students found");
        return res;
    }

    #endregion

    #region SortStudentsByLastName

    private List<Student> _sortStudent = new();
    public List<Student> SortStudentsByLastName()
    {
        _sortStudent = _students.OrderBy(x => x.LastName).ToList();
        return _sortStudent;
    }

    #endregion

    #region GetYoungestStudent

    public Student GetYoungestStudent()
    {
        var res = _students.Max(x => x.BirthYear);
        var result = _students.FirstOrDefault(x => x.BirthYear == res);

        return result;
    }

    #endregion

    #region GetOldestStudent

    public Student GetOldestStudent()
    {
        var res = _students.OrderBy(x => x.BirthYear).FirstOrDefault();
        return res;
    }

    #endregion

    #region ExistsStudent

    public bool ExistsStudent(int id)
    {
        var res = _students.Where(x => x.Id == id).Take(1).FirstOrDefault();
        if (res == null)
        {
            return false;
        }
        return true;
    }

    #endregion

    #region DeleteAllCoursesOfStudent

    public void DeleteAllCoursesOfStudent(int studentId)
    {
        _courses.RemoveAll(x => x.Id == studentId);
    }

    #endregion

    #region RemoveStudentsWithoutAddress

    public void RemoveStudentsWithoutAddress()
    {
        _students.RemoveAll(x => x.Address == null);
    }

    #endregion

    #region EditStudentAddress

    public void EditStudentAddress(int studentId, string newAddress)
    {
        var res = _students.Where(x => x.Id == studentId).FirstOrDefault();
        if (res == null)
        {
            Console.WriteLine("No students found");
            return;
        }
        res.Address = newAddress;
        Console.WriteLine("Update student address");
        return;
    }

    #endregion

    #region EditStudentBirthYear

    public void EditStudentBirthYear(int studentId, int birthYear)
    {
        var res = _students.Where(x => x.Id == studentId).FirstOrDefault();
        if (res == null)
        {
            Console.WriteLine("No students found");
            return;
        }
        
        Console.WriteLine("Update student birth year");
        res.BirthYear = birthYear;
    }

    #endregion

    #region ClearAllStudents

    public void ClearAllStudents()
    {
        _students.Clear();
        Console.WriteLine("---Clear all Students---");
    }

    #endregion

    // Course Methods

    #region AddCourse

    public void AddCourse(Course course)
    {
        _courses.Add(course);
        Console.WriteLine($"Create course Id: {course.Id}");
    }

    #endregion

    #region GetCoursesByStudentId

    public void GetCoursesByStudentId(int studentId)
    {
        var res = _courses.Find(x => x.StudentId == studentId);
        if (res == null)
        {
            Console.WriteLine("Course not found");
            return;
        }
        
        res.DisplayInfo();
    }

    #endregion

    #region UpdateCourse

    public void UpdateCourse(Course course)
    {
        var res = _courses.Where(x => x.Id == course.Id).FirstOrDefault();
        if(res == null)
        {
            Console.WriteLine("Course not found");
            return;
        }

        res.Description = course.Description;
        res.Title = course.Title;
        Console.WriteLine("Updated Course " + res.Title);
    }

    #endregion

    #region DeleteCourse

    public void DeleteCourse(int courseId)
    {
        var res = _courses.Find(x => x.Id == courseId);
        if (res == null)
        {
            Console.WriteLine("Course not found");
            return;
        }
        _courses.Remove(res);
        // _courses.RemoveAll(x => x.Id == courseId);
    }

    #endregion

    #region GetCourseCountByStudentId

    public int GetCourseCountByStudentId(int studentId)
    {
        var res = _courses.Where(x => x.StudentId == studentId).ToList();
        if (res != null)
        {
            return res.Count;
        }

        return 0;
    }

    #endregion

    #region GetAdultStudents

    public List<Course> GetAdultStudents(int minAge = 18)
    {
        var res = _students.Where(x => (2025 - x.BirthYear) >= minAge).ToList();
        var result = _courses.Where(x => x.StudentId == res.FirstOrDefault().Id).ToList();
        return result;
    }

    #endregion

    #region GetCoursesByTitlePart

    public List<Course> GetCoursesByTitlePart(string text)
    {
        var res = _courses.Where(x => x.Title.ToLower().Contains(text.ToLower())).ToList();
        return res;
    }

    #endregion

    #region SortCoursesByTitle

    public List<Course> SortCoursesByTitle()
    {
        var res = _courses.OrderBy(x => x.Title).ToList();
        return res;
    }

    #endregion

    #region ExistsCourse

    public bool ExistsCourse(int id)
    {
        bool res = _courses.Any(x => x.Id == id);
        return res;
    }

    #endregion

    #region ClearAllCourses

    public void ClearAllCourses()
    {
        _courses.Clear();
    }

    #endregion
}
