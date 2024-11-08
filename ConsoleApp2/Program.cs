using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp2.Person;
using static ConsoleApp2.Exam;
using static ConsoleApp2.Student;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.WriteLine("Short String:");
            Console.WriteLine(student.ToShortString());

            student.Education = Education.Specialist;
            student.GroupNumber = 2;

            Console.WriteLine("\nFull String:");
            Console.WriteLine(student.ToFullString());

            student.AddExams(
                new Exam("Math", 4, new DateTime(2022, 2, 2)),
                new Exam("Physics", 5, new DateTime(2022, 3, 3))
            );

            Console.WriteLine("\nFull String with Exams:");
            Console.WriteLine(student.ToFullString());
        }
    }
}