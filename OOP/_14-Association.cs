/*
A general relationship between two classes.

Meaning:

One class is connected to another class, but not strongly dependent.

Teacher and Student are just related, not owning each other.

Real life:
Teacher ↔ Student
Doctor ↔ Patient
*/
class Teacher
{
    public string Name;
}

class Student
{
    public string Name;
}