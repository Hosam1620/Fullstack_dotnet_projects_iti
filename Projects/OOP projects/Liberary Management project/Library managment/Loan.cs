using System;
using System.Collections.Generic;
using System.Text;

namespace Library_managment
{

    internal class Loan
    {
        public int LoanID { get; set; }
        public Book BorrowedBook { get; set; }
        public Member Borrower { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsReturned { get; set; }
        


        public Loan(int loanID, Book borrowedBook, Member borrower, int durationDays)
        {
            this.LoanID = loanID;
            this.BorrowedBook = borrowedBook;
            this.Borrower = borrower;
            this.BorrowDate = DateTime.Now;
            this.DueDate = DateTime.Now.AddDays(durationDays);
            this.IsReturned = false;
        }


        public void CheckReturn()
        {
            if (IsReturned)
                Console.WriteLine($"Book '{BorrowedBook?.Name}' was returned.");
            else
                Console.WriteLine($"Book '{BorrowedBook?.Name}' is still with {Borrower?.Name}.");
        }


        public int ReturnTime()
        {
            return (DueDate - DateTime.Now).Days;
        }


        public void CalcFine()
        {
            if (!IsReturned && DateTime.Now > DueDate)
            {
                int lateDays = ReturnTime();
                  
                Borrower?.AddFine(lateDays * 10);
            }
        }

        public override string? ToString()
        {
            return $"Id: {this.LoanID}\nBook: {this.BorrowedBook.Name}\nMember: {this.Borrower.Name}\nfine:{this.Borrower.Fine}";
        }
    }
}
