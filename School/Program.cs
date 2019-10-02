using System;
using System.Collections.Generic;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Taemin = new Student("Taemin");
            Student Onew = new Student("Onew");
            List<Student> students = new List<Student>() { Taemin };
            Course SHINee = new Course("SHINee", "Lee Soo Man", students);
            SHINee.AddStudent(Onew);

            Console.WriteLine(SHINee.Name);
            Console.WriteLine(SHINee.Professor);
            
            Taemin.AddGrade(5, 100);
            Taemin.AddGrade(5, 90);
            Console.WriteLine(Taemin.GetGradeLevel());
            //Console.WriteLine(Taemin.Gpa); //set to private

            Console.WriteLine(Taemin); //Taemin (Credits: 10, GPA: 95)

            Onew.AddGrade(3, 80);

            Console.WriteLine(SHINee);
            Console.WriteLine(Taemin.Equals(Taemin));
            Console.WriteLine(Taemin.Equals(Onew));
        }
    }
}
