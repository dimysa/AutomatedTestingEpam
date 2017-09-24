using System;
using System.Collections.Generic;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var math = new Subject("Math", 8);
            var oop = new Subject("OOP", 10);

            var firstStudent = new Student();
            var secondStudent = new Student();

            firstStudent.Subjects.Add(math);
            firstStudent.Subjects.Add(oop);
            math = new Subject("Math", 5);
            oop = new Subject("OOP", 7);

            secondStudent.Subjects.Add(math);
            secondStudent.Subjects.Add(oop);

            var group = new Group();

            group.Students.Add(firstStudent);
            group.Students.Add(secondStudent);

            var faculty = new Faculty();
            
            faculty.Groups.Add(group);

            var univer = new University();

            univer.Faculties.Add(faculty);

            System.Console.WriteLine(firstStudent.GetAverage());
            System.Console.WriteLine(secondStudent.GetAverage());

            System.Console.WriteLine(group.GetAverage());
            System.Console.WriteLine(faculty.GetAverage());
            System.Console.WriteLine(univer.GetAverage());
        }
    }
}
