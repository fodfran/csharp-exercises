using System;
namespace School
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        private int StudentId { get; set; }
        private int NumberOfCredits { get; set; }
        private double Gpa { get; set; }

        public Student(string name, int numberOfCredits,
                        double gpa)
        {
            StudentId = nextStudentId++;
            Name = name;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name)
            : this(name, 0, 0) { }

        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate properties: NumberOfCredits, Gpa
            double totalScore = Gpa * NumberOfCredits;
            totalScore += grade * courseCredits;
            NumberOfCredits += courseCredits;
            Gpa = totalScore / NumberOfCredits;
        }

        public double GetGpa()
        {
            return Gpa;
        }

        public string GetGradeLevel()
        {
            // Determine the grade level of the student based on NumberOfCredits
            if (NumberOfCredits < 10)
                return "Freshman";
            else if (NumberOfCredits >= 10 && NumberOfCredits < 20)
                return "Sophomore";
            else if (NumberOfCredits >= 20 && NumberOfCredits < 30)
                return "Junior";
            else return "Senior";
        }

        public override String ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
        }

        public override bool Equals(Object o)
        {
            if (o == this)
                return true;
           
            if (o == null)
                return false;          

            if (o.GetType() != GetType())
                return false;
           
            Student studentObj = o as Student;
            return StudentId == studentObj.StudentId;
        }

        public override int GetHashCode()
        {
            return StudentId;
        }
    }
}

