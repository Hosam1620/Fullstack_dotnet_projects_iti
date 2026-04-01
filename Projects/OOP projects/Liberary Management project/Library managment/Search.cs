using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Library_managment
{
    internal class Search
    {
        public List<Book> books ;

        public Search(List<Book> books)
        {
            this.books = books;
        }

        
        public Book? SearchByName(string name)
        {
            
            foreach (Book book in books)
            {

                if (book.Name!=null&&book.Name.ToLower().Equals(name.ToLower()))
                {
                    return book;
                }    
            }
            return null;

        }
       
        public void SearchByAuthor(string author)
        {
            bool isfound = false;
            foreach (Book book in books)
            {

                if (book.AuthorName != null && book.AuthorName.ToLower().Equals(author.ToLower()))
                {
                    Console.WriteLine($"Book {book.Name} is found");
                    isfound = true;
                }
            }
            if (!isfound)
            {
                Console.WriteLine("Book is not found");
            }
        }

        public void SearchByCategory(string category)
        {
            bool isfound = false;
            foreach (Book book in books)
            {
                if (book.Category!=null&&book.Category.ToLower().Equals(category.ToLower()))
                    Console.WriteLine($"Book {book.Name} is found");
            }
            if (!isfound)
            { Console.WriteLine("Book is not found"); }
        }

    }
}
