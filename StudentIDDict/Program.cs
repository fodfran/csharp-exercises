using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentIDDict
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> studentIDs = new Dictionary<string, int>();
            string newStudent;
            int newID;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                Console.WriteLine("Student: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    Console.WriteLine("ID: ");
                    newID = int.Parse(Console.ReadLine());

                    studentIDs.Add(newStudent, newID);
                }

            }
            while (newStudent != "");

            Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<string,int> student in studentIDs)
            {
                Console.WriteLine("Name: " + student.Key
                    + ", ID: " + student.Value);
            }
        }
    }
}
