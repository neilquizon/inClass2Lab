namespace InClass2Lab
{
    public class Grade
    {
        public Student student { get; set; }

        public int StudentTotal { get; set; }

        public Grade(Student student, int studenttotal)
        {
            this.student = student;
            this.StudentTotal = studenttotal;
        }
    }
}