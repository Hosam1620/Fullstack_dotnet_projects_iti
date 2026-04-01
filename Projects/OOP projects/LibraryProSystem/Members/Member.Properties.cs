using LibraryProSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProSystem.Members
{
    public partial class Member : IFineCalculator
    {
        public int MemberID { get; set; }
        public string Name { get; set; }
        public int BorrowedNumber {  get; set; }
        public decimal FineBalance { get; private set; }

        public Member(int id, string name)
        {
            MemberID = id;
            Name = name;
        }
    }
}
