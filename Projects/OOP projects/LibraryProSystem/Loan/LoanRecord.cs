using LibraryProSystem.Derived_Classes;
using LibraryProSystem.Members;
using System;
using System.Collections.Generic;
using System.Text;


namespace LibraryProSystem.Loan
{
    public sealed class LoanRecord
    {
        public int LoanID { get; }
        public Book BorrowedBook { get; }
        public Member Borrower { get; }
        //return time
        public DateTime DueDate { get; }

        public LoanRecord(int loanId, Book book, Member member)
        {
            LoanID = loanId;
            BorrowedBook = book;
            Borrower = member;
            DueDate = DateTime.Now.AddDays(7); 
        }
    }
}
