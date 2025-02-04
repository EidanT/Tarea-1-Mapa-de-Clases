using System;

public class CommunityMember
{
    public string Name { get; set; }
    public int Age { get; set; }

    public CommunityMember(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void ShowInformation()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

public class Employee : CommunityMember
{
    public string Position { get; set; }

    public Employee(string name, int age, string position) : base(name, age)
    {
        Position = position;
    }

    public override void ShowInformation()
    {
        base.ShowInformation();
        Console.WriteLine($"Position: {Position}");
    }
}

public class Student : CommunityMember
{
    public string Major { get; set; }

    public Student(string name, int age, string major) : base(name, age)
    {
        Major = major;
    }

    public override void ShowInformation()
    {
        base.ShowInformation();
        Console.WriteLine($"Major: {Major}");
    }
}

public class ExStudent : CommunityMember
{
    public int GraduationYear { get; set; }

    public ExStudent(string name, int age, int graduationYear) : base(name, age)
    {
        GraduationYear = graduationYear;
    }

    public override void ShowInformation()
    {
        base.ShowInformation();
        Console.WriteLine($"Graduation Year: {GraduationYear}");
    }
}

public class Teacher : Employee
{
    public Teacher(string name, int age, string position) : base(name, age, position) { }
}

public class Administrator : Employee
{
    public Administrator(string name, int age, string position) : base(name, age, position) { }
}


public class Manager : Teacher
{
    public Manager(string name, int age) : base(name, age, "Manager") { }
}

public class Instructor : Teacher
{
    public Instructor(string name, int age) : base(name, age, "Instructor") { }
}

class Program
{
    static void Main()
    {
        CommunityMember student = new Student("Manuel Perez", 20, "Engineering");
        student.ShowInformation();

        Console.WriteLine();

        CommunityMember instructor = new Instructor("Carlos Lopez", 40);
        instructor.ShowInformation();

        Console.ReadKey();
    }
}
