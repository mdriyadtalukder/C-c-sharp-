/*
One class has another class, but they can exist independently.

Meaning:
Weak relationship
Child can exist without parent

Real life:
University HAS Departments
Departments can exist without University
*/
class Department
{
    public string Name;
}

class University
{
    public List<Department> departments;

    public University(List<Department> departments)
    {
        this.departments = departments;
    }
}