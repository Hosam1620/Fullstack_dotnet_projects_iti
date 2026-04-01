using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3.Exams
{
    using Day_3.Questions;
    using System.Collections.Generic;

    public abstract class Exam
    {
        public int Time { get; set; }
        public List<Question<object>> Questions { get; set; }
        protected Dictionary<Question<object>, object> CorrectAnswers { get; set; } 
        protected int sumOfGrade = 0;
        public Exam(int time)
        {
             Questions= new List<Question<object>>();
            CorrectAnswers= new Dictionary<Question<object>, object>();
            this.Time = time;
        }

        public void AddQuestion(Question<object> question)
        {
            Questions.Add(question);
        }

        public void StartExam()
        {

            foreach (var question in Questions)
            {
                question.ShowQuestion();
                Console.Write("Your Answer: ");
                var input = Console.ReadLine();

                bool result = question.CheckAnswer(ParseInput(input!));
                CorrectAnswers.Add(question, question.RightAnswer!);
                if (result)
                    sumOfGrade += question.Marks;

                Console.WriteLine();
            }

            ShowResult();
        }

        protected abstract void ShowResult();

        private object ParseInput(string input)
        {
            if (input.Contains(","))
            {
                var parts = input.Split(',');
                var list = new List<int>();
                foreach (var p in parts)
                    list.Add(int.Parse(p));
                return list;
            }
            return int.Parse(input);
        }
    }

}
