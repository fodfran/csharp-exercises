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
        public List<Student> Students { get; set; }

        public Course(string name, string professor, List<Student> students)
        {
            CourseId = nextCourseId++;
            Name = name;
            Professor = professor;
            Students = students;
        }
    }
}
