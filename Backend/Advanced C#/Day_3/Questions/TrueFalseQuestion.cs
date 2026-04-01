using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3.Questions
{
    public class TrueFalseQuestion : Question<bool>
    {
       
        public TrueFalseQuestion(EQuestionType header, string body, int marks, bool rightAnswer): base(header, body, marks)
        {
            RightAnswer = rightAnswer;

            // Ensure Answers is initialized before use
            if (Answers == null)
                Answers = new List<Answer>();

            Answers.Add(new Answer(1, "True"));
            Answers.Add(new Answer(2, "False"));
        }

        public override void ShowQuestion()
        {
            Console.WriteLine($"{Header}");
            Console.WriteLine($"{this.BodyOfQuestion}");
            Console.WriteLine("1) True");
            Console.WriteLine("2) False");
        }

        public override bool CheckAnswer(object userAnswer)
        {
            int answer = (int)userAnswer;
            return (answer == 1 && RightAnswer) || (answer == 2 && !RightAnswer);
        }
    }

}
