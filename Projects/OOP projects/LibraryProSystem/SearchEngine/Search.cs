using LibraryProSystem.Derived_Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProSystem.SearchEngine
{
    public class Search
    {
        private List<Book> items;
        public Search(List<Book> items) => this.items = items;
        public Book? FindByTitle(string title)
        {

            foreach (Book book in items)
            {

                if (book.Title != null && book.Title.ToLower().Equals(title.ToLower()))
                {
                    return book;
                }
            }
            return null;
        }

        public void SearchByAuthor(string author)
        {
            bool isfound = false;
            foreach (Book book in items)
            {

                if (book.Author != null && book.Author.ToLower().Equals(author.ToLower()))
                {
                    Console.WriteLine($"Book {book.Title} is found");
                    isfound = true;
                }
            }
            if (!isfound)
            {
                Console.WriteLine("Book is not found");
            }
        }

    }

   
}
