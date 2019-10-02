using System;
using System.Collections.Generic;

namespace School
{
    public class Course
    {
        private static int nextCourseId = 1;
        public string Name { get; set; }
        public string Professor { get; set; }
        private int CourseId { get; set; }
        private List<Student> Students { get; set; }
        private double CourseAverage { get; set; }

        public Course(string name, string professor, List<Student> students)
        {
            CourseId = nextCourseId++;
            Name = name;
            Professor = professor;
            Students = students;
            CourseAverage = GetCourseAverage();

        }

        public Course(string name, string professor)
        {
            CourseId = nextCourseId++;
            Name = name;
            Professor = professor;
            Students = new List<Student>();
            CourseAverage = 0;
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            Students.Remove(student);
        }

        private double GetCourseAverage(){
            double classTotal = 0;
            int studentTotal = 0;

            foreach (Student student in Students)
            {
                classTotal += student.GetGpa();
                studentTotal += 1;
            }
            return classTotal / studentTotal;
        }

        private string GetRoster()
        {
            string courseRoster = "Student Roster: \n";
            foreach (Student student in Students)
            {
                courseRoster += student + "\n";
            }
            return courseRoster;
        }

        public override String ToString()
        {
            return Name + " (Professor: " + Professor + ", Course Average: " + GetCourseAverage() + ")\n"
                + GetRoster();
        }

        public override bool Equals(Object o)
        {
            if (o == this)
                return true;

            if (o == null)
                return false;

            if (o.GetType() != GetType())
                return false;

            Course courseObj = o as Course;
            return CourseId == courseObj.CourseId;
        }

        public override int GetHashCode()
        {
            return CourseId;
        }
    }
}
