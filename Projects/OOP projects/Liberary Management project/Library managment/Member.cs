using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Library_managment
{
    internal class Member
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Mail {  get; set; }
        public string? Phone {  get; set; }
        public decimal Fine { get; set; }
        private int maxAllow = 3;
        public int MaxAllow { get { return maxAllow; } }

        public int NumberOfBorrowed { get; set; }
        public List<Book> CurrentBorrowedBooksnew { set; get; } =new List<Book>();
        public Member(int iD, string? name, string? mail, string? phone)
        {
            this.ID = iD;
            this.Name = name;
            this.Mail = mail;
            this.Phone = phone;
        }

        //Methods
        public void Borrow() {
            if (NumberOfBorrowed < maxAllow)
            { 
                NumberOfBorrowed++;
                Console.WriteLine($"you borrow: {NumberOfBorrowed} times\n" +
                    $"you still have {maxAllow - NumberOfBorrowed}times");
            }
        }

        public void Return() { NumberOfBorrowed--;
            Console.WriteLine(
                        $"you still have {NumberOfBorrowed} times to borrow.\n");
        }
        public void AddFine(decimal fine) { if (fine > 0) { this.Fine = fine; } }

        public void PayFine(decimal amount) { if (amount > 0) { Fine -= amount; } }

        public override string? ToString()
        {
            return $"ID: {ID}\nName: {Name}\nMail: {Mail}\nPhone: {Phone}\nFine:{Fine}\nNumber of borrowed books: {NumberOfBorrowed}\n" +
                $"books that you borrowed: {CurrentBorrowedBooksnew}" ;
        }
    }
}
