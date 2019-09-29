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
            List<Student> students = new List<Student>() { Taemin, Onew };
            Course SHINee = new Course("SHINee", "Lee Soo Man", students);

            Console.WriteLine(SHINee.Name);
            Console.WriteLine(SHINee.Professor);
            foreach (Student student in SHINee.Students)
            {
                Console.WriteLine(student.Name);
                Console.WriteLine(student.StudentId);

            }
            
            
        }
    }
}
