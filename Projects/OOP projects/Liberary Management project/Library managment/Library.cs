using System;
using System.Collections.Generic;
using System.Text;

namespace Library_managment
{
    internal class Library
    {
        public Library()
        {
            this.members = new List<Member>();
            this.books = new List<Book>();
            this.loans = new List<Loan>();
        }
        public Library(List<Book> books, List<Loan> loans, List<Member> members)
        {
            this.members = members;
            this.books = books;
            this.loans = loans;
        }

        List<Book> books { set; get; }
        List<Loan> loans {  set; get; }
        List<Member> members {  set; get; }

        public void AddBook(Book book) => books.Add(book);

        public void AddLoan(Loan loan) => loans.Add(loan);

        public void AddMember(Member member) => members.Add(member);

        public void BorrowBook(int idForLoanOperation, string bookName, string memberName)
        {
            Search searchBook = new Search(books);

            SearchAboutMember searchMember = new SearchAboutMember(members);

            Loan loan = new(idForLoanOperation, searchBook.SearchByName(bookName), searchMember.SearchByName(memberName), 10);

            loans.Add(loan);
        }

        public void Display()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book.ToString());
            }
            foreach (var member in members)
            {
                Console.WriteLine(member.ToString());
            }
            foreach (var loan in loans)
            {
                Console.WriteLine(loan.ToString());
            }
        }

        public void Save() 
        { 
            FileManager.Save<Book>("books.json", books);
            FileManager.Save<Loan>("loans.json", loans);
            FileManager.Save<Member>("members.json", members);
        }

    }
}
