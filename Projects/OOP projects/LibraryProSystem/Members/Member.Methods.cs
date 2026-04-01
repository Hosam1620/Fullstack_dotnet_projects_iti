using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProSystem.Members
{
    public partial class Member
    {
        //Add fine.
        public void CalcFine(int lateDays) => FineBalance += lateDays * 10;
        public void PayFine(decimal amount)
        {
            if (amount > 0) FineBalance -= amount;
            else
            { Console.WriteLine("invalid amount"); }
            
        }
        public void Borrow() { BorrowedNumber--; }
        public void Return() => BorrowedNumber++;
        public override string ToString() => $"Member: {Name} \n(ID: {MemberID})\nFines: ${FineBalance}\n";
    }

}
