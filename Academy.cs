using System;
using System.Collections.Generic;

// Base class Person
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

// Teacher class derived from Person
public class Teacher : Person
{
    public List<Subject> SubjectsTaught { get; private set; }

    public Teacher(string name, int age) : base(name, age)
    {
        SubjectsTaught = new List<Subject>();
    }

    public void AddSubject(Subject subject)
    {
        SubjectsTaught.Add(subject);
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Subjects taught:");
        foreach (var subject in SubjectsTaught)
        {
            Console.WriteLine($"- {subject.Name}");
        }
    }
}

// Student class derived from Person
public class Student : Person
{
    public List<Subject> SubjectsTaken { get; private set; }

    public Student(string name, int age) : base(name, age)
    {
        SubjectsTaken = new List<Subject>();
    }

    public void AddSubject(Subject subject)
    {
        SubjectsTaken.Add(subject);
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Subjects taken:");
        foreach (var subject in SubjectsTaken)
        {
            Console.WriteLine($"- {subject.Name}");
        }
    }
}

// Subject class
public class Subject
{
    public string Name { get; set; }

    public Subject(string name)
    {
        Name = name;
    }
}

// Academy class
public class Academy
{
    public string AcademyName { get; set; }
    public List<Teacher> Teachers { get; private set; }
    public List<Student> Students { get; private set; }

    public Academy(string name)
    {
        AcademyName = name;
        Teachers = new List<Teacher>();
        Students = new List<Student>();
    }

    public void AddTeacher(Teacher teacher)
    {
        Teachers.Add(teacher);
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public void DisplayAll()
    {
        Console.WriteLine($"Academy: {AcademyName}");
        Console.WriteLine("Teachers:");
        foreach (var teacher in Teachers)
        {
            teacher.Display();
        }
        Console.WriteLine("Students:");
        foreach (var student in Students)
        {
            student.Display();
        }
    }
}
