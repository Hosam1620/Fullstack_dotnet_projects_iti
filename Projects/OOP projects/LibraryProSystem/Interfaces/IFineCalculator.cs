using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProSystem.Interfaces
{
    public interface IFineCalculator
    {
        void CalcFine(int lateDays);
        void PayFine(decimal amount);
    }
}
