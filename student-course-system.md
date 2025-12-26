# 🧑‍🎓 Система барои идоракунии донишҷӯён ва курсҳо



## 🧱 Сохтори классҳо

### Student

Ҳусусиятҳо:

-   int Id
-   string FirstName
-   string LastName
-   int BirthYear
-   string Address

### Course

Ҳусусиятҳо:

-   int Id
-   string Title
-   string Description
-   int StudentId

------------------------------------------------------------------------

## Коллексияҳо

Дар Program.cs эҷод кунед:

-   List`<Student>` students
-   List`<Course>` courses

------------------------------------------------------------------------

# 📌 Вазифаҳо (Tasks)

## CRUD барои донишҷӯён

### 1. AddStudent(Student student)

-   маълумотро аз console гирад\
-   Id автомати зиёд карда шавад\
-   Student ба рӯйхат илова гардад

### 2. GetAllStudents()

Намоиш:

ID: 1 \| Ali Karimov \| BirthYear: 2004 \| Address: Dushanbe

### 3. UpdateStudent(Student student)

-   маълумоти донишҷӯ иваз шавад\
-   агар вуҷуд надошта бошад → "Student not found"

### 4. DeleteStudent(int id)

-   донишҷӯ ҳазф шавад\
-   ҳамаи курсҳои дорои ҳамин StudentId низ ҳазф шаванд

------------------------------------------------------------------------

## CRUD барои курсҳо

### 5. AddCourse(Course course)

-   аввал санҷед, ки донишҷӯ вуҷуд дорад\
-   агар набошад → "Student not found"\
-   курс илова карда шавад

### 6. GetCoursesByStudentId(int studentId)

Намоиши ҳамаи курсҳои ин донишҷӯ.

### 7. UpdateCourse(Course course)

### 6. GetCoursesByStudentId(int studentId)


Тағйири маълумоти курс.

### 8. DeleteCourse(int courseId)

Ҳазфи курс аз рӯйхат.

------------------------------------------------------------------------

# 🔥 Методҳои иловагӣ 

9.  SearchStudentByName(string text)\
10. GetCourseCountByStudent()\
11. GetAdultStudents(int minAge)\
12. GetStudentsWithoutCourses()\
13. GetStudentsWithMoreThanNCourses(int n)\
14. DeleteAllCoursesOfStudent(int studentId)\
15. RemoveStudentsWithoutAddress()\
16. GetStudentsByAddress(string text)\
17. SortStudentsByLastName()\
18. SortCoursesByTitle()\
19. GetYoungestStudent()\
20. GetOldestStudent()\
21. EditStudentAddress(int studentId,string newAddres)\
22. EditStudentBirthYear(int studentId,int birthYear)\
23. ClearAllCourses()\
24. ClearAllStudents()\
25. ExistsStudent(int id)\
26. ExistsCourse(int id)\
27. GetStudentsByBirthYear(int year)\
28. GetCoursesByTitlePart(string text)\


------------------------------------------------------------------------

# 🖥 Менюи барнома
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

------------------------------------------------------------------------
