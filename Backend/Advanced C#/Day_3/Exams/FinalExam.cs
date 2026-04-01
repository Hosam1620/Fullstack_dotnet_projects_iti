using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Day_3.Exams
{
    public class FinalExam : Exam
    {
        public FinalExam(int time) : base(time) { }

        protected override void ShowResult()
        {
            Console.WriteLine($"Final Grade: {sumOfGrade}");
        }
    }

}
