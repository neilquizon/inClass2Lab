using System;
using System.Collections.Generic;
using System.Text;

namespace InClass2Lab
{
    class Printer
    {
        public static void PrintStudentNames(Section section)
        {
            foreach (Student student in section.StudentList)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();
        }

        public static void PrintAssignmentGrades(Assignment assignment)
        {
            Console.WriteLine("List of student id and grades for " + assignment.AssignmentName + ":");

            foreach (Grade grade in assignment.Grades)
            {
                Console.WriteLine( grade.StudentTotal + "/" + assignment.Total);
            }
            Console.WriteLine();


        }

        public static void PrintAssignmentStudentGrade(Assignment assignment, string studentid)
        {
            Console.WriteLine("Grade List of Student with ID :" + studentid + " for " + assignment.AssignmentName);

            foreach (Grade grade in assignment.Grades)
            {
                if(grade.student.StudentId == studentid)
                {
                    Console.WriteLine(grade.StudentTotal);
                }
            }
        }
    }
}
