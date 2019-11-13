using System;
using System.Collections.Generic;
using System.Text;

namespace InClass2Lab
{
    public class Section
    {
        public int SectionNumber { get; set; }

        public string SectionName { get; set; }

        public List<Student> StudentList { get; set; }

        public Section(int sectionNumber, string sectionName, List<Student> studentList)
        {
            this.SectionNumber = sectionNumber;
            this.SectionName = sectionName;
            this.StudentList = studentList;
        }
    }
}
