using System;
using System.Collections.Generic;

namespace InClass2Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is inClass2Lab");

            Student student1 = new Student("A01182496", "Neil", "Quizon");
            Student student2 = new Student("A01111111", "Donald", "Trump");
            Student student3 = new Student("A09999999", "Michael", "Jordan");
            Student student4 = new Student("A01234567", "John", "Doe");

            List<Student> myStudentListB = new List<Student>();
            myStudentListB.Add(student1);
            myStudentListB.Add(student2);

            List<Student> myStudentListA = new List<Student>();
            myStudentListA.Add(student3);
            myStudentListA.Add(student4);

            Section sectionA = new Section(1, "A", myStudentListA);
            Section sectionB = new Section(2, "B", myStudentListB);

            Grade grade1 = new Grade(student1, 20);
            Grade grade2 = new Grade(student1, 20);
            List<Grade> grades = new List<Grade>();
            grades.Add(grade1);
            grades.Add(grade2);
            Assignment assignment1 = new Assignment("InClass2Lab", sectionB, 20, grades);

            Printer.PrintStudentNames(sectionA);
            Printer.PrintStudentNames(sectionB);

            Printer.PrintAssignmentGrades(assignment1);
            Printer.PrintAssignmentStudentGrade(assignment1, "A01182496");

            Console.ReadLine();


        }
    }
}
