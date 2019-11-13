using System;
using System.Collections.Generic;
using System.Text;

namespace InClass2Lab
{
    class Student
    {
        public string StudentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Student(string studentId, string firstName, string lastName)
        {
            this.StudentId = studentId;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
