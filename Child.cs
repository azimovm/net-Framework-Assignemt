namespace Assignment1;

public class Child
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    // constructors
    public Child()
    {
        Name = "?";
        Age = 0;
    }

    public Child(string aName, string aSurname, int aAge)
    {
        Name = aName;
        Surname = aSurname;
        Age = aAge;
    }
    
    //Method
    public virtual string ToString()
    {
        return $"{GetType().Name} - {Name} - {Surname} - {Age}";
    }
    
    //Operation
    public static Child operator ++(Child child)
    {
        child.Age++;
        return child;
    }
}