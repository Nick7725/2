using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp2.Person;
using static ConsoleApp2.Exam;
using static ConsoleApp2.Program;

namespace ConsoleApp2
{
    internal class Student
    {
        private Person pers;
        private Education educ;
        private int gNumber;
        private Exam[] exam;

        public Student(Person person, Education education, int groupNumber)
        {
            pers = person;
            educ = education;
            gNumber = groupNumber;
            exam = new Exam[0];
        }

        public Student()
        {
            pers = new Person("John", "Doe", new DateTime(1990, 1, 1));
            educ = Education.Bachelor;
            gNumber = 1;
            exam = new Exam[0];
        }

        public Person Person
        {
            get { return pers; }
            set { pers = value; }
        }

        public Education Education
        {
            get { return educ; }
            set { educ = value; }
        }

        public int GroupNumber
        {
            get { return gNumber; }
            set { gNumber = value; }
        }

        public Exam[] Exams
        {
            get { return exam; }
            set { exam = value; }
        }

        public double AverageGrade
        {
            get
            {
                if (exam.Length == 0) return 0;
                int sum = 0;
                foreach (var exam in exam) sum += exam.Grade;
                return (double)sum / exam.Length;
            }
        }

        public void AddExams(params Exam[] exams)
        {
            exam = exam.Concat(exams).ToArray();
        }

        public string ToFullString()
        {
            string examsString = string.Join(", ", exam.Select(e => e.ToFullString()));
            return $"{pers.ToFullString()}, Education: {educ}, Group: {gNumber}, Exams: {examsString}";
        }

        public string ToShortString()
        {
            return $"{pers.ToShortString()}, Education: {educ}, Group: {gNumber}, Average Grade: {AverageGrade:F2}";
        }
    }
}

