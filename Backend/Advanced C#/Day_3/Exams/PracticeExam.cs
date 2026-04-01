using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Day_3.Exams
{
    public class PracticeExam : Exam
    {
        public PracticeExam(int time) : base(time) { }

        protected override void ShowResult()
        {
            Console.WriteLine("Correct Answers are:");
            foreach (var item in CorrectAnswers)
            {
                Console.WriteLine($"{item.Key}:{item.Value}.");
            }
        }

    }
}
