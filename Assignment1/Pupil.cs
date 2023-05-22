namespace Assignment1;

public class Pupil : Child
{
    public string School { get; set; }
    public string Class { get; set; }

    // constructors
    public Pupil()
    {
        School = "?";
        Class = "?";
    }

    public Pupil(string aName, string aSurname, int aAge, string aSchool, string aClass) : base(aName, aSurname, aAge)
    {
        School = aSchool;
        Class = aClass;
    }
    
    //Method
    public override string ToString()
    {
        return $"{GetType().Name} - {Name} - {Surname} - {Age} - {School} - {Class}";
    }
}