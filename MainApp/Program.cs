

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
                Console.WriteLine("---Get Students With More Than 'N' Courses---");
                Console.Write("Введите минимальное число курсов: ");
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    var result = studentService.GetStudentsWithMoreThanNCourses(number);
                    foreach (var item in result)
                    {
                        item.GetInfo();
                    }

                    break;
                }
                catch
                {
                    throw new Exception("Введите только число!");
                    break;
                }
            case 14:
                Console.WriteLine("---Delete all Course of Student---");
                Console.Write("Введите ID студента: ");
                try
                {
                    int deleteId = int.Parse(Console.ReadLine());
                    studentService.DeleteAllCoursesOfStudent(deleteId);
                    Console.WriteLine("Delete All Course of Student => " + deleteId);
                    break;
                }
                catch
                {
                    throw new Exception("Введите только число!");
                    break;
                }
            case 15:
                Console.WriteLine("---Remove Students Without Address---");
                studentService.RemoveStudentsWithoutAddress();
                break;
            case 16:
                Console.WriteLine("---Get Students By Address---");
                Console.Write("Введите адрес студента: ");
                string studentAddress = Console.ReadLine();
                
                studentService.GetStudentsByAddress(studentAddress);
                break;
            case 17:
                Console.WriteLine("---Sort Students By Last Name---");
                
                var orderByLastName 
                    = studentService.SortStudentsByLastName();
                
                foreach (var item in orderByLastName)
                {
                    item.GetInfo();
                }
                break;
            case 18:
                Console.WriteLine("---Sort Courses By Title---");
                
                var orderByTitle
                    = studentService.SortCoursesByTitle();

                foreach (var item in orderByTitle)
                {
                    item.DisplayInfo();
                }

                break;
            case 19:
                Console.WriteLine("---Get Youngest Student---");
                
                var youngestStudent 
                    = studentService.GetYoungestStudent();
                
                youngestStudent.GetInfo();
                break;
            case 20:
                Console.WriteLine("---Get Oldest Student---");
                
                var oldestStudent
                    =  studentService.GetOldestStudent();
                
                oldestStudent.GetInfo();
                break;
            case 21:
                Console.WriteLine("---Edit Student Address---");
                try
                {
                    Console.Write("Введите ID студента: ");
                    int editId = int.Parse(Console.ReadLine());
                    Console.Write("Введите new Address: ");
                    string newAddress = Console.ReadLine();
                    
                    studentService.EditStudentAddress(editId, newAddress);
                    break;
                }
                catch
                {
                    throw new Exception("В ID пишите только цыфры");
                    break;
                }
            case 22:
                Console.WriteLine("---Edit Student Birth Year---");
                Console.Write("Введите ID студента: ");
                int birthId = int.Parse(Console.ReadLine());
                Console.Write("Введите новый год рождения: ");
                int editBirthYear = int.Parse(Console.ReadLine());
                if (editBirthYear > 1950 &&  editBirthYear < 2025)
                {
                    studentService.EditStudentBirthYear(birthId, editBirthYear);
                }
                else
                {
                    Console.WriteLine("Error!");
                }
                break;
            case 23:
                Console.WriteLine("---Clear All Courses---");
                
                studentService.ClearAllCourses();
                Console.WriteLine("---Clear all Courses---");
                break;
            case 24:
                Console.WriteLine("---Clear All Students---");
                
                studentService.ClearAllStudents();
                Console.WriteLine("---Clear all Students---");
                break;
            case 25:
                Console.WriteLine("---Exists Student---");
                Console.Write("Введите ID студента: ");
                int existsId = int.Parse(Console.ReadLine());
                
                bool isExist = studentService.ExistsStudent(existsId);
                
                Console.WriteLine("is exist: " + isExist);
                break;
            case 26:
                Console.WriteLine("---Exists Course---");
                Console.Write("Введите ID студента: ");
                int existsIdCourse = int.Parse(Console.ReadLine());
                
                bool isExistCourse = studentService.ExistsCourse(existsIdCourse);
                
                Console.WriteLine("is exist: " + isExistCourse);
                break;
            case 27:
                Console.WriteLine("---Get Students By Birth Year---");
                Console.WriteLine("Введите год (year) для поиска: ");
                int yearStudents = int.Parse(Console.ReadLine());

                var getByBirthYear
                    = studentService.GetStudentsByBirthYear(yearStudents);

                if (getByBirthYear.Count > 0)
                {
                    Console.WriteLine($"Нашлось -{getByBirthYear.Count}- студентов.\nХотите их увидеть? (Yes || No)");
                    Console.Write("-");
                    string answer = Console.ReadLine();
                    if (answer.ToLower() == "yes")
                    {
                        foreach (var item in getByBirthYear)
                        {
                            item.GetInfo();
                        }

                        break;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            case 28:
                Console.WriteLine("---Get Courses By Title Part---");
                Console.Write("Введите название курса для поиска: ");
                string titleCourse = Console.ReadLine();

                var searchCourses 
                    = studentService.GetCoursesByTitlePart(titleCourse);

                if (searchCourses.Count > 0)
                {
                    Console.WriteLine($"Нашлось -{searchCourses.Count}- студентов.\nХотите их увидеть? (Yes || No)");
                    Console.Write("-");
                    string answer = Console.ReadLine();
                    if (answer.ToLower() == "yes")
                    {
                        foreach (var item in searchCourses)
                        {
                            item.DisplayInfo();
                        }

                        break;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            case 0:
                Console.WriteLine("====================");
                return;
            default:
                Console.WriteLine("Попробуйте ещё раз!");
                break;
        }

    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}