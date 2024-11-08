using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp2.Person;
using static ConsoleApp2.Program;
using static ConsoleApp2.Student;

namespace ConsoleApp2
{
    internal class Exam
    {
        public string Predmet { get; set; }
        public int Grade { get; set; }
        public DateTime ExamDate { get; set; }

        public Exam(string predmet, int grade, DateTime examDate)
        {
            Predmet = predmet;
            Grade = grade;
            ExamDate = examDate;
        }

        public Exam()
        {
            Predmet = "Math";
            Grade = 5;
            ExamDate = new DateTime(2022, 1, 1);
        }

        public string ToFullString()
        {
            return $"{Predmet}, Grade: {Grade}, Date: {ExamDate}";
        }
    }
}
