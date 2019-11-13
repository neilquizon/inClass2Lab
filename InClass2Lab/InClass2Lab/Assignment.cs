using System;
using System.Collections.Generic;
using System.Text;

namespace InClass2Lab
{
    public class Assignment
    {
        public string AssignmentName { get; set; }

        public Section Section { get; set; }

        public int Total { get; set; }

        public List<Grade> GradeList { get; set; }

        public Assignment(string assignmentName, Section section, int total, List<Grade> gradelist)
        {
            this.AssignmentName = assignmentName;
            this.Section = section;
            this.Total = total;
        }
    }
}
