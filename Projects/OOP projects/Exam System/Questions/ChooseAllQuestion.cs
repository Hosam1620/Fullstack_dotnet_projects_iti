using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3.Questions
{
    public class ChooseAllQuestion : Question<List<int>>
    {
        

        public ChooseAllQuestion(EQuestionType header, string body, int marks, List<int> rightAnswers)
            : base(header, body, marks)
        {
            RightAnswer = rightAnswers;
        }

        public override void ShowQuestion()
        {
            Console.WriteLine(Header);
            Console.WriteLine(BodyOfQuestion);
            foreach (var ans in Answers!)
                Console.WriteLine($"{ans.Id}) {ans.Text}");
        }

        public override bool CheckAnswer(object userAnswer)
        {
            var userAnswers = (List<int>)userAnswer;
            
            return new HashSet<int>(userAnswers)
                .SetEquals(RightAnswer!);
        }
    }

}
