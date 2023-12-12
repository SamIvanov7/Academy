using System;

class Program
{
    static void Main()
    {
        
        Academy myAcademy = new Academy("Sam's Academy");

        Subject math = new Subject("Mathematics");
        Subject science = new Subject("Science");
        Subject chemistry = new Subject("Chemistry");

        Teacher teacher1 = new Teacher("Oleks", 35);
        teacher1.AddSubject(math);
        teacher1.AddSubject(science);
        Teacher teacher2 = new Teacher("Alesha", 42);
        teacher2.AddSubject(chemistry);

        Student student1 = new Student("Vasya", 16);
        student1.AddSubject(math);
        student1.AddSubject(science);
        Student student2 = new Student("Vanya", 15);
        student2.AddSubject(chemistry);

        myAcademy.AddTeacher(teacher1);
        myAcademy.AddTeacher(teacher2);
        myAcademy.AddStudent(student1);
        myAcademy.AddStudent(student2);

        myAcademy.DisplayAll();
    }
}
