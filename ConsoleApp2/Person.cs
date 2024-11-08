using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp2.Program;
using static ConsoleApp2.Exam;
using static ConsoleApp2.Student;

namespace ConsoleApp2
{

        public class Person
        {
            private string fName;
            private string lName;
            private DateTime bDate;
            public Person(string firstName, string lastName, DateTime birthDate)
            {
                fName = firstName;
                lName = lastName;
                bDate = birthDate;
            }
            public Person()
            {
                fName = "John";
                lName = "Doe";
                bDate = new DateTime(1990, 1, 1);
            }
            public string FirstName
            {
                get { return fName; }
                set { fName = value; }
            }

            public string LastName
            {
                get { return lName; }
                set { lName = value; }
            }

            public DateTime BirthDate
            {
                get { return bDate; }
                set { bDate = value; }
            }
            public int BirthYear
            {
                get { return bDate.Year; }
                set { bDate = new DateTime(value, bDate.Month, bDate.Day); }
            }

            public string ToFullString()
            {
                return $"{FirstName} {LastName},  {BirthDate}";
            }

            public string ToShortString()
            {
                return $"{FirstName} {LastName}";
            }
        }
    }

