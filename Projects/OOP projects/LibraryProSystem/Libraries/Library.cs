using LibraryProSystem.Derived_Classes;
using LibraryProSystem.FileManagers;
using LibraryProSystem.Loan;
using LibraryProSystem.Members;
using LibraryProSystem.SearchEngine;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProSystem.Libraries
{
    public class LibraryEngine
    {
        public List<Book> Books { get; set; } = new List<Book>();
        public List<Member> Members { get; set; } = new List<Member>();
        public List<LoanRecord> Loans { get; set; } = new List<LoanRecord>();

        public void BorrowBook(int num,string title, int memberId)
        {
            var searcher = new Search(Books);
            var book = searcher.FindByTitle(title);
            var member = Members.FirstOrDefault(m => m.MemberID == memberId);

            if (book != null && member != null && book.CheckAvailability()&&member.BorrowedNumber<3)
            {
                book.Borrow();
                member.Borrow();
                Loans.Add(new LoanRecord(num, book, member));
                Console.WriteLine($"Success: {member.Name} borrowed '{book.Title}'.");
            }
            else Console.WriteLine($"Failed: Could not process loan for '{title}'.");
        }

        public void ReturnBook( string title, int memberId)
        {
            var searcher = new Search(Books);
            var book = searcher.FindByTitle(title);
            var member = Members.FirstOrDefault(m => m.MemberID == memberId);
            var loan=Loans.FirstOrDefault(m => m.Borrower.MemberID == memberId);
           
            DateTime dates = DateTime.Now;

            int days = loan.DueDate.Day - dates.Day;
           
            book.Return();
            member.Return();
            
            if (days>0)
            {
                member.CalcFine(days);
            }
             
        }

        public void SaveData()
        {
            FileManager.Save("books.json", Books);
            FileManager.Save("members.json", Members);
            FileManager.Save("loans.json", Loans);
            Console.WriteLine("All data saved to JSON files.");
        }

        public void LoadData()
        {
            Books = FileManager.Load<Book>("books.json");
            Members = FileManager.Load<Member>("members.json");
            Loans = FileManager.Load<LoanRecord>("loans.json");
            Console.WriteLine("Data loaded from storage.");
        }
    }
}
