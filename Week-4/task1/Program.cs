namespace task1;

using System;

class Student
{
    // three  instance field of student details
    public string Name;
    public int Age;
    public string Major;

    //static filed for sharing all object of student
    public static string School = "ABC University";
}

class ProgramTask1
{
    static void Main() 
    {
        //two objects of students according to questions wih two sample data
        Student s1 = new Student { Name = "Nispal", Age = 20, Major = "IT" };
        Student s2 = new Student { Name = "Saphal", Age = 22, Major = "CS" };

        Console.WriteLine("Student 1: {0}, Age: {1}, Major: {2}", s1.Name, s1.Age, s1.Major);
        Console.WriteLine("Student 2: {0}, Age: {1}, Major: {2}", s2.Name, s2.Age, s2.Major);

        //displaying school name ( with shared static filed)
        Console.WriteLine("School: " + Student.School);
    }
}
