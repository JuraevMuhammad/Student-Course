namespace Domain.Interface;

public interface IStudent
{
    //CRUD Student
    void AddStudent(Student student);
    void GetAllStudents();
    void UpdateStudent(Student student);
    void DeleteStudent(int id);
    
    //Additional Methods
    List<Student>  SearchStudentByName(string name);
    
    List<Student> GetStudentsWithoutCourses();
    List<Student> GetStudentsWithMoreThanNCourses(int n);
    List<Student> GetStudentsByAddress(string text);
    List<Student> GetStudentsByBirthYear(int year);

    List<Student> SortStudentsByLastName();

    Student GetYoungestStudent();
    Student GetOldestStudent();

    bool ExistsStudent(int id);


    // ====== Изменение и удаление (void-методы) ======

    void DeleteAllCoursesOfStudent(int studentId);
    void RemoveStudentsWithoutAddress();

    void EditStudentAddress(int studentId, string newAddress);
    void EditStudentBirthYear(int studentId, int birthYear);

    void ClearAllStudents();
    
}