namespace InClass2Lab
{
    public class Grade
    {
        public string Student { get; set; }

        public int StudentTotal { get; set; }

        public Grade(string student, int studenttotal)
        {
            this.Student = student;
            this.StudentTotal = studenttotal;
        }
    }
}