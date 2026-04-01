using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3.Questions
{
    public class ChooseOneQuestion : Question<int>
    {
          public ChooseOneQuestion(EQuestionType header, string body, int marks, int rightAnswerId)
            : base(header, body, marks)
        {
            RightAnswer = rightAnswerId;
        }

        public override void ShowQuestion()
        {
            Console.WriteLine(Header);
            Console.WriteLine(this.BodyOfQuestion);
            foreach (var ans in Answers!)
                Console.WriteLine($"{ans.Id}) {ans.Text}");
        }

        public override bool CheckAnswer(object userAnswer)
        {
            return (int)userAnswer == RightAnswer;
        }
    }

}
