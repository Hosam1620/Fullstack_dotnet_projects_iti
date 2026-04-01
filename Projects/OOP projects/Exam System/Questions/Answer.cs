using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3.Questions
{
    public class Answer
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public Answer(int id, string text)
        {
            Id = id;
            Text = text;
        }
    }
}
