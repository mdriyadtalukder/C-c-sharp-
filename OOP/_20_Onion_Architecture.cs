using System;
using System.Collections.Generic;

/*

Database Tables:
Student  -> Id, Name, Email
Trainer  -> Id, Name, Email
Course   -> Id, Name, Description

#onion Architecture:

core layer:model,interface.
Infrastructure layer:Repository
Service layer:Service
presentation layer: Controller

#Architecture:
Frontend
↓
HTML
↓
JS
↓
Frontend Controller (take data)
↓
Frontend Service (send data to backend Controller)
↓
Backend Controller/API (take data)
↓
Backend Service (send data to Repository)
↓
Repository
↓
Database

Controller(frontend) -> Service(frontend) ->Controller(backend) -> Service(backend) -> Repository -> Database
*/

// Fake Database
public class Database
{
    public IList<Student> Students { get; set; }
    public IList<Trainer> Trainers { get; set; }
    public IList<Course> Courses { get; set; }

    public Database()
    {
        Students = new List<Student>();
        Trainers = new List<Trainer>();
        Courses = new List<Course>();
    }
}
//core layers
// ================= MODELS =================

public class Student
{
    public string StudentId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}

public class Trainer
{
    public string TrainerId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}

public class Course
{
    public string CourseId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
//core layer
// ================= REPOSITORY INTERFACES =================

public interface IStudentRepository
{
    void Add(Student student);
    void Remove(Student student);
    Student Update(Student student);
}

public interface ITrainerRepository
{
    void Add(Trainer trainer);
    void Remove(Trainer trainer);
    Trainer Update(Trainer trainer);
}

public interface ICourseRepository
{
    void Add(Course course);
    void Remove(Course course);
    Course Update(Course course);
}

// ================= SERVICE INTERFACES =================

public interface IStudentService
{
    void Add(Student student);
    void Remove(Student student);
    Student Update(Student student);
}

public interface ITrainerService
{
    void Add(Trainer trainer);
    void Remove(Trainer trainer);
    Trainer Update(Trainer trainer);
}

public interface ICourseService
{
    void Add(Course course);
    void Remove(Course course);
    Course Update(Course course);
}
//Infrastructure layer--data access layer--data layer
// ================= REPOSITORIES--working with database(main) (follow SRP) =================

public class StudentRepository : IStudentRepository
{
    private Database _db;

    public StudentRepository(Database db)
    {
        _db = db;
    }

    public void Add(Student student)
    {
        _db.Students.Add(student);
        Console.WriteLine("Student saved to database");
    }

    public void Remove(Student student)
    {
        _db.Students.Remove(student);
        Console.WriteLine("Student removed from database");
    }

    public Student Update(Student student)
    {
        Console.WriteLine("Student updated in database");
        return student;
    }
}

public class TrainerRepository : ITrainerRepository
{
    private Database _db;

    public TrainerRepository(Database db)
    {
        _db = db;
    }

    public void Add(Trainer trainer)
    {
        _db.Trainers.Add(trainer);
        Console.WriteLine("Trainer saved to database");
    }

    public void Remove(Trainer trainer)
    {
        _db.Trainers.Remove(trainer);
        Console.WriteLine("Trainer removed from database");
    }

    public Trainer Update(Trainer trainer)
    {
        Console.WriteLine("Trainer updated in database");
        return trainer;
    }
}

public class CourseRepository : ICourseRepository
{
    private Database _db;

    public CourseRepository(Database db)
    {
        _db = db;
    }

    public void Add(Course course)
    {
        _db.Courses.Add(course);
        Console.WriteLine("Course saved to database");
    }

    public void Remove(Course course)
    {
        _db.Courses.Remove(course);
        Console.WriteLine("Course removed from database");
    }

    public Course Update(Course course)
    {
        Console.WriteLine("Course updated in database");
        return course;
    }
}
//Service layer--business logic layer
// ================= SERVICES- write business logics(follow DIS) =================

public class StudentService : IStudentService
{
    private IStudentRepository _studentRepository;

    public StudentService(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public void Add(Student student)
    {
        Console.WriteLine("Student business logic executed");
        _studentRepository.Add(student);
    }

    public void Remove(Student student)
    {
        _studentRepository.Remove(student);
    }

    public Student Update(Student student)
    {
        return _studentRepository.Update(student);
    }
}

public class TrainerService : ITrainerService
{
    private ITrainerRepository _trainerRepository;

    public TrainerService(ITrainerRepository trainerRepository)
    {
        _trainerRepository = trainerRepository;
    }

    public void Add(Trainer trainer)
    {
        Console.WriteLine("Trainer business logic executed");
        _trainerRepository.Add(trainer);
    }

    public void Remove(Trainer trainer)
    {
        _trainerRepository.Remove(trainer);
    }

    public Trainer Update(Trainer trainer)
    {
        return _trainerRepository.Update(trainer);
    }
}

public class CourseService : ICourseService
{
    private ICourseRepository _courseRepository;

    public CourseService(ICourseRepository courseRepository)
    {
        _courseRepository = courseRepository;
    }

    public void Add(Course course)
    {
        Console.WriteLine("Course business logic executed");
        _courseRepository.Add(course);
    }

    public void Remove(Course course)
    {
        _courseRepository.Remove(course);
    }

    public Course Update(Course course)
    {
        return _courseRepository.Update(course);
    }
}
//presentation layer--UI layer--Frontend layer
// ================= CONTROLLERS =================

public class StudentController
{
    private IStudentService _studentService;

    public StudentController(IStudentService studentService)
    {
        _studentService = studentService;
    }

    public void Add(Student student)
    {
        _studentService.Add(student);
    }

    public void Remove(Student student)
    {
        _studentService.Remove(student);
    }

    public Student Update(Student student)
    {
        return _studentService.Update(student);
    }
}

public class TrainerController
{
    private ITrainerService _trainerService;

    public TrainerController(ITrainerService trainerService)
    {
        _trainerService = trainerService;
    }

    public void Add(Trainer trainer)
    {
        _trainerService.Add(trainer);
    }

    public void Remove(Trainer trainer)
    {
        _trainerService.Remove(trainer);
    }

    public Trainer Update(Trainer trainer)
    {
        return _trainerService.Update(trainer);
    }
}

public class CourseController
{
    private ICourseService _courseService;

    public CourseController(ICourseService courseService)
    {
        _courseService = courseService;
    }

    public void Add(Course course)
    {
        _courseService.Add(course);
    }

    public void Remove(Course course)
    {
        _courseService.Remove(course);
    }

    public Course Update(Course course)
    {
        return _courseService.Update(course);
    }
}

// ================= MAIN =================

public class Program
{
    public static void Main(string[] args)
    {
        // Fake Database
        Database db = new Database();

        // Dependency Injection
        IStudentRepository studentRepository = new StudentRepository(db);
        IStudentService studentService = new StudentService(studentRepository);
        StudentController studentController =
            new StudentController(studentService);

        // Create Student
        Student student = new Student
        {
            StudentId = "S-101",
            Name = "Riyad Talukder",
            Email = "riyad@gmail.com"
        };

        // Add Student
        studentController.Add(student);

        Console.WriteLine();

        Console.WriteLine("Total Students: " + db.Students.Count);
    }
}

/*
| Principle | Where Used                                    |
| --------- | --------------------------------------------- |
| SRP       | Controller / Service / Repository separated   |
| OCP       | Interfaces + multiple implementations         |
| LSP       | Repository implementations replace interfaces |
| ISP       | Small focused interfaces                      |
| DIP       | Service depends on interface                  |

*/