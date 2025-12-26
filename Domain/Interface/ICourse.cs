namespace Domain.Interface;

public interface ICourse
{
    //CRUD Course
    void AddCourse(Course course);
    void GetCoursesByStudentId(int studentId);
    void UpdateCourse(Course course);
    void DeleteCourse(int courseId);
    
    //Additional Methods
    int GetCourseCountByStudentId(int studentId);
    List<Course> GetAdultStudents(int minAge);
    
    List<Course> GetCoursesByTitlePart(string text);
    List<Course> SortCoursesByTitle();

    bool ExistsCourse(int id);


    // ====== Удаление и очистка (void-методы) ======

    void ClearAllCourses();
}