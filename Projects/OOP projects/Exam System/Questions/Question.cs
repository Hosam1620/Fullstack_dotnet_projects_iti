using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3.Questions
{
    /// <summary>
    /// base class for all types of questions, it is an abstract class that cannot be instantiated,
    /// </summary>
    /// <typeparam name="T"> this param to decided the type of answer</typeparam>
    public abstract class Question<T>
    {
        /// <summary>
        /// Gets or sets the header value associated with the current instance.
        /// will have the type of the question (MCQ, True/False, etc.)
        /// </summary>
        public EQuestionType Header { set; get; }

        /// <summary>
        /// the question header is the question itself,
        /// and the body of the question is the choices and the answer.
        /// </summary>
        public string? BodyOfQuestion { get; set; }
        /// <summary>
        /// Gets or sets the available choices as a string representation.
        /// </summary>
        public List<Answer> Answers { get; set; }

        public T RightAnswer { get; set; }
        public int Marks { get; set; }

        //this constructor is for constructor chaning
        public Question(EQuestionType header, string body, int marks)
        {
            Header = header;
            BodyOfQuestion = body;
            Marks = marks;
            Answers = new List<Answer>();
        }

        public abstract void ShowQuestion();
        public abstract bool CheckAnswer(object userAnswer);

    }
}
