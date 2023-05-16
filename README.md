# Assignmets Tasks
# Assignment 1
# TASK 1
Implement the base class Child and the derived classes Pupil and Student, as shown in the diagram.
The base class Child defines general properties:
  string Name (name)
  string Surname (surname)
  int Age (age in years)
constructors:
  Child(), which assigns values to the fields Name="?" and Age=0
  Child(aName, aSurname, aAge), which assigns values to the fields specified
general method:
            string ToString() - the return value of the method is a string with information about the object (type - name - surname - age)
and the operation:
            ++, which increases the age by 1 (without range checking).

The derived classes Pupil and Student have their own constructors, new fields, and a redefined ToString() method.
Class Pupil:
  string School (school)
  string Class (class)
  Pupil (aName, aSurname, aAge, aSchool, aClass) - assigns values to the fields specified
  string ToString() - the return value of the method is a string with information about the object (type - name - surname - age - school - class)
Class Student:
  string HiSchool (university)
  string Faculty (faculty)
  string Year (year)
  Student (aName, aSurname, aAge, aHiSchool, aFaculty, aYear) - assigns values to the fields specified in parentheses
  string ToString() - the return value of the method is a string with information about the object (type - name - surname - age - university - faculty - year)

In the main program, create objects: 1 Child, 1 Pupil, and 1 Student. Make sure that all methods and the ++ operation work correctly with all 3 objects.
![image](https://github.com/azimovm/net-Framework-Assignemt/assets/72945232/1bf4cc77-fca0-43c4-aae9-5106e51e0db1)

# TASK 1.1
Using the previously implemented classes (Child, Pupil, Student), create an array called "People" with 10 elements, and randomly insert objects with the probabilities: Child - 50%, Pupil - 30%, Student - 20%.
The name of each object should be the class name + the order number, for example, Pupil3. Age - a random number (Child – (1..7), Pupil –(6..20), Student – (18..70). Use random numbers for other fields as well (school, class...) (can also be combinations of letters).
Make sure that all methods work correctly by calling them in a loop for all object types.
![image](https://github.com/azimovm/net-Framework-Assignemt/assets/72945232/87ca9ff4-257f-426e-97ac-581a7107cf7b)


# Assignment 2
# TASK 1

Requirements:
Create a window with a drawing tools and a white drawing area.
Create Menu with commands:
New
Open
Save
Print
 Each command must work with a sound effect.
Create the Toolbar with the tools, create an icon for each tool. Tools:
Pen
Line
Rectangle
Ellipse
Eraser
Color selection dialog (ColorDialog) (objects need to be drawn with the selected color)

