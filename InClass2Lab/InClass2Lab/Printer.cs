using System;
using System.Collections.Generic;
using System.Text;

namespace InClass2Lab
{
    class Printer
    {
        public static void PrintStudentNames(Section section)
        {
            Console.WriteLine("List of students");

            foreach (Student student in section.StudentList)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();
        }
    }
}
