namespace Assignment1;

public class Student : Child
{
    public string HiSchool { get; set; }
    public string Faculty { get; set; }
    public string Year { get; set; }

    // constructors
    public Student()
    {
        HiSchool = "?";
        Faculty = "?";
        Year = "?";
    }

    public Student(string aName, string aSurname, int aAge, string aHiSchool, string aFaculty, string aYear) : base(aName, aSurname, aAge)
    {
        HiSchool = aHiSchool;
        Faculty = aFaculty;
        Year = aYear;
    }
    
    //Method
    public override string ToString()
    {
        return $"{GetType().Name} - {Name} - {Surname} - {Age} - {HiSchool} - {Faculty} - {Year}";
    }
}