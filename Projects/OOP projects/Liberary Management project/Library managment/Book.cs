using System;
using System.Collections.Generic;
using System.Text;

namespace Library_managment
{
    internal class Book
    {

        public int ID { get; set; }
        public string? Name { get; set; }
        public string? AuthorName { get; set; }
        public string? Category { get; set; }

        public int PageNumber { get; set; }

        public int PublishYear { get; set; }

        public int Copies { get; set; }
        //public Book() { }
        public Book(int iD, string? name, string? author, string? category, int pageNumber, int publishYear, int copies)
        {
            ID = iD;
            Name = name;
            AuthorName = author;
            Category = category;
            PageNumber = pageNumber;
            PublishYear = publishYear;
            Copies = copies;
        }

        public bool CheckAvailbility() { return Copies>0; }

        public void AddCopies(int copies) {

            if (copies > 0)
            {
                Copies += copies;
                Console.WriteLine($"you Add {copies},and you have {Copies}copies\n");
            }
            else
            {
                Console.WriteLine("please enter the positive number of books");
            }
        }
        public void RemoveCopies(int copies) {
            if (copies <= Copies)
            {
                Copies-= copies;
                Console.WriteLine($"you Delete {copies},and you have {Copies} copies\n");
            }
            else { Console.WriteLine("Not enough copies...!\n"); }
        }
        public void Borrow() {
            if (CheckAvailbility())
            { Copies--; }
        }

        public void Return()
        {
            Copies++; 
        }

        public override string? ToString()
        {
            return $"ID: {ID}\nName: {Name}\nAuthor: {AuthorName}\nPage number: {PageNumber}\n" +
                $"Category: {Category}\nPublish Year: {PublishYear}\nCopies number: {Copies}\n";
        }
    }
}
