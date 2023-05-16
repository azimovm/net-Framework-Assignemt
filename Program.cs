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
        
        task2();
    }

    static void task2()
    {
        /*
         Using the previously implemented classes (Child, Pupil, Student), create an array called "People" with 10 elements, and randomly insert objects with the probabilities: Child - 50%, Pupil - 30%, Student - 20%.
        The name of each object should be the class name + the order number, for example, Pupil3. Age - a random number (Child – (1..7), Pupil –(6..20), Student – (18..70). Use random numbers for other fields as well (school, class...) (can also be combinations of letters).
        Make sure that all methods work correctly by calling them in a loop for all object types.

         */
        Child[] people = new Child[10];
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            int probability = random.Next(1, 100);
            var rnd = new Random();
            if (probability <= 50)
            {
                people[i] = new Child($"Child{i}", i.ToString(), random.Next(1, 7));
            }
            else if (probability <= 80)
            {
                people[i] = new Pupil($"Pupil{i}", i.ToString(), random.Next(6, 20), $"School{rnd.Next(1, 10)}", $"Class{rnd.Next(1, 12)}");
            }
            else
            {
                people[i] = new Student($"Student{i}", i.ToString(), random.Next(18, 70), $"HighSchool{rnd.Next(1, 10)}", $"Faculty{rnd.Next(1, 10)}", $"Year{rnd.Next(1, 5)}");
            }
        }
        
        foreach (var person in people)
        {
            var p = person;
            Console.WriteLine(person.ToString());
            p++;
            Console.WriteLine(person.ToString());
        }
    }
}