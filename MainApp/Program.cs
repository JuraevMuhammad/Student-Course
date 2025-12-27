

using Domain;
using Service;

StudentService studentService = new();

try
{
    while (true)
    {
        Console.WriteLine("""
                          1.  Иловаи донишҷӯ
                          2.  Иловаи курс
                          3.  Намоиши ҳамаи донишҷӯён
                          4.  Намоиши ҳамаи курсҳо барои як донишҷӯ
                          5.  Тағйири донишҷӯ (UpdateStudent)
                          6.  Тағйири курс (UpdateCourse)
                          7.  Ҳазфи донишҷӯ (DeleteStudent)
                          8.  Ҳазфи курс (DeleteCourse)
                          
                          9.  Ҷустуҷӯи донишҷӯ аз рӯи ном (SearchStudentByName)
                          10. Шумораи курсҳо барои ҳар донишҷӯ (GetCourseCountByStudent)
                          11. Намоиши донишҷӯёни болиғ (GetAdultStudents)
                          12. Намоиши донишҷӯёни бе курс (GetStudentsWithoutCourses)
                          13. Донишҷӯёни дорои зиёда аз N курс (GetStudentsWithMoreThanNCourses)
                          
                          14. Ҳазфи ҳамаи курсҳои як донишҷӯ (DeleteAllCoursesOfStudent)
                          15. Ҳазфи донишҷӯёне, ки суроға надоранд (RemoveStudentsWithoutAddress)
                          16. Ҷустуҷӯи донишҷӯ аз рӯи суроға (GetStudentsByAddress)
                          
                          17. Ҷобаҷокунии донишҷӯён аз рӯи насаб (SortStudentsByLastName)
                          18. Ҷобаҷокунии курсҳо аз рӯи ном (SortCoursesByTitle)
                          
                          19. Донишҷӯи ҷавонтарин (GetYoungestStudent)
                          20. Донишҷӯи калонтарин (GetOldestStudent)
                          
                          21. Тағйири суроғаи донишҷӯ (EditStudentAddress)
                          22. Тағйири соли таваллуди донишҷӯ (EditStudentBirthYear)
                          
                          23. Пок кардани ҳамаи курсҳо (ClearAllCourses)
                          24. Пок кардани ҳамаи донишҷӯён (ClearAllStudents)
                          
                          25. Санҷидани вуҷуд доштани донишҷӯ (ExistsStudent)
                          26. Санҷидани вуҷуд доштани курс (ExistsCourse)
                          
                          27. Намоиши донишҷӯён аз рӯи соли таваллуд (GetStudentsByBirthYear)
                          28. Ҷустуҷӯи курс аз рӯи порчаи ном (GetCoursesByTitlePart)
                          
                          0.  Хуруҷ
                          
                          """);
        Console.Write("Выберите пункт: ");
        int input = int.Parse(Console.ReadLine());

        switch (input)
        {
            case 1:
                Console.WriteLine($"---Add Student---");
                Console.Write($"Введите имя студента: ");
                string firstName = Console.ReadLine();
                Console.Write($"Введите фамилию стедента: ");
                string lastName = Console.ReadLine();
                Console.Write($"Введите год рождение студента: ");
                int birthYear = int.Parse(Console.ReadLine());
                Console.Write($"Введите адрес студента: ");
                string address = Console.ReadLine();

                try
                {
                    studentService.AddStudent(new Student(firstName, lastName, birthYear, address));
                    Console.WriteLine("Add Student " + firstName);
                }
                catch
                {
                    studentService.AddStudent(new Student(firstName, lastName, birthYear));
                    Console.WriteLine("Add  Student " + firstName);
                }
                break;
            case 2:
                Console.WriteLine($"---Add Course---");
                Console.Write($"Введите название курса: ");
                string title = Console.ReadLine();
                Console.Write($"Введите описание курса: ");
                string description = Console.ReadLine();
                Console.Write($"Введите ID студента который там учится: ");
                int studentId = int.Parse(Console.ReadLine());
                
                try
                {
                    studentService.AddCourse(new Course(title, description, studentId));
                    Console.WriteLine("Add Course " + title);
                }
                catch 
                {
                    studentService.AddCourse(new Course(title, studentId));
                    Console.WriteLine("Add  Course " + title);
                }

                break;
            case 3:
                Console.WriteLine($"---Get all Students---");
                
                studentService.GetAllStudents();
                break;
            case 4:
                Console.WriteLine("---Get Course By Student Id---");
                Console.Write($"Введите ID студента: ");
                int Id = int.Parse(Console.ReadLine());
                
                studentService.GetCoursesByStudentId(Id);
                break;
            case 5:
                Console.WriteLine($"---Update Student---");
                Console.Write($"Введите имя студента: ");
                string updateFirstName = Console.ReadLine();
                Console.Write($"Введите фамилию стедента: ");
                string updateLastName = Console.ReadLine();
                Console.Write($"Введите год рождение студента: ");
                int updateBirthYear = int.Parse(Console.ReadLine());
                Console.Write($"Введите адрес студента: ");
                string updateAddress = Console.ReadLine();

                try
                {
                    studentService.AddStudent(new Student(updateFirstName, updateLastName, updateBirthYear, updateAddress));
                    Console.WriteLine("Update Student " + updateFirstName);
                }
                catch
                {
                    studentService.AddStudent(new Student(updateFirstName, updateLastName, updateBirthYear));
                    Console.WriteLine("Update  Student " + updateFirstName);
                }
                break;
            case 6:
                Console.WriteLine($"---Update Course---");
                Console.Write($"Введите название курса: ");
                string updateTitle = Console.ReadLine();
                Console.Write($"Введите описание курса: ");
                string updateDescription = Console.ReadLine();
                Console.Write($"Введите ID студента который там учится: ");
                int updateStudentId = int.Parse(Console.ReadLine());
                
                try
                {
                    studentService.AddCourse(new Course(updateTitle, updateDescription, updateStudentId));
                    Console.WriteLine("Add Course " + updateTitle);
                }
                catch 
                {
                    studentService.AddCourse(new Course(updateTitle, updateStudentId));
                    Console.WriteLine("Add  Course " + updateTitle);
                }

                break;
            case 7:
                Console.WriteLine($"---Delete Student---");
                Console.Write($"Введите ID студента: ");
                int deleteStudent = int.Parse(Console.ReadLine());
                
                studentService.DeleteStudent(deleteStudent);
                break;
            case 8:
                Console.WriteLine("---Delete Course---");
                Console.Write("Введите ID курса: ");
                int deleteCourse = int.Parse(Console.ReadLine());
                
                studentService.DeleteCourse(deleteCourse);
                break;
            case 9:
                Console.WriteLine("---Search Student By Name---");
                Console.Write("Введите имя студента: ");
                string searchName = Console.ReadLine();
                
                var res = studentService.SearchStudentByName(searchName);
                foreach (var item in res)
                {
                    item.GetInfo();
                }

                break;
            case 10:
                Console.WriteLine("---Get Course Count By Student Id---");
                Console.Write("Введите StudentId: ");
                int StudentId = int.Parse(Console.ReadLine());

                int courseCount = studentService.GetCourseCountByStudentId(StudentId);
                
                Console.WriteLine("Count: " + courseCount);
                break;
            case 11:
                Console.WriteLine("---Get Adult Students---");

                var adultStudent = studentService.GetAdultStudents();
                foreach (var item in adultStudent)
                {
                    item.DisplayInfo();
                }

                break;
            case 12:
                Console.WriteLine("---Get Students Without Courses---");

                var students = studentService.GetStudentsWithoutCourses();
                foreach (var item in students)
                {
                    item.GetInfo();
                }

                break;
            case 13:
                Console.WriteLine("");
        }

    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}