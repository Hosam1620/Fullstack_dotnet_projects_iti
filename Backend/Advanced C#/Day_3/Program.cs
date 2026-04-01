using Day_3.Exams;
using Day_3.Questions;

namespace Day_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(1, "OOP");

            Exam exam = new PracticeExam(60);

            var q1 = new TrueFalseQuestion(EQuestionType.TrueFalse, "C# is OOP language?", 5, true);

            var q2 = new ChooseOneQuestion(EQuestionType.MCQ, "Which is value type?", 5, 2);
            
            q2.Answers.Add(new Answer(1, "String"));
            q2.Answers.Add(new Answer(2, "Int"));
            q2.Answers.Add(new Answer(3, "Object"));

            

            subject.Exam = exam;

            exam.StartExam();
        }
    }
}


