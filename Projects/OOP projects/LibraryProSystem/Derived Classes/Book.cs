using LibraryProSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProSystem.Derived_Classes
{
    public class Book : LibraryItem, IBorrowable
    {
        public string Author { get; set; }
        public int Copies { get; set; }

        public Book(int id, string title, string author, int copies) : base(id, title)
        {
            Author = author;
            Copies = copies;
        }

        public bool CheckAvailability() => Copies > 0;

        public void Borrow() { if (CheckAvailability()) Copies--; }
        public void Return() => Copies++;

        public override void DisplayInfo() =>
            Console.WriteLine($"Book ID: {ID}\n Title: {Title}\n Author: {Author}\n Available: {Copies}\n");
    }
}
