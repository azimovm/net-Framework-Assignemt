using System.Diagnostics;

namespace Assignment1;

static class Program
{
    // /// <summary>
    // ///  The main entry point for the application.
    // /// </summary>
    // [STAThread]
    // static void Main()
    // {
    //     ApplicationConfiguration.Initialize();
    //     Application.Run(new Form1());
    // }
    
    // In the main program, create objects: 1 Child, 1 Pupil, and 1 Student. Make sure that all methods and the ++ operation work correctly with all 3 objects.
    [STAThread]
    static void Main()
    {
        
        Child child = new Child("John", "Doe", 10);
        Console.WriteLine(child.ToString());

        child++;
        Debug.Assert(child.Age == 11, "Age of child should have been incremented to 11");
        Console.WriteLine(child.ToString());

        Child pupil = new Pupil("Jane", "Doe", 12, "Middle School", "7th Grade");
        Console.WriteLine(pupil.ToString());

        pupil++;
        Debug.Assert(pupil.Age == 13, "Age of pupil should have been incremented to 13");
        Console.WriteLine(pupil.ToString());

        Child student = new Student("James", "Doe", 18, "University", "Computer Science", "First");
        Console.WriteLine(student.ToString());

        student++;
        Debug.Assert(student.Age == 19, "Age of student should have been incremented to 19");
        Console.WriteLine(student.ToString());
    }
}