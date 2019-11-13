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

            Console.ReadLine();


        }
    }
}
